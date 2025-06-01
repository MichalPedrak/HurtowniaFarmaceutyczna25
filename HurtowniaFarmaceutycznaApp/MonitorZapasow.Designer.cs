namespace HurtowniaFarmaceutycznaApp
{
    partial class MonitorZapasow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            txtTitleAdd = new Label();
            txtManageProducts = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            txtData = new Label();
            numNewQty = new NumericUpDown();
            btnChangeQty = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNewQty).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(19, 122);
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
            lblName.Location = new Point(725, 172);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nazwa Leku:";
            lblName.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(832, 164);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nazwa leku";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 2;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.ForeColor = Color.White;
            lblQty.Location = new Point(725, 201);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(34, 15);
            lblQty.TabIndex = 3;
            lblQty.Text = "Ilość:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(725, 230);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Data Ważności:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(832, 193);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(213, 23);
            numQuantity.TabIndex = 5;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpExpiration
            // 
            dtpExpiration.Format = DateTimePickerFormat.Short;
            dtpExpiration.Location = new Point(832, 222);
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
            btnAdd.Location = new Point(725, 251);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(320, 57);
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
            btnSort.Location = new Point(19, 84);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(352, 23);
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
            cmbSort.Location = new Point(19, 55);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(352, 23);
            cmbSort.TabIndex = 11;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.White;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(725, 419);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(320, 23);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Usuń lek";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtTitleAdd
            // 
            txtTitleAdd.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtTitleAdd.ForeColor = Color.FromArgb(0, 192, 192);
            txtTitleAdd.Location = new Point(725, 122);
            txtTitleAdd.Name = "txtTitleAdd";
            txtTitleAdd.Size = new Size(320, 39);
            txtTitleAdd.TabIndex = 13;
            txtTitleAdd.Text = "Dodaj do listy";
            txtTitleAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtManageProducts
            // 
            txtManageProducts.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtManageProducts.ForeColor = Color.FromArgb(0, 192, 192);
            txtManageProducts.Location = new Point(725, 320);
            txtManageProducts.Name = "txtManageProducts";
            txtManageProducts.Size = new Size(320, 42);
            txtManageProducts.TabIndex = 15;
            txtManageProducts.Text = "Zarządzaj lekami";
            txtManageProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.ForeColor = Color.Black;
            btnLoad.Location = new Point(725, 54);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(320, 23);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Wczytaj dane";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(725, 83);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(320, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Zapisz dane";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtData.ForeColor = Color.FromArgb(0, 192, 192);
            txtData.Location = new Point(725, 9);
            txtData.Name = "txtData";
            txtData.Size = new Size(320, 42);
            txtData.TabIndex = 14;
            txtData.Text = "Wczytywanie Danych";
            txtData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numNewQty
            // 
            numNewQty.BorderStyle = BorderStyle.None;
            numNewQty.Location = new Point(725, 365);
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
            btnChangeQty.Location = new Point(725, 390);
            btnChangeQty.Name = "btnChangeQty";
            btnChangeQty.Size = new Size(320, 23);
            btnChangeQty.TabIndex = 19;
            btnChangeQty.Text = "Zmień ilość";
            btnChangeQty.UseVisualStyleBackColor = false;
            btnChangeQty.Click += btnChangeQty_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(85, 236, 85);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 37);
            label1.TabIndex = 20;
            label1.Text = "Hurtownia Farmaceutyczna";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(377, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Wyszukiwanie";
            txtSearch.Size = new Size(342, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // MonitorZapasow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1065, 466);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnChangeQty);
            Controls.Add(numNewQty);
            Controls.Add(txtData);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(txtManageProducts);
            Controls.Add(txtTitleAdd);
            Controls.Add(btnRemove);
            Controls.Add(cmbSort);
            Controls.Add(btnSort);
            Controls.Add(btnAdd);
            Controls.Add(dtpExpiration);
            Controls.Add(numQuantity);
            Controls.Add(lblDate);
            Controls.Add(lblQty);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dataGridViewProducts);
            Name = "MonitorZapasow";
            Text = "Form1";
            Load += MonitorZapasow_Load;
            Resize += MonitorZapasow_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNewQty).EndInit();
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
        private Button btnAdd;
        private Button btnSort;
        private ComboBox cmbSort;
        private Button btnRemove;
        private Label txtTitleAdd;
        private Label txtManageProducts;
        private Button btnLoad;
        private Button btnSave;
        private Label txtData;
        private NumericUpDown numNewQty;
        private Button btnChangeQty;
        private Label label1;
        private TextBox txtSearch;
    }
}
