namespace InventoryManagementSystemV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ordersButton = new InventoryManagementSystemV2.customerButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersButton = new InventoryManagementSystemV2.customerButton();
            this.categoriesButton = new InventoryManagementSystemV2.customerButton();
            this.productButton = new InventoryManagementSystemV2.customerButton();
            this.customerButton = new InventoryManagementSystemV2.customerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ordersButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usersButton);
            this.panel1.Controls.Add(this.categoriesButton);
            this.panel1.Controls.Add(this.productButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "MyManage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Orders";
            // 
            // ordersButton
            // 
            this.ordersButton.Image = ((System.Drawing.Image)(resources.GetObject("ordersButton.Image")));
            this.ordersButton.imageHover = ((System.Drawing.Image)(resources.GetObject("ordersButton.imageHover")));
            this.ordersButton.imageNormal = ((System.Drawing.Image)(resources.GetObject("ordersButton.imageNormal")));
            this.ordersButton.Location = new System.Drawing.Point(606, 23);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(47, 42);
            this.ordersButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ordersButton.TabIndex = 4;
            this.ordersButton.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product";
            // 
            // usersButton
            // 
            this.usersButton.Image = ((System.Drawing.Image)(resources.GetObject("usersButton.Image")));
            this.usersButton.imageHover = ((System.Drawing.Image)(resources.GetObject("usersButton.imageHover")));
            this.usersButton.imageNormal = ((System.Drawing.Image)(resources.GetObject("usersButton.imageNormal")));
            this.usersButton.Location = new System.Drawing.Point(527, 23);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(47, 42);
            this.usersButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usersButton.TabIndex = 3;
            this.usersButton.TabStop = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Image = global::InventoryManagementSystemV2.Properties.Resources.List;
            this.categoriesButton.imageHover = ((System.Drawing.Image)(resources.GetObject("categoriesButton.imageHover")));
            this.categoriesButton.imageNormal = ((System.Drawing.Image)(resources.GetObject("categoriesButton.imageNormal")));
            this.categoriesButton.Location = new System.Drawing.Point(444, 23);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(47, 42);
            this.categoriesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoriesButton.TabIndex = 3;
            this.categoriesButton.TabStop = false;
            // 
            // productButton
            // 
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.imageHover = ((System.Drawing.Image)(resources.GetObject("productButton.imageHover")));
            this.productButton.imageNormal = ((System.Drawing.Image)(resources.GetObject("productButton.imageNormal")));
            this.productButton.Location = new System.Drawing.Point(288, 23);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(47, 42);
            this.productButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productButton.TabIndex = 1;
            this.productButton.TabStop = false;
            // 
            // customerButton
            // 
            this.customerButton.Image = global::InventoryManagementSystemV2.Properties.Resources.userIcon;
            this.customerButton.imageHover = global::InventoryManagementSystemV2.Properties.Resources.userIcon2;
            this.customerButton.imageNormal = global::InventoryManagementSystemV2.Properties.Resources.userIcon;
            this.customerButton.Location = new System.Drawing.Point(366, 23);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(47, 42);
            this.customerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton.TabIndex = 3;
            this.customerButton.TabStop = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inventory Management System";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 84);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 363);
            this.mainPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private customerButton productButton;
        private customerButton usersButton;
        private customerButton categoriesButton;
        private customerButton customerButton;
        private System.Windows.Forms.Label label6;
        private customerButton ordersButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}