using HurtowniaFarmaceutycznaLibrary;
using HurtowniaFarmaceutycznaLibrary.Data;
using HurtowniaFarmaceutycznaLibrary.Models;
using System.Text.Json;

namespace HurtowniaFarmaceutycznaApp
{

    public partial class MonitorZapasow : Form
    {
        private List<Medicine> products = new();

        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new();

        public MonitorZapasow()
        {
            InitializeComponent();

            cmbSort.Items.Add("Ilość rosnąco");
            cmbSort.Items.Add("Ilość malejąco");
            cmbSort.Items.Add("Termin rosnąco");
            cmbSort.Items.Add("Termin malejąco");
            cmbSort.SelectedIndex = 0;

            LoadData();
            ClearStatusMessage();


            this.MinimumSize = new Size(600, 400);
        }

        private void ClearStatusMessage()
        {

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // 5 sekund
            timer.Tick += (s, e) =>
            {
                StatusStrip.Text = "";
                timer.Stop();
            };
            timer.Start();
        }

        private void RefreshGrid()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = products;
            ColorExpiredProducts();
        }

        private void LoadData()
        {
            products = DataStorage.Load();
            StatusStrip.ForeColor = Color.LimeGreen;
            StatusStrip.Text = "Dane zostały wczytane z pliku data.json";
            RefreshGrid();
        }

        private void SaveData(List<Medicine> products)
        {
            DataStorage.Save(products);
            StatusStrip.ForeColor = Color.LimeGreen;
            StatusStrip.Text = "Dane zostały zapisane do pliku data.json";
            RefreshGrid();
        }

        private void ColorExpiredProducts()
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                
                if (row.IsNewRow) continue;
                
                DateTime dataWaznosci;
                if (DateTime.TryParse(row.Cells["ExpirationDate"].Value?.ToString(), out dataWaznosci))
                {
                    if (dataWaznosci < DateTime.Now.Date)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // lekko czerwone
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int quantity = (int)numQuantity.Value;
            DateTime expiration = dtpExpiration.Value;
            MedicineType type = (MedicineType)cmbMedicineType.SelectedItem;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Nazwa leku nie może być pusta.");
                return;
            }

            var existing = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && p.ExpirationDate.Date == expiration);

            if (existing != null)
            {
                existing.UpdateQuantity(quantity);
            }
            else
            {

                Medicine med;
                switch (type)
                {
                    case MedicineType.Antybiotyk:
                        med = new Antibiotic(name, quantity, expiration, type);
                        break;
                    case MedicineType.Przeciwbolowa:
                        med = new PainKiller(name, quantity, expiration, type);
                        break;
                    default:
                        throw new Exception("Nieobsługiwany typ leku");

                }
                products.Add(med);
            }
            SaveData(products);

            txtName.Clear();
            numQuantity.Value = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new ProductConverter() }
            };

            SaveData(products);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearStatusMessage();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string? selected = cmbSort.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            switch (selected)
            {
                case "Ilość rosnąco":
                    products = products.OrderBy(p => p.Quantity).ToList();
                    break;
                case "Ilość malej�co":
                    products = products.OrderByDescending(p => p.Quantity).ToList();
                    break;
                case "Termin rosn�co":
                    products = products.OrderBy(p => p.ExpirationDate).ToList();
                    break;
                case "Termin malejąco":
                    products = products.OrderByDescending(p => p.ExpirationDate).ToList();
                    break;
            }

            RefreshGrid();
        }

        private void MonitorZapasow_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            SaveInitialControlBounds(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null) return;

            var selected = dataGridViewProducts.CurrentRow.DataBoundItem as Medicine;
            if (selected == null) return;

            var confirm = MessageBox.Show(
                $"Na pewno usun��: {selected.Name} (do {selected.ExpirationDate:yyyy-MM-dd})?",
                "Potwierd�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                products.Remove(selected);
                SaveData(products);
            }
        }

        private void btnChangeQty_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null) return;

            var selected = dataGridViewProducts.CurrentRow.DataBoundItem as IProduct;
            if (selected == null) return;

            int newQty = (int)numNewQty.Value;
            if (newQty < 0) return;

            int delta = newQty - selected.Quantity;
            selected.UpdateQuantity(delta);

            SaveData(products);
        }

        private void SaveInitialControlBounds(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                originalControlBounds[ctrl] = ctrl.Bounds;
                if (ctrl.HasChildren)
                    SaveInitialControlBounds(ctrl);
            }
        }

        private void MonitorZapasow_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)this.Width / originalFormSize.Width;
            float scaleY = (float)this.Height / originalFormSize.Height;

            ResizeAllControls(this, scaleX, scaleY);
        }

        private void ResizeAllControls(Control parent, float scaleX, float scaleY)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (originalControlBounds.TryGetValue(ctrl, out var bounds))
                {
                    ctrl.Left = (int)(bounds.Left * scaleX);
                    ctrl.Top = (int)(bounds.Top * scaleY);
                    ctrl.Width = (int)(bounds.Width * scaleX);
                    ctrl.Height = (int)(bounds.Height * scaleY);
                }

                if (ctrl.HasChildren)
                    ResizeAllControls(ctrl, scaleX, scaleY);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterName(txtSearch.Text.Trim());
        }
        private void FilterName(string txt)
        {
            var prod = DataStorage.Load();

            if (!string.IsNullOrEmpty(txt))
            {
                txt = txt.ToLower();
                prod = prod.Where(l => l.Name.ToLower().Contains(txt)).ToList();
            }

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = prod;

            ColorExpiredProducts();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wczytajDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearStatusMessage();
        }

        private void zapiszDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new ProductConverter() }
            };
            SaveData(products);

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
