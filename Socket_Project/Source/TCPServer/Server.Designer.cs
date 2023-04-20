
namespace TCPServer
{
    partial class TCPServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPServer));
            this.CONTROLS = new System.Windows.Forms.GroupBox();
            this.Restart = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Automatic = new System.Windows.Forms.CheckBox();
            this.Port = new System.Windows.Forms.Label();
            this.Port_num = new System.Windows.Forms.TextBox();
            this.IPAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPaddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConsoleForm = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MENU = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ListClient = new System.Windows.Forms.RichTextBox();
            this.CONTROLS.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONTROLS
            // 
            this.CONTROLS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CONTROLS.Controls.Add(this.Restart);
            this.CONTROLS.Controls.Add(this.Stop);
            this.CONTROLS.Controls.Add(this.Run);
            this.CONTROLS.Controls.Add(this.Automatic);
            this.CONTROLS.Controls.Add(this.Port);
            this.CONTROLS.Controls.Add(this.Port_num);
            this.CONTROLS.Controls.Add(this.IPAddress);
            this.CONTROLS.Controls.Add(this.label1);
            this.CONTROLS.Controls.Add(this.IPaddr);
            this.CONTROLS.ForeColor = System.Drawing.Color.Black;
            this.CONTROLS.Location = new System.Drawing.Point(0, 27);
            this.CONTROLS.Name = "CONTROLS";
            this.CONTROLS.Size = new System.Drawing.Size(794, 118);
            this.CONTROLS.TabIndex = 7;
            this.CONTROLS.TabStop = false;
            this.CONTROLS.Text = "CONTROLS";
            // 
            // Restart
            // 
            this.Restart.Enabled = false;
            this.Restart.Location = new System.Drawing.Point(619, 37);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 11;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(522, 37);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 10;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(418, 37);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 9;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Automatic
            // 
            this.Automatic.AutoSize = true;
            this.Automatic.Location = new System.Drawing.Point(36, 66);
            this.Automatic.Name = "Automatic";
            this.Automatic.Size = new System.Drawing.Size(73, 17);
            this.Automatic.TabIndex = 8;
            this.Automatic.Text = "Automatic";
            this.Automatic.UseVisualStyleBackColor = true;
            this.Automatic.CheckedChanged += new System.EventHandler(this.Automatic_CheckedChanged);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(232, 21);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(30, 16);
            this.Port.TabIndex = 4;
            this.Port.Text = "Port";
            // 
            // Port_num
            // 
            this.Port_num.Location = new System.Drawing.Point(235, 40);
            this.Port_num.Name = "Port_num";
            this.Port_num.Size = new System.Drawing.Size(121, 20);
            this.Port_num.TabIndex = 3;
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSize = true;
            this.IPAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddress.Location = new System.Drawing.Point(35, 21);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(65, 16);
            this.IPAddress.TabIndex = 2;
            this.IPAddress.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // IPaddr
            // 
            this.IPaddr.Location = new System.Drawing.Point(36, 40);
            this.IPaddr.Name = "IPaddr";
            this.IPaddr.Size = new System.Drawing.Size(160, 20);
            this.IPaddr.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Client Status (connected)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConsoleForm
            // 
            this.ConsoleForm.BackColor = System.Drawing.Color.White;
            this.ConsoleForm.Cursor = System.Windows.Forms.Cursors.No;
            this.ConsoleForm.Location = new System.Drawing.Point(0, 151);
            this.ConsoleForm.Name = "ConsoleForm";
            this.ConsoleForm.ReadOnly = true;
            this.ConsoleForm.Size = new System.Drawing.Size(502, 352);
            this.ConsoleForm.TabIndex = 17;
            this.ConsoleForm.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MENU
            // 
            this.MENU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.About,
            this.toolStripSeparator2,
            this.Exit});
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(53, 20);
            this.MENU.Text = "MENU";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(107, 22);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ListClient
            // 
            this.ListClient.BackColor = System.Drawing.Color.White;
            this.ListClient.Cursor = System.Windows.Forms.Cursors.No;
            this.ListClient.Location = new System.Drawing.Point(508, 151);
            this.ListClient.Name = "ListClient";
            this.ListClient.ReadOnly = true;
            this.ListClient.Size = new System.Drawing.Size(286, 352);
            this.ListClient.TabIndex = 21;
            this.ListClient.Text = "";
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListClient);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ConsoleForm);
            this.Controls.Add(this.CONTROLS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TCPServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCPServer";
            this.CONTROLS.ResumeLayout(false);
            this.CONTROLS.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CONTROLS;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.CheckBox Automatic;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox Port_num;
        private System.Windows.Forms.Label IPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPaddr;
        private System.Windows.Forms.RichTextBox ConsoleForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MENU;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.RichTextBox ListClient;
        private System.Windows.Forms.Label label2;
    }
}

