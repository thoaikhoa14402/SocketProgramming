
namespace TCPClient
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(120, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "USER LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font(".VnArial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(99, 185);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 29);
            this.txtUsername.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(121, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(99, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 29);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword.ForeColor = System.Drawing.Color.Black;
            this.ShowPassword.Location = new System.Drawing.Point(99, 281);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(109, 19);
            this.ShowPassword.TabIndex = 21;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Login_button.Location = new System.Drawing.Point(98, 315);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(217, 29);
            this.Login_button.TabIndex = 22;
            this.Login_button.Text = "LOGIN";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(133, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Not yet a member? Sign up";
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.DimGray;
            this.Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.ForeColor = System.Drawing.Color.Transparent;
            this.Register_button.Location = new System.Drawing.Point(98, 375);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(216, 29);
            this.Register_button.TabIndex = 26;
            this.Register_button.Text = "REGISTER";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.Crimson;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.ForeColor = System.Drawing.Color.Transparent;
            this.Clear_button.Location = new System.Drawing.Point(98, 421);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(216, 28);
            this.Clear_button.TabIndex = 27;
            this.Clear_button.Text = "CLEAR";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TCPClient.Properties.Resources._698906;
            this.pictureBox3.Location = new System.Drawing.Point(94, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TCPClient.Properties.Resources.user2;
            this.pictureBox2.Location = new System.Drawing.Point(94, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCPClient.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(125, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 461);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserLoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}