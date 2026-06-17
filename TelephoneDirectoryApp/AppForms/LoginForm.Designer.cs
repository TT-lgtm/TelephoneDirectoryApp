namespace TelephoneDirectoryApp.AppForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dreamButtonExit = new ReaLTaiizor.Controls.DreamButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxUnvisible = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisible = new System.Windows.Forms.PictureBox();
            this.dreamButtonLogin = new ReaLTaiizor.Controls.DreamButton();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.hopeTextBoxPassword = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBoxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            this.labelAutorization = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelHeader);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelMain);
            this.splitContainer.Size = new System.Drawing.Size(531, 409);
            this.splitContainer.SplitterDistance = 101;
            this.splitContainer.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(171)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.dreamButtonExit);
            this.panelHeader.Controls.Add(this.labelDescription);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Controls.Add(this.pictureBoxIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(531, 101);
            this.panelHeader.TabIndex = 0;
            // 
            // dreamButtonExit
            // 
            this.dreamButtonExit.ColorA = System.Drawing.Color.Aqua;
            this.dreamButtonExit.ColorB = System.Drawing.Color.Aqua;
            this.dreamButtonExit.ColorC = System.Drawing.Color.DarkCyan;
            this.dreamButtonExit.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dreamButtonExit.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreamButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dreamButtonExit.Location = new System.Drawing.Point(433, 72);
            this.dreamButtonExit.Name = "dreamButtonExit";
            this.dreamButtonExit.Size = new System.Drawing.Size(95, 26);
            this.dreamButtonExit.TabIndex = 8;
            this.dreamButtonExit.Text = "Выход";
            this.dreamButtonExit.UseVisualStyleBackColor = true;
            this.dreamButtonExit.Click += new System.EventHandler(this.dreamButtonExit_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.labelDescription.Location = new System.Drawing.Point(80, 29);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(194, 16);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Телефонный справочник";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.labelName.Location = new System.Drawing.Point(80, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Yabblo.ko";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::TelephoneDirectoryApp.Properties.Resources.pngegg__1_;
            this.pictureBoxIcon.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(66, 80);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.panelMain.Controls.Add(this.pictureBoxUnvisible);
            this.panelMain.Controls.Add(this.pictureBoxVisible);
            this.panelMain.Controls.Add(this.dreamButtonLogin);
            this.panelMain.Controls.Add(this.labelPassword);
            this.panelMain.Controls.Add(this.labelEmail);
            this.panelMain.Controls.Add(this.hopeTextBoxPassword);
            this.panelMain.Controls.Add(this.hopeTextBoxEmail);
            this.panelMain.Controls.Add(this.labelAutorization);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(531, 304);
            this.panelMain.TabIndex = 0;
            // 
            // pictureBoxUnvisible
            // 
            this.pictureBoxUnvisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.pictureBoxUnvisible.Image = global::TelephoneDirectoryApp.Properties.Resources.PasswordUnvisible;
            this.pictureBoxUnvisible.Location = new System.Drawing.Point(381, 172);
            this.pictureBoxUnvisible.Name = "pictureBoxUnvisible";
            this.pictureBoxUnvisible.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUnvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnvisible.TabIndex = 9;
            this.pictureBoxUnvisible.TabStop = false;
            this.pictureBoxUnvisible.Click += new System.EventHandler(this.pictureBoxUnvisible_Click);
            // 
            // pictureBoxVisible
            // 
            this.pictureBoxVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.pictureBoxVisible.Image = global::TelephoneDirectoryApp.Properties.Resources.PasswordVisible;
            this.pictureBoxVisible.Location = new System.Drawing.Point(381, 172);
            this.pictureBoxVisible.Name = "pictureBoxVisible";
            this.pictureBoxVisible.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisible.TabIndex = 8;
            this.pictureBoxVisible.TabStop = false;
            this.pictureBoxVisible.Click += new System.EventHandler(this.pictureBoxVisible_Click);
            // 
            // dreamButtonLogin
            // 
            this.dreamButtonLogin.ColorA = System.Drawing.Color.Aqua;
            this.dreamButtonLogin.ColorB = System.Drawing.Color.Aqua;
            this.dreamButtonLogin.ColorC = System.Drawing.Color.DarkCyan;
            this.dreamButtonLogin.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dreamButtonLogin.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreamButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dreamButtonLogin.Location = new System.Drawing.Point(201, 232);
            this.dreamButtonLogin.Name = "dreamButtonLogin";
            this.dreamButtonLogin.Size = new System.Drawing.Size(120, 26);
            this.dreamButtonLogin.TabIndex = 7;
            this.dreamButtonLogin.Text = "Вход";
            this.dreamButtonLogin.UseVisualStyleBackColor = true;
            this.dreamButtonLogin.Click += new System.EventHandler(this.dreamButtonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelPassword.Location = new System.Drawing.Point(112, 145);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelEmail.Location = new System.Drawing.Point(112, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail";
            // 
            // hopeTextBoxPassword
            // 
            this.hopeTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeTextBoxPassword.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBoxPassword.BorderColorA = System.Drawing.Color.Transparent;
            this.hopeTextBoxPassword.BorderColorB = System.Drawing.Color.Transparent;
            this.hopeTextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxPassword.Hint = "";
            this.hopeTextBoxPassword.Location = new System.Drawing.Point(113, 168);
            this.hopeTextBoxPassword.MaxLength = 32767;
            this.hopeTextBoxPassword.Multiline = false;
            this.hopeTextBoxPassword.Name = "hopeTextBoxPassword";
            this.hopeTextBoxPassword.PasswordChar = '\0';
            this.hopeTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxPassword.SelectedText = "";
            this.hopeTextBoxPassword.SelectionLength = 0;
            this.hopeTextBoxPassword.SelectionStart = 0;
            this.hopeTextBoxPassword.Size = new System.Drawing.Size(302, 38);
            this.hopeTextBoxPassword.TabIndex = 4;
            this.hopeTextBoxPassword.TabStop = false;
            this.hopeTextBoxPassword.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxEmail
            // 
            this.hopeTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeTextBoxEmail.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBoxEmail.BorderColorA = System.Drawing.Color.Transparent;
            this.hopeTextBoxEmail.BorderColorB = System.Drawing.Color.Transparent;
            this.hopeTextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxEmail.Hint = "";
            this.hopeTextBoxEmail.Location = new System.Drawing.Point(113, 83);
            this.hopeTextBoxEmail.MaxLength = 32767;
            this.hopeTextBoxEmail.Multiline = false;
            this.hopeTextBoxEmail.Name = "hopeTextBoxEmail";
            this.hopeTextBoxEmail.PasswordChar = '\0';
            this.hopeTextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxEmail.SelectedText = "";
            this.hopeTextBoxEmail.SelectionLength = 0;
            this.hopeTextBoxEmail.SelectionStart = 0;
            this.hopeTextBoxEmail.Size = new System.Drawing.Size(302, 38);
            this.hopeTextBoxEmail.TabIndex = 3;
            this.hopeTextBoxEmail.TabStop = false;
            this.hopeTextBoxEmail.UseSystemPasswordChar = false;
            // 
            // labelAutorization
            // 
            this.labelAutorization.AutoSize = true;
            this.labelAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelAutorization.Location = new System.Drawing.Point(186, 13);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(152, 25);
            this.labelAutorization.TabIndex = 2;
            this.labelAutorization.Text = "Авторизация";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(531, 409);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelMain;
        private ReaLTaiizor.Controls.DreamButton dreamButtonExit;
        private ReaLTaiizor.Controls.DreamButton dreamButtonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxPassword;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxEmail;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.PictureBox pictureBoxVisible;
        private System.Windows.Forms.PictureBox pictureBoxUnvisible;
    }
}