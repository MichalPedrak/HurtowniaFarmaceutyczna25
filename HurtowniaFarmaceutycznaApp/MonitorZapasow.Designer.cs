namespace HurtowniaFarmaceutycznaApp
{
    using HurtowniaFarmaceutycznaLibrary.Models;
    
    partial class MonitorZapasow
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorZapasow));
            dataGridViewProducts = new DataGridView();
            lblName = new Label();
            txtName = new TextBox();
            lblQty = new Label();
            lblDate = new Label();
            numQuantity = new NumericUpDown();
            dtpExpiration = new DateTimePicker();
            btnAdd = new Button();
            btnSort = new Button();
            cmbSort = new ComboBox();
            btnRemove = new Button();
            numNewQty = new NumericUpDown();
            btnChangeQty = new Button();
            txtSearch = new TextBox();
            lblMedicineType = new Label();
            cmbMedicineType = new ComboBox();
            Sort = new GroupBox();
            AddToTable = new GroupBox();
            ManageList = new GroupBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            wczytajDaneToolStripMenuItem = new ToolStripMenuItem();
            zapiszDaneToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            statusStrip1 = new StatusStrip();
            StatusStrip = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNewQty).BeginInit();
            Sort.SuspendLayout();
            AddToTable.SuspendLayout();
            ManageList.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 150);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(700, 320);
            dataGridViewProducts.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(4, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nazwa Leku:";
            lblName.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 22);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nazwa leku";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.ForeColor = Color.White;
            lblQty.Location = new Point(6, 53);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(34, 15);
            lblQty.TabIndex = 3;
            lblQty.Text = "Ilość:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(6, 86);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Data Ważności:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(111, 51);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(213, 23);
            numQuantity.TabIndex = 5;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Format = DateTimePickerFormat.Short;
            dtpExpiration.Location = new Point(111, 80);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(213, 23);
            dtpExpiration.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(4, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(320, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Dodaj lek";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.White;
            btnSort.FlatAppearance.BorderSize = 0;
            btnSort.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnSort.FlatStyle = FlatStyle.Popup;
            btnSort.ForeColor = Color.Black;
            btnSort.Location = new Point(349, 34);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(345, 23);
            btnSort.TabIndex = 10;
            btnSort.Text = "Sortuj";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // cmbSort
            // 
            cmbSort.BackColor = SystemColors.Window;
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FlatStyle = FlatStyle.Popup;
            cmbSort.ForeColor = SystemColors.WindowText;
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(7, 34);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(336, 23);
            cmbSort.TabIndex = 11;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.White;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(6, 76);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(320, 23);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Usuń lek";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // numNewQty
            // 
            numNewQty.BorderStyle = BorderStyle.None;
            numNewQty.Location = new Point(6, 22);
            numNewQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numNewQty.Name = "numNewQty";
            numNewQty.Size = new Size(320, 19);
            numNewQty.TabIndex = 18;
            numNewQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnChangeQty
            // 
            btnChangeQty.BackColor = Color.White;
            btnChangeQty.FlatAppearance.BorderSize = 0;
            btnChangeQty.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnChangeQty.FlatStyle = FlatStyle.Popup;
            btnChangeQty.ForeColor = Color.Black;
            btnChangeQty.Location = new Point(6, 47);
            btnChangeQty.Name = "btnChangeQty";
            btnChangeQty.Size = new Size(320, 23);
            btnChangeQty.TabIndex = 19;
            btnChangeQty.Text = "Zmień ilość";
            btnChangeQty.UseVisualStyleBackColor = false;
            btnChangeQty.Click += btnChangeQty_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Wyszukiwanie";
            txtSearch.Size = new Size(688, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblMedicineType
            // 
            lblMedicineType.AutoSize = true;
            lblMedicineType.ForeColor = Color.White;
            lblMedicineType.Location = new Point(4, 112);
            lblMedicineType.Name = "lblMedicineType";
            lblMedicineType.Size = new Size(51, 15);
            lblMedicineType.TabIndex = 22;
            lblMedicineType.Text = "Typ leku";
            // 
            // cmbMedicineType
            // 
            
            cmbMedicineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicineType.DataSource = Enum.GetValues(typeof(MedicineType));
            cmbMedicineType.Location = new Point(111, 109);
            cmbMedicineType.Name = "cmbMedicineType";
            cmbMedicineType.Size = new Size(213, 23);
            cmbMedicineType.TabIndex = 2;
            // 
            // Sort
            // 
            Sort.Controls.Add(cmbSort);
            Sort.Controls.Add(btnSort);
            Sort.Controls.Add(txtSearch);
            Sort.Location = new Point(12, 40);
            Sort.Name = "Sort";
            Sort.Size = new Size(700, 104);
            Sort.TabIndex = 24;
            Sort.TabStop = false;
            Sort.Text = "Filtrowanie";
            // 
            // AddToTable
            // 
            AddToTable.Controls.Add(lblName);
            AddToTable.Controls.Add(txtName);
            AddToTable.Controls.Add(lblQty);
            AddToTable.Controls.Add(lblDate);
            AddToTable.Controls.Add(numQuantity);
            AddToTable.Controls.Add(cmbMedicineType);
            AddToTable.Controls.Add(btnAdd);
            AddToTable.Controls.Add(lblMedicineType);
            AddToTable.Controls.Add(dtpExpiration);
            AddToTable.Location = new Point(718, 40);
            AddToTable.Name = "AddToTable";
            AddToTable.Size = new Size(330, 177);
            AddToTable.TabIndex = 25;
            AddToTable.TabStop = false;
            AddToTable.Text = "Dodaj Lek";
            // 
            // ManageList
            // 
            ManageList.Controls.Add(numNewQty);
            ManageList.Controls.Add(btnRemove);
            ManageList.Controls.Add(btnChangeQty);
            ManageList.Location = new Point(718, 223);
            ManageList.Name = "ManageList";
            ManageList.Size = new Size(330, 119);
            ManageList.TabIndex = 26;
            ManageList.TabStop = false;
            ManageList.Text = "Zarządzaj Lekami";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1065, 24);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { wczytajDaneToolStripMenuItem, zapiszDaneToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(38, 20);
            toolStripMenuItem1.Text = "Plik";
            // 
            // wczytajDaneToolStripMenuItem
            // 
            wczytajDaneToolStripMenuItem.Name = "wczytajDaneToolStripMenuItem";
            wczytajDaneToolStripMenuItem.Size = new Size(145, 22);
            wczytajDaneToolStripMenuItem.Text = "Wczytaj Dane";
            wczytajDaneToolStripMenuItem.Click += wczytajDaneToolStripMenuItem_Click;
            // 
            // zapiszDaneToolStripMenuItem
            // 
            zapiszDaneToolStripMenuItem.Name = "zapiszDaneToolStripMenuItem";
            zapiszDaneToolStripMenuItem.Size = new Size(145, 22);
            zapiszDaneToolStripMenuItem.Text = "Zapisz dane";
            zapiszDaneToolStripMenuItem.Click += zapiszDaneToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusStrip });
            statusStrip1.Location = new Point(0, 500);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1065, 22);
            statusStrip1.TabIndex = 28;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusStrip
            // 
            StatusStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(1050, 17);
            StatusStrip.Spring = true;
            StatusStrip.Click += toolStripStatusLabel1_Click;
            // 
            // MonitorZapasow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1065, 522);
            Controls.Add(statusStrip1);
            Controls.Add(ManageList);
            Controls.Add(AddToTable);
            Controls.Add(Sort);
            Controls.Add(dataGridViewProducts);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MonitorZapasow";
            Text = "Hurtownia Farmaceutyczna";
            Load += MonitorZapasow_Load;
            Resize += MonitorZapasow_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNewQty).EndInit();
            Sort.ResumeLayout(false);
            Sort.PerformLayout();
            AddToTable.ResumeLayout(false);
            AddToTable.PerformLayout();
            ManageList.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Label lblName;
        private TextBox txtName;
        private Label lblQty;
        private Label lblDate;
        private NumericUpDown numQuantity;
        private DateTimePicker dtpExpiration;
        private ComboBox cmbMedicineType;
        private Label lblMedicineType;
        private Button btnAdd;
        private Button btnSort;
        private ComboBox cmbSort;
        private Button btnRemove;
        private NumericUpDown numNewQty;
        private Button btnChangeQty;
        private TextBox txtSearch;
        private GroupBox Sort;
        private GroupBox AddToTable;
        private GroupBox ManageList;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem wczytajDaneToolStripMenuItem;
        private ToolStripMenuItem zapiszDaneToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusStrip;
    }
}
