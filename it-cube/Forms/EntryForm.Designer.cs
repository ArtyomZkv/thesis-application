
namespace it_cube_application.Forms
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbx_login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_refreshLogin = new System.Windows.Forms.Button();
            this.btn_refreshPassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 251);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 64;
            // 
            // txbx_login
            // 
            this.txbx_login.BackColor = System.Drawing.Color.White;
            this.txbx_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbx_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbx_login.Location = new System.Drawing.Point(75, 210);
            this.txbx_login.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_login.Name = "txbx_login";
            this.txbx_login.Size = new System.Drawing.Size(193, 30);
            this.txbx_login.TabIndex = 62;
            this.txbx_login.Text = "Введите логин";
            this.txbx_login.Click += new System.EventHandler(this.txbx_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(13, 328);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 1);
            this.panel2.TabIndex = 67;
            // 
            // txbx_password
            // 
            this.txbx_password.BackColor = System.Drawing.Color.White;
            this.txbx_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbx_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbx_password.Location = new System.Drawing.Point(75, 294);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(193, 30);
            this.txbx_password.TabIndex = 65;
            this.txbx_password.Text = "Введите пароль";
            this.txbx_password.Click += new System.EventHandler(this.txbx_password_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.Location = new System.Drawing.Point(97, 365);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(114, 37);
            this.btn_login.TabIndex = 71;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_login_KeyDown);
            // 
            // btn_refreshLogin
            // 
            this.btn_refreshLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_refreshLogin.BackgroundImage = global::it_cube_application.Properties.Resources.update_blue;
            this.btn_refreshLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refreshLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refreshLogin.FlatAppearance.BorderSize = 0;
            this.btn_refreshLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_refreshLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_refreshLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btn_refreshLogin.Location = new System.Drawing.Point(284, 212);
            this.btn_refreshLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refreshLogin.Name = "btn_refreshLogin";
            this.btn_refreshLogin.Size = new System.Drawing.Size(40, 31);
            this.btn_refreshLogin.TabIndex = 68;
            this.btn_refreshLogin.Text = " ";
            this.btn_refreshLogin.UseVisualStyleBackColor = false;
            this.btn_refreshLogin.Click += new System.EventHandler(this.btn_refreshLogin_Click);
            // 
            // btn_refreshPassword
            // 
            this.btn_refreshPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_refreshPassword.BackgroundImage = global::it_cube_application.Properties.Resources.update_blue;
            this.btn_refreshPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refreshPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refreshPassword.FlatAppearance.BorderSize = 0;
            this.btn_refreshPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_refreshPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_refreshPassword.ForeColor = System.Drawing.Color.Transparent;
            this.btn_refreshPassword.Location = new System.Drawing.Point(284, 300);
            this.btn_refreshPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refreshPassword.Name = "btn_refreshPassword";
            this.btn_refreshPassword.Size = new System.Drawing.Size(40, 31);
            this.btn_refreshPassword.TabIndex = 68;
            this.btn_refreshPassword.Text = " ";
            this.btn_refreshPassword.UseVisualStyleBackColor = false;
            this.btn_refreshPassword.Click += new System.EventHandler(this.btn_refreshPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::it_cube_application.Properties.Resources.password_blue;
            this.pictureBox1.Location = new System.Drawing.Point(14, 271);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // pb_user
            // 
            this.pb_user.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_user.Image = global::it_cube_application.Properties.Resources.login_blue1;
            this.pb_user.Location = new System.Drawing.Point(14, 187);
            this.pb_user.Margin = new System.Windows.Forms.Padding(4);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(53, 49);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_user.TabIndex = 63;
            this.pb_user.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(97, 53);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(125, 118);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 61;
            this.pb_logo.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::it_cube_application.Properties.Resources.closeiconminimize;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(267, 6);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(55, 39);
            this.btn_close.TabIndex = 60;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BackgroundImage = global::it_cube_application.Properties.Resources.minimize2;
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_min.ForeColor = System.Drawing.Color.Transparent;
            this.btn_min.Location = new System.Drawing.Point(220, 6);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(55, 39);
            this.btn_min.TabIndex = 59;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(13, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 1);
            this.panel3.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_min);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 53);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 44);
            this.panel4.TabIndex = 61;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // EntryForm
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(326, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_refreshLogin);
            this.Controls.Add(this.btn_refreshPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.txbx_login);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.btn_login);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.TextBox txbx_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Button btn_refreshLogin;
        private System.Windows.Forms.Button btn_refreshPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
    }
}