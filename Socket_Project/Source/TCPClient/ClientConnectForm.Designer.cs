
namespace TCPClient
{
    partial class ClientConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientConnectForm));
            this.Control = new System.Windows.Forms.GroupBox();
            this.Disconnection = new System.Windows.Forms.Button();
            this.Automatic = new System.Windows.Forms.CheckBox();
            this.Connection = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.Portnum = new System.Windows.Forms.TextBox();
            this.IPaddress = new System.Windows.Forms.Label();
            this.IPaddr = new System.Windows.Forms.TextBox();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.Color.Transparent;
            this.Control.Controls.Add(this.Disconnection);
            this.Control.Controls.Add(this.Automatic);
            this.Control.Controls.Add(this.Connection);
            this.Control.Controls.Add(this.Port);
            this.Control.Controls.Add(this.Portnum);
            this.Control.Controls.Add(this.IPaddress);
            this.Control.Controls.Add(this.IPaddr);
            this.Control.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.Location = new System.Drawing.Point(12, 12);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(736, 101);
            this.Control.TabIndex = 7;
            this.Control.TabStop = false;
            this.Control.Text = "Control";
            // 
            // Disconnection
            // 
            this.Disconnection.BackColor = System.Drawing.Color.Transparent;
            this.Disconnection.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnection.Location = new System.Drawing.Point(605, 48);
            this.Disconnection.Name = "Disconnection";
            this.Disconnection.Size = new System.Drawing.Size(120, 22);
            this.Disconnection.TabIndex = 13;
            this.Disconnection.Text = "Disconnect";
            this.Disconnection.UseVisualStyleBackColor = false;
            this.Disconnection.Click += new System.EventHandler(this.Disconnection_Click);
            // 
            // Automatic
            // 
            this.Automatic.AutoSize = true;
            this.Automatic.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Automatic.Location = new System.Drawing.Point(29, 76);
            this.Automatic.Name = "Automatic";
            this.Automatic.Size = new System.Drawing.Size(80, 20);
            this.Automatic.TabIndex = 12;
            this.Automatic.Text = "Automatic";
            this.Automatic.UseVisualStyleBackColor = true;
            this.Automatic.CheckedChanged += new System.EventHandler(this.Automatic_CheckedChanged);
            // 
            // Connection
            // 
            this.Connection.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.Location = new System.Drawing.Point(446, 48);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(120, 22);
            this.Connection.TabIndex = 10;
            this.Connection.Text = "Connect";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(251, 29);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(30, 16);
            this.Port.TabIndex = 9;
            this.Port.Text = "Port";
            this.Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Portnum
            // 
            this.Portnum.Location = new System.Drawing.Point(254, 48);
            this.Portnum.Name = "Portnum";
            this.Portnum.Size = new System.Drawing.Size(125, 22);
            this.Portnum.TabIndex = 8;
            // 
            // IPaddress
            // 
            this.IPaddress.AutoSize = true;
            this.IPaddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPaddress.Location = new System.Drawing.Point(26, 29);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(65, 16);
            this.IPaddress.TabIndex = 7;
            this.IPaddress.Text = "IP Address";
            // 
            // IPaddr
            // 
            this.IPaddr.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPaddr.Location = new System.Drawing.Point(29, 48);
            this.IPaddr.Name = "IPaddr";
            this.IPaddr.Size = new System.Drawing.Size(155, 22);
            this.IPaddr.TabIndex = 6;
            // 
            // ClientConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 135);
            this.Controls.Add(this.Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCPClient";
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Button Disconnection;
        private System.Windows.Forms.CheckBox Automatic;
        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox Portnum;
        private System.Windows.Forms.Label IPaddress;
        private System.Windows.Forms.TextBox IPaddr;
    }
}

