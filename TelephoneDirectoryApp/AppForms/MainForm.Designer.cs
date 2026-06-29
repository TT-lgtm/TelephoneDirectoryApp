namespace TelephoneDirectoryApp.AppForms
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dreamButtonRefresh = new ReaLTaiizor.Controls.DreamButton();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            this.dreamButtonExit = new ReaLTaiizor.Controls.DreamButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.hopeTextBoxSearch = new ReaLTaiizor.Controls.HopeTextBox();
            this.pictureBoxUnvisible = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
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
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanelMain);
            this.splitContainer.Size = new System.Drawing.Size(1429, 681);
            this.splitContainer.SplitterDistance = 123;
            this.splitContainer.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(171)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.pictureBoxUnvisible);
            this.panelHeader.Controls.Add(this.hopeTextBoxSearch);
            this.panelHeader.Controls.Add(this.dreamButtonRefresh);
            this.panelHeader.Controls.Add(this.GreetingLabel);
            this.panelHeader.Controls.Add(this.dreamButton1);
            this.panelHeader.Controls.Add(this.dreamButtonExit);
            this.panelHeader.Controls.Add(this.labelDescription);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Controls.Add(this.pictureBoxIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1429, 123);
            this.panelHeader.TabIndex = 0;
            // 
            // dreamButtonRefresh
            // 
            this.dreamButtonRefresh.ColorA = System.Drawing.Color.Aqua;
            this.dreamButtonRefresh.ColorB = System.Drawing.Color.Aqua;
            this.dreamButtonRefresh.ColorC = System.Drawing.Color.DarkCyan;
            this.dreamButtonRefresh.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dreamButtonRefresh.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreamButtonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dreamButtonRefresh.Location = new System.Drawing.Point(177, 92);
            this.dreamButtonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.dreamButtonRefresh.Name = "dreamButtonRefresh";
            this.dreamButtonRefresh.Size = new System.Drawing.Size(112, 26);
            this.dreamButtonRefresh.TabIndex = 11;
            this.dreamButtonRefresh.Text = "Обновить";
            this.dreamButtonRefresh.UseVisualStyleBackColor = true;
            this.dreamButtonRefresh.Click += new System.EventHandler(this.dreamButtonRefresh_Click);
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.GreetingLabel.Location = new System.Drawing.Point(80, 72);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(147, 16);
            this.GreetingLabel.TabIndex = 10;
            this.GreetingLabel.Text = "Добрый день, User!";
            // 
            // dreamButton1
            // 
            this.dreamButton1.ColorA = System.Drawing.Color.Aqua;
            this.dreamButton1.ColorB = System.Drawing.Color.Aqua;
            this.dreamButton1.ColorC = System.Drawing.Color.DarkCyan;
            this.dreamButton1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dreamButton1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreamButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dreamButton1.Location = new System.Drawing.Point(9, 92);
            this.dreamButton1.Margin = new System.Windows.Forms.Padding(0);
            this.dreamButton1.Name = "dreamButton1";
            this.dreamButton1.Size = new System.Drawing.Size(154, 26);
            this.dreamButton1.TabIndex = 9;
            this.dreamButton1.Text = "Моя карточка";
            this.dreamButton1.UseVisualStyleBackColor = true;
            this.dreamButton1.Click += new System.EventHandler(this.dreamButton1_Click);
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
            this.dreamButtonExit.Location = new System.Drawing.Point(302, 92);
            this.dreamButtonExit.Margin = new System.Windows.Forms.Padding(0);
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
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1429, 554);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // hopeTextBoxSearch
            // 
            this.hopeTextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeTextBoxSearch.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBoxSearch.BorderColorA = System.Drawing.Color.Transparent;
            this.hopeTextBoxSearch.BorderColorB = System.Drawing.Color.Transparent;
            this.hopeTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeTextBoxSearch.Hint = "";
            this.hopeTextBoxSearch.Location = new System.Drawing.Point(969, 80);
            this.hopeTextBoxSearch.MaxLength = 32767;
            this.hopeTextBoxSearch.Multiline = true;
            this.hopeTextBoxSearch.Name = "hopeTextBoxSearch";
            this.hopeTextBoxSearch.PasswordChar = '\0';
            this.hopeTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxSearch.SelectedText = "";
            this.hopeTextBoxSearch.SelectionLength = 0;
            this.hopeTextBoxSearch.SelectionStart = 0;
            this.hopeTextBoxSearch.Size = new System.Drawing.Size(453, 35);
            this.hopeTextBoxSearch.TabIndex = 35;
            this.hopeTextBoxSearch.TabStop = false;
            this.hopeTextBoxSearch.UseSystemPasswordChar = false;
            this.hopeTextBoxSearch.TextChanged += new System.EventHandler(this.hopeTextBoxSearch_TextChanged);
            // 
            // pictureBoxUnvisible
            // 
            this.pictureBoxUnvisible.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnvisible.Image = global::TelephoneDirectoryApp.Properties.Resources.searchIcon1;
            this.pictureBoxUnvisible.Location = new System.Drawing.Point(928, 80);
            this.pictureBoxUnvisible.Name = "pictureBoxUnvisible";
            this.pictureBoxUnvisible.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxUnvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnvisible.TabIndex = 36;
            this.pictureBoxUnvisible.TabStop = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1429, 681);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private ReaLTaiizor.Controls.DreamButton dreamButtonExit;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private ReaLTaiizor.Controls.DreamButton dreamButtonRefresh;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxUnvisible;
    }
}