
namespace SnackManager
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDoanhThu = new SnackManager.dsDoanhThu();
            this.tcBill = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnLastBillPage = new System.Windows.Forms.Button();
            this.btnNextBillPage = new System.Windows.Forms.Button();
            this.txbPageBill = new System.Windows.Forms.TextBox();
            this.btnFirstBillPage = new System.Windows.Forms.Button();
            this.btnPreviousBillPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbNameCatagory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnShowCatagory = new System.Windows.Forms.Button();
            this.btnEditCatagory = new System.Windows.Forms.Button();
            this.btnDeleteCatagory = new System.Windows.Forms.Button();
            this.btnAddCatagory = new System.Windows.Forms.Button();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txbTableID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel29 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.billTableAdapter = new SnackManager.dsDoanhThuTableAdapters.BillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoanhThu)).BeginInit();
            this.tcBill.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel11.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel20.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel29.SuspendLayout();
            this.Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.dsDoanhThu;
            // 
            // dsDoanhThu
            // 
            this.dsDoanhThu.DataSetName = "dsDoanhThu";
            this.dsDoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcBill
            // 
            this.tcBill.Controls.Add(this.tpBill);
            this.tcBill.Controls.Add(this.tpFood);
            this.tcBill.Controls.Add(this.tpCategory);
            this.tcBill.Controls.Add(this.tpTable);
            this.tcBill.Controls.Add(this.tpAccount);
            this.tcBill.Controls.Add(this.Report);
            this.tcBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBill.Location = new System.Drawing.Point(0, 0);
            this.tcBill.Name = "tcBill";
            this.tcBill.SelectedIndex = 0;
            this.tcBill.Size = new System.Drawing.Size(660, 462);
            this.tcBill.TabIndex = 0;
            this.tcBill.SelectedIndexChanged += new System.EventHandler(this.tcBill_SelectedIndexChanged);
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel21);
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 24);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(652, 434);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel21.Controls.Add(this.btnLastBillPage);
            this.panel21.Controls.Add(this.btnNextBillPage);
            this.panel21.Controls.Add(this.txbPageBill);
            this.panel21.Controls.Add(this.btnFirstBillPage);
            this.panel21.Controls.Add(this.btnPreviousBillPage);
            this.panel21.Location = new System.Drawing.Point(6, 384);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(643, 47);
            this.panel21.TabIndex = 2;
            this.panel21.Paint += new System.Windows.Forms.PaintEventHandler(this.panel21_Paint);
            // 
            // btnLastBillPage
            // 
            this.btnLastBillPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnLastBillPage.Location = new System.Drawing.Point(565, 3);
            this.btnLastBillPage.Name = "btnLastBillPage";
            this.btnLastBillPage.Size = new System.Drawing.Size(75, 34);
            this.btnLastBillPage.TabIndex = 2;
            this.btnLastBillPage.Text = "Last";
            this.btnLastBillPage.UseVisualStyleBackColor = false;
            this.btnLastBillPage.Click += new System.EventHandler(this.btnLastBillPage_Click);
            // 
            // btnNextBillPage
            // 
            this.btnNextBillPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextBillPage.Location = new System.Drawing.Point(484, 3);
            this.btnNextBillPage.Name = "btnNextBillPage";
            this.btnNextBillPage.Size = new System.Drawing.Size(75, 34);
            this.btnNextBillPage.TabIndex = 4;
            this.btnNextBillPage.Text = "Next";
            this.btnNextBillPage.UseVisualStyleBackColor = false;
            this.btnNextBillPage.Click += new System.EventHandler(this.btnNextBillPage_Click);
            // 
            // txbPageBill
            // 
            this.txbPageBill.Location = new System.Drawing.Point(261, 15);
            this.txbPageBill.Name = "txbPageBill";
            this.txbPageBill.ReadOnly = true;
            this.txbPageBill.Size = new System.Drawing.Size(100, 22);
            this.txbPageBill.TabIndex = 5;
            this.txbPageBill.Text = "1";
            this.txbPageBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPageBill.TextChanged += new System.EventHandler(this.txbPageBill_TextChanged);
            // 
            // btnFirstBillPage
            // 
            this.btnFirstBillPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirstBillPage.Location = new System.Drawing.Point(4, 3);
            this.btnFirstBillPage.Name = "btnFirstBillPage";
            this.btnFirstBillPage.Size = new System.Drawing.Size(75, 34);
            this.btnFirstBillPage.TabIndex = 1;
            this.btnFirstBillPage.Text = "First";
            this.btnFirstBillPage.UseVisualStyleBackColor = false;
            this.btnFirstBillPage.Click += new System.EventHandler(this.btnFirstBillPage_Click);
            // 
            // btnPreviousBillPage
            // 
            this.btnPreviousBillPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousBillPage.Location = new System.Drawing.Point(85, 3);
            this.btnPreviousBillPage.Name = "btnPreviousBillPage";
            this.btnPreviousBillPage.Size = new System.Drawing.Size(75, 34);
            this.btnPreviousBillPage.TabIndex = 3;
            this.btnPreviousBillPage.Text = "Previous";
            this.btnPreviousBillPage.UseVisualStyleBackColor = false;
            this.btnPreviousBillPage.Click += new System.EventHandler(this.btnPreviousBillPage_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 29);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewBill.Location = new System.Drawing.Point(275, 3);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(75, 23);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(438, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(4, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 337);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtgvBill
            // 
            this.dtgvBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(4, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(633, 331);
            this.dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 24);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(652, 434);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(324, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 358);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::SnackManager.Properties.Resources.icon3;
            this.pictureBox1.Location = new System.Drawing.Point(166, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 132);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(4, 159);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(321, 46);
            this.panel10.TabIndex = 6;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(102, 15);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(214, 22);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(3, 107);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(322, 46);
            this.panel9.TabIndex = 5;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(103, 12);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(214, 23);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbFoodName);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(3, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(322, 46);
            this.panel8.TabIndex = 4;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(103, 16);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(214, 22);
            this.txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodID);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(322, 46);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(103, 16);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(214, 22);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.dtgvFood);
            this.panel5.Location = new System.Drawing.Point(3, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 359);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(4, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(305, 353);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.txbSearchFoodName);
            this.panel4.Controls.Add(this.btnSearchFood);
            this.panel4.Location = new System.Drawing.Point(324, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 56);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(4, 18);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(239, 22);
            this.txbSearchFoodName.TabIndex = 5;
            this.txbSearchFoodName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchFood.Location = new System.Drawing.Point(249, 3);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(71, 49);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = false;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(4, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 56);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowFood.Location = new System.Drawing.Point(237, 4);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(71, 49);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditFood.Location = new System.Drawing.Point(160, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(71, 49);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFood.Location = new System.Drawing.Point(83, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(71, 49);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFood.Location = new System.Drawing.Point(6, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(71, 49);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.panel13);
            this.tpCategory.Controls.Add(this.panel12);
            this.tpCategory.Controls.Add(this.panel11);
            this.tpCategory.Location = new System.Drawing.Point(4, 24);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(652, 434);
            this.tpCategory.TabIndex = 2;
            this.tpCategory.Text = "Danh mục";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel13.Controls.Add(this.pictureBox2);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(323, 10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(326, 418);
            this.panel13.TabIndex = 3;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::SnackManager.Properties.Resources.categories2;
            this.pictureBox2.Location = new System.Drawing.Point(123, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbNameCatagory);
            this.panel15.Controls.Add(this.label6);
            this.panel15.Location = new System.Drawing.Point(3, 55);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(320, 46);
            this.panel15.TabIndex = 5;
            // 
            // txbNameCatagory
            // 
            this.txbNameCatagory.Location = new System.Drawing.Point(140, 17);
            this.txbNameCatagory.Name = "txbNameCatagory";
            this.txbNameCatagory.Size = new System.Drawing.Size(177, 22);
            this.txbNameCatagory.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên danh mục:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txbCategoryID);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(320, 46);
            this.panel14.TabIndex = 4;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(141, 8);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(177, 29);
            this.txbCategoryID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel12.Controls.Add(this.dtgvCategory);
            this.panel12.Location = new System.Drawing.Point(3, 65);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(314, 363);
            this.panel12.TabIndex = 2;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(6, 3);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(308, 357);
            this.dtgvCategory.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.Controls.Add(this.btnShowCatagory);
            this.panel11.Controls.Add(this.btnEditCatagory);
            this.panel11.Controls.Add(this.btnDeleteCatagory);
            this.panel11.Controls.Add(this.btnAddCatagory);
            this.panel11.Location = new System.Drawing.Point(3, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(314, 56);
            this.panel11.TabIndex = 1;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // btnShowCatagory
            // 
            this.btnShowCatagory.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowCatagory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowCatagory.Location = new System.Drawing.Point(237, 4);
            this.btnShowCatagory.Name = "btnShowCatagory";
            this.btnShowCatagory.Size = new System.Drawing.Size(71, 49);
            this.btnShowCatagory.TabIndex = 3;
            this.btnShowCatagory.Text = "Xem";
            this.btnShowCatagory.UseVisualStyleBackColor = false;
            this.btnShowCatagory.Click += new System.EventHandler(this.btnShowCatagory_Click);
            // 
            // btnEditCatagory
            // 
            this.btnEditCatagory.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditCatagory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditCatagory.Location = new System.Drawing.Point(160, 3);
            this.btnEditCatagory.Name = "btnEditCatagory";
            this.btnEditCatagory.Size = new System.Drawing.Size(71, 49);
            this.btnEditCatagory.TabIndex = 2;
            this.btnEditCatagory.Text = "Sửa";
            this.btnEditCatagory.UseVisualStyleBackColor = false;
            this.btnEditCatagory.Click += new System.EventHandler(this.btnEditCatagory_Click);
            // 
            // btnDeleteCatagory
            // 
            this.btnDeleteCatagory.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCatagory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCatagory.Location = new System.Drawing.Point(83, 3);
            this.btnDeleteCatagory.Name = "btnDeleteCatagory";
            this.btnDeleteCatagory.Size = new System.Drawing.Size(71, 49);
            this.btnDeleteCatagory.TabIndex = 1;
            this.btnDeleteCatagory.Text = "Xóa";
            this.btnDeleteCatagory.UseVisualStyleBackColor = false;
            this.btnDeleteCatagory.Click += new System.EventHandler(this.btnDeleteCatagory_Click);
            // 
            // btnAddCatagory
            // 
            this.btnAddCatagory.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCatagory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCatagory.Location = new System.Drawing.Point(6, 3);
            this.btnAddCatagory.Name = "btnAddCatagory";
            this.btnAddCatagory.Size = new System.Drawing.Size(71, 49);
            this.btnAddCatagory.TabIndex = 0;
            this.btnAddCatagory.Text = "Thêm";
            this.btnAddCatagory.UseVisualStyleBackColor = false;
            this.btnAddCatagory.Click += new System.EventHandler(this.btnAddCatagory_Click);
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel16);
            this.tpTable.Controls.Add(this.panel19);
            this.tpTable.Controls.Add(this.panel20);
            this.tpTable.Location = new System.Drawing.Point(4, 24);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(652, 434);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel16.Controls.Add(this.pictureBox3);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Location = new System.Drawing.Point(320, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(326, 425);
            this.panel16.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SnackManager.Properties.Resources.table3;
            this.pictureBox3.Location = new System.Drawing.Point(76, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txbTableName);
            this.panel17.Controls.Add(this.label7);
            this.panel17.Location = new System.Drawing.Point(0, 56);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(323, 46);
            this.panel17.TabIndex = 5;
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(133, 16);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(187, 22);
            this.txbTableName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên bàn:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txbTableID);
            this.panel18.Controls.Add(this.label8);
            this.panel18.Location = new System.Drawing.Point(0, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(323, 46);
            this.panel18.TabIndex = 4;
            // 
            // txbTableID
            // 
            this.txbTableID.Location = new System.Drawing.Point(133, 16);
            this.txbTableID.Name = "txbTableID";
            this.txbTableID.ReadOnly = true;
            this.txbTableID.Size = new System.Drawing.Size(187, 22);
            this.txbTableID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // panel19
            // 
            this.panel19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel19.Controls.Add(this.dtgvTable);
            this.panel19.Location = new System.Drawing.Point(3, 62);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(314, 366);
            this.panel19.TabIndex = 5;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(3, 3);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.Size = new System.Drawing.Size(305, 360);
            this.dtgvTable.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel20.Controls.Add(this.btnShowTable);
            this.panel20.Controls.Add(this.btnEditTable);
            this.panel20.Controls.Add(this.btnDeleteTable);
            this.panel20.Controls.Add(this.btnAddTable);
            this.panel20.Location = new System.Drawing.Point(3, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(314, 56);
            this.panel20.TabIndex = 4;
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowTable.Location = new System.Drawing.Point(237, 4);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(71, 49);
            this.btnShowTable.TabIndex = 3;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditTable.Location = new System.Drawing.Point(160, 3);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(71, 49);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = false;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTable.Location = new System.Drawing.Point(83, 3);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(71, 49);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = false;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddTable.Location = new System.Drawing.Point(6, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(71, 49);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel22);
            this.tpAccount.Controls.Add(this.panel27);
            this.tpAccount.Controls.Add(this.panel29);
            this.tpAccount.Location = new System.Drawing.Point(4, 24);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(652, 434);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            this.tpAccount.Click += new System.EventHandler(this.tpAccount_Click);
            // 
            // panel22
            // 
            this.panel22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel22.Controls.Add(this.pictureBox4);
            this.panel22.Controls.Add(this.btnResetPassword);
            this.panel22.Controls.Add(this.panel24);
            this.panel22.Controls.Add(this.panel25);
            this.panel22.Controls.Add(this.panel26);
            this.panel22.Location = new System.Drawing.Point(326, 10);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(320, 421);
            this.panel22.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SnackManager.Properties.Resources.account4;
            this.pictureBox4.Location = new System.Drawing.Point(83, 214);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(195, 159);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(119, 49);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.nudAccountType);
            this.panel24.Controls.Add(this.label11);
            this.panel24.Location = new System.Drawing.Point(3, 107);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(314, 46);
            this.panel24.TabIndex = 5;
            // 
            // nudAccountType
            // 
            this.nudAccountType.Location = new System.Drawing.Point(138, 18);
            this.nudAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(173, 22);
            this.nudAccountType.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txbDisplayName);
            this.panel25.Controls.Add(this.label12);
            this.panel25.Location = new System.Drawing.Point(3, 55);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(314, 46);
            this.panel25.TabIndex = 4;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(138, 17);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(173, 22);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbUserName);
            this.panel26.Controls.Add(this.label13);
            this.panel26.Location = new System.Drawing.Point(3, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(314, 46);
            this.panel26.TabIndex = 3;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(138, 17);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(173, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản:";
            // 
            // panel27
            // 
            this.panel27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel27.Controls.Add(this.dtgvAccount);
            this.panel27.Location = new System.Drawing.Point(5, 68);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(315, 363);
            this.panel27.TabIndex = 6;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(4, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(305, 357);
            this.dtgvAccount.TabIndex = 0;
            // 
            // panel29
            // 
            this.panel29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel29.Controls.Add(this.btnShowAccount);
            this.panel29.Controls.Add(this.btnEditAccount);
            this.panel29.Controls.Add(this.btnDeleteAccount);
            this.panel29.Controls.Add(this.btnAddAccount);
            this.panel29.Location = new System.Drawing.Point(6, 6);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(314, 56);
            this.panel29.TabIndex = 4;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowAccount.Location = new System.Drawing.Point(237, 4);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(71, 49);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = false;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditAccount.Location = new System.Drawing.Point(160, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(71, 49);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAccount.Location = new System.Drawing.Point(83, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(71, 49);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddAccount.Location = new System.Drawing.Point(6, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(71, 49);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // Report
            // 
            this.Report.Controls.Add(this.reportViewer1);
            this.Report.Location = new System.Drawing.Point(4, 24);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(652, 434);
            this.Report.TabIndex = 5;
            this.Report.Text = "Báo cáo";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDoanhThu";
            reportDataSource1.Value = this.billBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SnackManager.rpDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(646, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 462);
            this.Controls.Add(this.tcBill);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoanhThu)).EndInit();
            this.tcBill.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tpCategory.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel11.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel20.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel29.ResumeLayout(false);
            this.Report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBill;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnShowCatagory;
        private System.Windows.Forms.Button btnEditCatagory;
        private System.Windows.Forms.Button btnDeleteCatagory;
        private System.Windows.Forms.Button btnAddCatagory;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txbNameCatagory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txbTableID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.Button btnLastBillPage;
        private System.Windows.Forms.Button btnFirstBillPage;
        private System.Windows.Forms.Button btnNextBillPage;
        private System.Windows.Forms.Button btnPreviousBillPage;
        private System.Windows.Forms.TextBox txbPageBill;
        private System.Windows.Forms.TabPage Report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsDoanhThu dsDoanhThu;
        private System.Windows.Forms.BindingSource billBindingSource;
        private dsDoanhThuTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel21;
    }
}