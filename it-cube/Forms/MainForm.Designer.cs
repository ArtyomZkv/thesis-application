namespace it_cube_application
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.pb_userLogo = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_helpOpen = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_billWork = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_studentsWork = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.labelUser);
            this.panel3.Controls.Add(this.pb_userLogo);
            this.panel3.Controls.Add(this.btn_home);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_min);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(254, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 169);
            this.panel3.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelUser.Location = new System.Drawing.Point(88, 134);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(134, 22);
            this.labelUser.TabIndex = 25;
            this.labelUser.Text = "Пользователь";
            // 
            // pb_userLogo
            // 
            this.pb_userLogo.Image = global::it_cube_application.Properties.Resources.it_cubelogo;
            this.pb_userLogo.Location = new System.Drawing.Point(16, 106);
            this.pb_userLogo.Name = "pb_userLogo";
            this.pb_userLogo.Size = new System.Drawing.Size(61, 50);
            this.pb_userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userLogo.TabIndex = 24;
            this.pb_userLogo.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_home.Image = global::it_cube_application.Properties.Resources.home1;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(16, 50);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(323, 49);
            this.btn_home.TabIndex = 23;
            this.btn_home.Text = "Домашняя страница";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::it_cube_application.Properties.Resources.closeiconminimize;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(512, 4);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(61, 39);
            this.btn_close.TabIndex = 22;
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
            this.btn_min.Location = new System.Drawing.Point(463, 4);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(61, 39);
            this.btn_min.TabIndex = 21;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(561, 39);
            this.panel4.TabIndex = 33;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_helpOpen);
            this.groupBox1.Controls.Add(this.btn_logout);
            this.groupBox1.Location = new System.Drawing.Point(-5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 127);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btn_helpOpen
            // 
            this.btn_helpOpen.BackColor = System.Drawing.Color.Transparent;
            this.btn_helpOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_helpOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_helpOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_helpOpen.FlatAppearance.BorderSize = 0;
            this.btn_helpOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_helpOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_helpOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_helpOpen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_helpOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_helpOpen.Image = global::it_cube_application.Properties.Resources.question_blue12;
            this.btn_helpOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_helpOpen.Location = new System.Drawing.Point(504, 67);
            this.btn_helpOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_helpOpen.Name = "btn_helpOpen";
            this.btn_helpOpen.Size = new System.Drawing.Size(61, 47);
            this.btn_helpOpen.TabIndex = 23;
            this.btn_helpOpen.UseVisualStyleBackColor = false;
            this.btn_helpOpen.Click += new System.EventHandler(this.btn_helpOpen_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = global::it_cube_application.Properties.Resources.logout;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
            this.btn_logout.Location = new System.Drawing.Point(235, 95);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(27, 25);
            this.btn_logout.TabIndex = 26;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 169);
            this.panel1.TabIndex = 5;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(45, 18);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(155, 137);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 39);
            this.panel5.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btn_billWork);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_studentsWork);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 298);
            this.panel2.TabIndex = 3;
            // 
            // btn_billWork
            // 
            this.btn_billWork.BackColor = System.Drawing.Color.Transparent;
            this.btn_billWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_billWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_billWork.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_billWork.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_billWork.FlatAppearance.BorderSize = 0;
            this.btn_billWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_billWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_billWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billWork.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btn_billWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_billWork.Image = global::it_cube_application.Properties.Resources.blue_bill5;
            this.btn_billWork.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_billWork.Location = new System.Drawing.Point(57, 4);
            this.btn_billWork.Margin = new System.Windows.Forms.Padding(4);
            this.btn_billWork.Name = "btn_billWork";
            this.btn_billWork.Size = new System.Drawing.Size(339, 290);
            this.btn_billWork.TabIndex = 31;
            this.btn_billWork.Text = "Работа с ведомостью";
            this.btn_billWork.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_billWork.UseVisualStyleBackColor = false;
            this.btn_billWork.Click += new System.EventHandler(this.btn_billWork_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(104, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Работа с ведомостью";
            // 
            // btn_studentsWork
            // 
            this.btn_studentsWork.BackColor = System.Drawing.Color.Transparent;
            this.btn_studentsWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_studentsWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_studentsWork.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_studentsWork.FlatAppearance.BorderSize = 0;
            this.btn_studentsWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_studentsWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_studentsWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentsWork.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btn_studentsWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_studentsWork.Image = global::it_cube_application.Properties.Resources.abit4;
            this.btn_studentsWork.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_studentsWork.Location = new System.Drawing.Point(450, 4);
            this.btn_studentsWork.Margin = new System.Windows.Forms.Padding(4);
            this.btn_studentsWork.Name = "btn_studentsWork";
            this.btn_studentsWork.Size = new System.Drawing.Size(315, 294);
            this.btn_studentsWork.TabIndex = 32;
            this.btn_studentsWork.TabStop = false;
            this.btn_studentsWork.Text = "Работа с обучаюищимися";
            this.btn_studentsWork.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_studentsWork.UseVisualStyleBackColor = false;
            this.btn_studentsWork.Click += new System.EventHandler(this.btn_studentsWork_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(818, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pb_userLogo;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_billWork;
        private System.Windows.Forms.Button btn_studentsWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_helpOpen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

