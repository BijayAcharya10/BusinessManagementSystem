namespace BusinessManagement
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorPaymentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerPaymentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascasdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeePaymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venndorPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerPaymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.arrangementToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.sellsToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.vendorPaymentToolStripMenuItem,
            this.customerPaymentToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.UserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // sellsToolStripMenuItem
            // 
            this.sellsToolStripMenuItem.Name = "sellsToolStripMenuItem";
            this.sellsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sellsToolStripMenuItem.Text = "Sells";
            this.sellsToolStripMenuItem.Click += new System.EventHandler(this.SellsToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.PurchaseToolStripMenuItem_Click);
            // 
            // vendorPaymentToolStripMenuItem
            // 
            this.vendorPaymentToolStripMenuItem.Name = "vendorPaymentToolStripMenuItem";
            this.vendorPaymentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.vendorPaymentToolStripMenuItem.Text = "VendorPayment";
            this.vendorPaymentToolStripMenuItem.Click += new System.EventHandler(this.VendorPaymentToolStripMenuItem_Click);
            // 
            // customerPaymentToolStripMenuItem
            // 
            this.customerPaymentToolStripMenuItem.Name = "customerPaymentToolStripMenuItem";
            this.customerPaymentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.customerPaymentToolStripMenuItem.Text = "Customer Payment";
            this.customerPaymentToolStripMenuItem.Click += new System.EventHandler(this.CustomerPaymentToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCategoryToolStripMenuItem,
            this.manageProductToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manageUserToolStripMenuItem,
            this.databaseBackupToolStripMenuItem,
            this.databaseRestoreToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.manageUnitToolStripMenuItem,
            this.manageVendorToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            // 
            // manageCategoryToolStripMenuItem
            // 
            this.manageCategoryToolStripMenuItem.Name = "manageCategoryToolStripMenuItem";
            this.manageCategoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.manageCategoryToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageCategoryToolStripMenuItem.Text = "Manage Category";
            this.manageCategoryToolStripMenuItem.Click += new System.EventHandler(this.ManageCategoryToolStripMenuItem_Click);
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.ManageProductToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.ManageUserToolStripMenuItem_Click);
            // 
            // databaseBackupToolStripMenuItem
            // 
            this.databaseBackupToolStripMenuItem.Name = "databaseBackupToolStripMenuItem";
            this.databaseBackupToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.databaseBackupToolStripMenuItem.Text = "Database Backup";
            this.databaseBackupToolStripMenuItem.Click += new System.EventHandler(this.DatabaseBackupToolStripMenuItem_Click);
            // 
            // databaseRestoreToolStripMenuItem
            // 
            this.databaseRestoreToolStripMenuItem.Name = "databaseRestoreToolStripMenuItem";
            this.databaseRestoreToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.databaseRestoreToolStripMenuItem.Text = "Database Restore";
            this.databaseRestoreToolStripMenuItem.Click += new System.EventHandler(this.DatabaseRestoreToolStripMenuItem_Click);
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageCustomerToolStripMenuItem.Text = "Manage Customer";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.ManageCustomerToolStripMenuItem_Click);
            // 
            // manageUnitToolStripMenuItem
            // 
            this.manageUnitToolStripMenuItem.Name = "manageUnitToolStripMenuItem";
            this.manageUnitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageUnitToolStripMenuItem.Text = "Manage Unit";
            this.manageUnitToolStripMenuItem.Click += new System.EventHandler(this.ManageUnitToolStripMenuItem_Click);
            // 
            // manageVendorToolStripMenuItem
            // 
            this.manageVendorToolStripMenuItem.Name = "manageVendorToolStripMenuItem";
            this.manageVendorToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageVendorToolStripMenuItem.Text = "Manage Vendor";
            this.manageVendorToolStripMenuItem.Click += new System.EventHandler(this.ManageVendorToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.ManageEmployeeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem,
            this.purchaseReportToolStripMenuItem,
            this.salaryReportToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.vendorPaymentReportToolStripMenuItem,
            this.customerPaymentReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.SalesReportToolStripMenuItem_Click);
            // 
            // purchaseReportToolStripMenuItem
            // 
            this.purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            this.purchaseReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.purchaseReportToolStripMenuItem.Text = "Purchase Report";
            this.purchaseReportToolStripMenuItem.Click += new System.EventHandler(this.PurchaseReportToolStripMenuItem_Click);
            // 
            // salaryReportToolStripMenuItem
            // 
            this.salaryReportToolStripMenuItem.Name = "salaryReportToolStripMenuItem";
            this.salaryReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.salaryReportToolStripMenuItem.Text = "Salary Report";
            this.salaryReportToolStripMenuItem.Click += new System.EventHandler(this.SalaryReportToolStripMenuItem_Click);
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.StockReportToolStripMenuItem_Click);
            // 
            // vendorPaymentReportToolStripMenuItem
            // 
            this.vendorPaymentReportToolStripMenuItem.Name = "vendorPaymentReportToolStripMenuItem";
            this.vendorPaymentReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.vendorPaymentReportToolStripMenuItem.Text = "Vendor Payment Report";
            this.vendorPaymentReportToolStripMenuItem.Click += new System.EventHandler(this.VendorPaymentReportToolStripMenuItem_Click);
            // 
            // customerPaymentReportToolStripMenuItem
            // 
            this.customerPaymentReportToolStripMenuItem.Name = "customerPaymentReportToolStripMenuItem";
            this.customerPaymentReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.customerPaymentReportToolStripMenuItem.Text = "Customer Payment Report";
            this.customerPaymentReportToolStripMenuItem.Click += new System.EventHandler(this.CustomerPaymentReportToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.NotepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click);
            // 
            // arrangementToolStripMenuItem
            // 
            this.arrangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascasdeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticleToolStripMenuItem});
            this.arrangementToolStripMenuItem.Name = "arrangementToolStripMenuItem";
            this.arrangementToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.arrangementToolStripMenuItem.Text = "Arrangement";
            // 
            // cascasdeToolStripMenuItem
            // 
            this.cascasdeToolStripMenuItem.Name = "cascasdeToolStripMenuItem";
            this.cascasdeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cascasdeToolStripMenuItem.Text = "Cascasde";
            this.cascasdeToolStripMenuItem.Click += new System.EventHandler(this.CascasdeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticleToolStripMenuItem
            // 
            this.tileVerticleToolStripMenuItem.Name = "tileVerticleToolStripMenuItem";
            this.tileVerticleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileVerticleToolStripMenuItem.Text = "Tile Verticle";
            this.tileVerticleToolStripMenuItem.Click += new System.EventHandler(this.TileVerticleToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeePaymentToolStripMenuItem1,
            this.venndorPaymentToolStripMenuItem,
            this.customerPaymentToolStripMenuItem1});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // employeePaymentToolStripMenuItem1
            // 
            this.employeePaymentToolStripMenuItem1.Name = "employeePaymentToolStripMenuItem1";
            this.employeePaymentToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.employeePaymentToolStripMenuItem1.Text = "Employee Payment";
            this.employeePaymentToolStripMenuItem1.Click += new System.EventHandler(this.EmployeePaymentToolStripMenuItem1_Click);
            // 
            // venndorPaymentToolStripMenuItem
            // 
            this.venndorPaymentToolStripMenuItem.Name = "venndorPaymentToolStripMenuItem";
            this.venndorPaymentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.venndorPaymentToolStripMenuItem.Text = "Venndor Payment";
            this.venndorPaymentToolStripMenuItem.Click += new System.EventHandler(this.VenndorPaymentToolStripMenuItem_Click);
            // 
            // customerPaymentToolStripMenuItem1
            // 
            this.customerPaymentToolStripMenuItem1.Name = "customerPaymentToolStripMenuItem1";
            this.customerPaymentToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.customerPaymentToolStripMenuItem1.Text = "Customer Payment";
            this.customerPaymentToolStripMenuItem1.Click += new System.EventHandler(this.CustomerPaymentToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsername,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.Maroon;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(157, 21);
            this.lblUsername.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.Green;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(157, 21);
            this.lblTime.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(564, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 400);
            this.dataGridView1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BusinessManagement.Properties.Resources.gettyimages_624878906_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascasdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsername;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeePaymentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venndorPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerPaymentToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem salaryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem vendorPaymentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerPaymentReportToolStripMenuItem;
    }
}