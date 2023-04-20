
namespace TCPClient
{
    partial class SearchForm
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
            this.Title = new System.Windows.Forms.Label();
            this.Logout_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.DataTable = new System.Windows.Forms.ListView();
            this.TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrandCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SellCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(26, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 21);
            this.Title.TabIndex = 2;
            this.Title.Text = "Hello ";
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.Color.Transparent;
            this.Logout_button.Location = new System.Drawing.Point(1043, 39);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(98, 23);
            this.Logout_button.TabIndex = 3;
            this.Logout_button.Text = "Log Out";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Reset_button);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BrandBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TypeBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CompanyBox);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TCPClient.Properties.Resources.Flat_restart_icon_svg;
            this.pictureBox3.Location = new System.Drawing.Point(177, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCPClient.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(36, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Reset_button
            // 
            this.Reset_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.ForeColor = System.Drawing.Color.Transparent;
            this.Reset_button.Location = new System.Drawing.Point(153, 113);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(98, 23);
            this.Reset_button.TabIndex = 9;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = false;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.Transparent;
            this.Search_button.Location = new System.Drawing.Point(3, 113);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 23);
            this.Search_button.TabIndex = 8;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(886, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Area";
            // 
            // BrandBox
            // 
            this.BrandBox.BackColor = System.Drawing.Color.White;
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Items.AddRange(new object[] {
            "Default"});
            this.BrandBox.Location = new System.Drawing.Point(890, 50);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(164, 23);
            this.BrandBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(598, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // TypeBox
            // 
            this.TypeBox.BackColor = System.Drawing.Color.White;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Default"});
            this.TypeBox.Location = new System.Drawing.Point(602, 50);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(164, 23);
            this.TypeBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(326, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // CompanyBox
            // 
            this.CompanyBox.BackColor = System.Drawing.Color.White;
            this.CompanyBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Items.AddRange(new object[] {
            "Default"});
            this.CompanyBox.Location = new System.Drawing.Point(330, 50);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(164, 23);
            this.CompanyBox.TabIndex = 1;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(6, 47);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(245, 23);
            this.DateBox.TabIndex = 0;
            // 
            // DataTable
            // 
            this.DataTable.BackColor = System.Drawing.Color.White;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeCol,
            this.CompanyCol,
            this.BrandCol,
            this.BuyCol,
            this.SellCol,
            this.DateCol});
            this.DataTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataTable.HideSelection = false;
            this.DataTable.Location = new System.Drawing.Point(9, 269);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(1132, 524);
            this.DataTable.TabIndex = 5;
            this.DataTable.UseCompatibleStateImageBehavior = false;
            this.DataTable.View = System.Windows.Forms.View.Details;
            // 
            // TypeCol
            // 
            this.TypeCol.Text = "Type";
            this.TypeCol.Width = 238;
            // 
            // CompanyCol
            // 
            this.CompanyCol.Text = "Brand";
            this.CompanyCol.Width = 168;
            // 
            // BrandCol
            // 
            this.BrandCol.Text = "Area";
            this.BrandCol.Width = 179;
            // 
            // BuyCol
            // 
            this.BuyCol.Text = "Buy";
            this.BuyCol.Width = 194;
            // 
            // SellCol
            // 
            this.SellCol.Text = "Sell";
            this.SellCol.Width = 174;
            // 
            // DateCol
            // 
            this.DateCol.Text = "Date";
            this.DateCol.Width = 290;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TCPClient.Properties.Resources.log_out;
            this.pictureBox2.Location = new System.Drawing.Point(1072, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1145, 790);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BrandBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CompanyBox;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.ListView DataTable;
        private System.Windows.Forms.ColumnHeader CompanyCol;
        private System.Windows.Forms.ColumnHeader BrandCol;
        private System.Windows.Forms.ColumnHeader BuyCol;
        private System.Windows.Forms.ColumnHeader SellCol;
        private System.Windows.Forms.ColumnHeader DateCol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader TypeCol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}