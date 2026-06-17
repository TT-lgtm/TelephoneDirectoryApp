namespace TelephoneDirectoryApp.AppForms
{
    partial class MyCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCardForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dreamButtonExit = new ReaLTaiizor.Controls.DreamButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.dreamButtonChange = new ReaLTaiizor.Controls.DreamButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPersonalNumber = new System.Windows.Forms.Label();
            this.labelWorkNumber = new System.Windows.Forms.Label();
            this.labelOffice = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.dreamButtonSave = new ReaLTaiizor.Controls.DreamButton();
            this.hopeTextBoxWorkNumber = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBoxPersonalNumber = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeTextBoxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeComboBoxPosition = new ReaLTaiizor.Controls.HopeComboBox();
            this.telephone_directory_DBDataSet = new TelephoneDirectoryApp.telephone_directory_DBDataSet();
            this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscribersTableAdapter = new TelephoneDirectoryApp.telephone_directory_DBDataSetTableAdapters.SubscribersTableAdapter();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionsTableAdapter = new TelephoneDirectoryApp.telephone_directory_DBDataSetTableAdapters.PositionsTableAdapter();
            this.hopeComboBoxDepartment = new ReaLTaiizor.Controls.HopeComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new TelephoneDirectoryApp.telephone_directory_DBDataSetTableAdapters.DepartmentsTableAdapter();
            this.hopeComboBoxBuilding = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeComboBoxOffice = new ReaLTaiizor.Controls.HopeComboBox();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new TelephoneDirectoryApp.telephone_directory_DBDataSetTableAdapters.BuildingsTableAdapter();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officesTableAdapter = new TelephoneDirectoryApp.telephone_directory_DBDataSetTableAdapters.OfficesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_directory_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
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
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(467, 635);
            this.splitContainer.SplitterDistance = 97;
            this.splitContainer.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(171)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.dreamButtonSave);
            this.panelHeader.Controls.Add(this.dreamButtonChange);
            this.panelHeader.Controls.Add(this.dreamButtonExit);
            this.panelHeader.Controls.Add(this.labelDescription);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Controls.Add(this.pictureBoxIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(467, 97);
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
            this.dreamButtonExit.Location = new System.Drawing.Point(366, 64);
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
            // dreamButtonChange
            // 
            this.dreamButtonChange.ColorA = System.Drawing.Color.Aqua;
            this.dreamButtonChange.ColorB = System.Drawing.Color.Aqua;
            this.dreamButtonChange.ColorC = System.Drawing.Color.DarkCyan;
            this.dreamButtonChange.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dreamButtonChange.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButtonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButtonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreamButtonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dreamButtonChange.Location = new System.Drawing.Point(247, 64);
            this.dreamButtonChange.Margin = new System.Windows.Forms.Padding(0);
            this.dreamButtonChange.Name = "dreamButtonChange";
            this.dreamButtonChange.Size = new System.Drawing.Size(110, 26);
            this.dreamButtonChange.TabIndex = 9;
            this.dreamButtonChange.Text = "Изменить";
            this.dreamButtonChange.UseVisualStyleBackColor = true;
            this.dreamButtonChange.Click += new System.EventHandler(this.dreamButtonChange_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.hopeComboBoxOffice);
            this.panel1.Controls.Add(this.hopeComboBoxBuilding);
            this.panel1.Controls.Add(this.hopeComboBoxDepartment);
            this.panel1.Controls.Add(this.hopeComboBoxPosition);
            this.panel1.Controls.Add(this.hopeTextBoxEmail);
            this.panel1.Controls.Add(this.hopeTextBoxPersonalNumber);
            this.panel1.Controls.Add(this.hopeTextBoxWorkNumber);
            this.panel1.Controls.Add(this.labelOffice);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelBuilding);
            this.panel1.Controls.Add(this.labelDepartment);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelPersonalNumber);
            this.panel1.Controls.Add(this.labelWorkNumber);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 534);
            this.panel1.TabIndex = 0;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelFIO.Location = new System.Drawing.Point(96, 38);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(263, 25);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "Иванов Иван Иванович";
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelEmail.Location = new System.Drawing.Point(12, 191);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(443, 70);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Адрес электронной почты:";
            // 
            // labelPersonalNumber
            // 
            this.labelPersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersonalNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelPersonalNumber.Location = new System.Drawing.Point(12, 147);
            this.labelPersonalNumber.Name = "labelPersonalNumber";
            this.labelPersonalNumber.Size = new System.Drawing.Size(443, 32);
            this.labelPersonalNumber.TabIndex = 15;
            this.labelPersonalNumber.Text = "Личный номер:";
            // 
            // labelWorkNumber
            // 
            this.labelWorkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelWorkNumber.Location = new System.Drawing.Point(12, 102);
            this.labelWorkNumber.Name = "labelWorkNumber";
            this.labelWorkNumber.Size = new System.Drawing.Size(443, 30);
            this.labelWorkNumber.TabIndex = 14;
            this.labelWorkNumber.Text = "Рабочий номер:";
            // 
            // labelOffice
            // 
            this.labelOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOffice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelOffice.Location = new System.Drawing.Point(12, 409);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(245, 28);
            this.labelOffice.TabIndex = 20;
            this.labelOffice.Text = "Кабинет:";
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelPosition.Location = new System.Drawing.Point(12, 264);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(443, 28);
            this.labelPosition.TabIndex = 17;
            this.labelPosition.Text = "Должность:";
            // 
            // labelBuilding
            // 
            this.labelBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelBuilding.Location = new System.Drawing.Point(12, 358);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(245, 29);
            this.labelBuilding.TabIndex = 19;
            this.labelBuilding.Text = "Корпус:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.labelDepartment.Location = new System.Drawing.Point(12, 310);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(443, 29);
            this.labelDepartment.TabIndex = 18;
            this.labelDepartment.Text = "Подразделение:";
            // 
            // dreamButtonSave
            // 
            this.dreamButtonSave.ColorA = System.Drawing.Color.Aqua;
            this.dreamButtonSave.ColorB = System.Drawing.Color.Aqua;
            this.dreamButtonSave.ColorC = System.Drawing.Color.DarkCyan;
            this.dreamButtonSave.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dreamButtonSave.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreamButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dreamButtonSave.Location = new System.Drawing.Point(247, 64);
            this.dreamButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.dreamButtonSave.Name = "dreamButtonSave";
            this.dreamButtonSave.Size = new System.Drawing.Size(110, 26);
            this.dreamButtonSave.TabIndex = 10;
            this.dreamButtonSave.Text = "Сохранить";
            this.dreamButtonSave.UseVisualStyleBackColor = true;
            this.dreamButtonSave.Click += new System.EventHandler(this.dreamButtonSave_Click);
            // 
            // hopeTextBoxWorkNumber
            // 
            this.hopeTextBoxWorkNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeTextBoxWorkNumber.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBoxWorkNumber.BorderColorA = System.Drawing.Color.Transparent;
            this.hopeTextBoxWorkNumber.BorderColorB = System.Drawing.Color.Transparent;
            this.hopeTextBoxWorkNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxWorkNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeTextBoxWorkNumber.Hint = "";
            this.hopeTextBoxWorkNumber.Location = new System.Drawing.Point(175, 101);
            this.hopeTextBoxWorkNumber.MaxLength = 32767;
            this.hopeTextBoxWorkNumber.Multiline = true;
            this.hopeTextBoxWorkNumber.Name = "hopeTextBoxWorkNumber";
            this.hopeTextBoxWorkNumber.PasswordChar = '\0';
            this.hopeTextBoxWorkNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxWorkNumber.SelectedText = "";
            this.hopeTextBoxWorkNumber.SelectionLength = 0;
            this.hopeTextBoxWorkNumber.SelectionStart = 0;
            this.hopeTextBoxWorkNumber.Size = new System.Drawing.Size(280, 29);
            this.hopeTextBoxWorkNumber.TabIndex = 21;
            this.hopeTextBoxWorkNumber.TabStop = false;
            this.hopeTextBoxWorkNumber.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxPersonalNumber
            // 
            this.hopeTextBoxPersonalNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeTextBoxPersonalNumber.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBoxPersonalNumber.BorderColorA = System.Drawing.Color.Transparent;
            this.hopeTextBoxPersonalNumber.BorderColorB = System.Drawing.Color.Transparent;
            this.hopeTextBoxPersonalNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxPersonalNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeTextBoxPersonalNumber.Hint = "";
            this.hopeTextBoxPersonalNumber.Location = new System.Drawing.Point(166, 146);
            this.hopeTextBoxPersonalNumber.MaxLength = 32767;
            this.hopeTextBoxPersonalNumber.Multiline = true;
            this.hopeTextBoxPersonalNumber.Name = "hopeTextBoxPersonalNumber";
            this.hopeTextBoxPersonalNumber.PasswordChar = '\0';
            this.hopeTextBoxPersonalNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxPersonalNumber.SelectedText = "";
            this.hopeTextBoxPersonalNumber.SelectionLength = 0;
            this.hopeTextBoxPersonalNumber.SelectionStart = 0;
            this.hopeTextBoxPersonalNumber.Size = new System.Drawing.Size(289, 29);
            this.hopeTextBoxPersonalNumber.TabIndex = 22;
            this.hopeTextBoxPersonalNumber.TabStop = false;
            this.hopeTextBoxPersonalNumber.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxEmail
            // 
            this.hopeTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeTextBoxEmail.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBoxEmail.BorderColorA = System.Drawing.Color.Transparent;
            this.hopeTextBoxEmail.BorderColorB = System.Drawing.Color.Transparent;
            this.hopeTextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hopeTextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeTextBoxEmail.Hint = "";
            this.hopeTextBoxEmail.Location = new System.Drawing.Point(16, 218);
            this.hopeTextBoxEmail.MaxLength = 32767;
            this.hopeTextBoxEmail.Multiline = true;
            this.hopeTextBoxEmail.Name = "hopeTextBoxEmail";
            this.hopeTextBoxEmail.PasswordChar = '\0';
            this.hopeTextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxEmail.SelectedText = "";
            this.hopeTextBoxEmail.SelectionLength = 0;
            this.hopeTextBoxEmail.SelectionStart = 0;
            this.hopeTextBoxEmail.Size = new System.Drawing.Size(439, 29);
            this.hopeTextBoxEmail.TabIndex = 23;
            this.hopeTextBoxEmail.TabStop = false;
            this.hopeTextBoxEmail.UseSystemPasswordChar = false;
            // 
            // hopeComboBoxPosition
            // 
            this.hopeComboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeComboBoxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBoxPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subscribersBindingSource, "PositionId", true));
            this.hopeComboBoxPosition.DataSource = this.positionsBindingSource;
            this.hopeComboBoxPosition.DisplayMember = "PositionName";
            this.hopeComboBoxPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hopeComboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBoxPosition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBoxPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeComboBoxPosition.FormattingEnabled = true;
            this.hopeComboBoxPosition.ItemHeight = 23;
            this.hopeComboBoxPosition.Location = new System.Drawing.Point(137, 263);
            this.hopeComboBoxPosition.Name = "hopeComboBoxPosition";
            this.hopeComboBoxPosition.Size = new System.Drawing.Size(318, 29);
            this.hopeComboBoxPosition.TabIndex = 29;
            this.hopeComboBoxPosition.ValueMember = "IdPosition";
            // 
            // telephone_directory_DBDataSet
            // 
            this.telephone_directory_DBDataSet.DataSetName = "telephone_directory_DBDataSet";
            this.telephone_directory_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscribersBindingSource
            // 
            this.subscribersBindingSource.DataMember = "Subscribers";
            this.subscribersBindingSource.DataSource = this.telephone_directory_DBDataSet;
            // 
            // subscribersTableAdapter
            // 
            this.subscribersTableAdapter.ClearBeforeFill = true;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.telephone_directory_DBDataSet;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // hopeComboBoxDepartment
            // 
            this.hopeComboBoxDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeComboBoxDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBoxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subscribersBindingSource, "DepartmentId", true));
            this.hopeComboBoxDepartment.DataSource = this.departmentsBindingSource;
            this.hopeComboBoxDepartment.DisplayMember = "DepartmentName";
            this.hopeComboBoxDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hopeComboBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBoxDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBoxDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeComboBoxDepartment.FormattingEnabled = true;
            this.hopeComboBoxDepartment.ItemHeight = 23;
            this.hopeComboBoxDepartment.Location = new System.Drawing.Point(183, 310);
            this.hopeComboBoxDepartment.Name = "hopeComboBoxDepartment";
            this.hopeComboBoxDepartment.Size = new System.Drawing.Size(272, 29);
            this.hopeComboBoxDepartment.TabIndex = 30;
            this.hopeComboBoxDepartment.ValueMember = "IdDepartment";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.telephone_directory_DBDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // hopeComboBoxBuilding
            // 
            this.hopeComboBoxBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeComboBoxBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBoxBuilding.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subscribersBindingSource, "BuildingId", true));
            this.hopeComboBoxBuilding.DataSource = this.buildingsBindingSource;
            this.hopeComboBoxBuilding.DisplayMember = "BuildingName";
            this.hopeComboBoxBuilding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBoxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hopeComboBoxBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBoxBuilding.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBoxBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeComboBoxBuilding.FormattingEnabled = true;
            this.hopeComboBoxBuilding.ItemHeight = 23;
            this.hopeComboBoxBuilding.Location = new System.Drawing.Point(96, 357);
            this.hopeComboBoxBuilding.Name = "hopeComboBoxBuilding";
            this.hopeComboBoxBuilding.Size = new System.Drawing.Size(161, 29);
            this.hopeComboBoxBuilding.TabIndex = 31;
            this.hopeComboBoxBuilding.ValueMember = "IdBuilding";
            // 
            // hopeComboBoxOffice
            // 
            this.hopeComboBoxOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(189)))));
            this.hopeComboBoxOffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBoxOffice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subscribersBindingSource, "OfficeId", true));
            this.hopeComboBoxOffice.DataSource = this.officesBindingSource;
            this.hopeComboBoxOffice.DisplayMember = "RoomNumber";
            this.hopeComboBoxOffice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBoxOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hopeComboBoxOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBoxOffice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBoxOffice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(17)))), ((int)(((byte)(5)))));
            this.hopeComboBoxOffice.FormattingEnabled = true;
            this.hopeComboBoxOffice.ItemHeight = 23;
            this.hopeComboBoxOffice.Location = new System.Drawing.Point(109, 408);
            this.hopeComboBoxOffice.Name = "hopeComboBoxOffice";
            this.hopeComboBoxOffice.Size = new System.Drawing.Size(148, 29);
            this.hopeComboBoxOffice.TabIndex = 32;
            this.hopeComboBoxOffice.ValueMember = "IdOffice";
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.telephone_directory_DBDataSet;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "Offices";
            this.officesBindingSource.DataSource = this.telephone_directory_DBDataSet;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // MyCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(467, 635);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyCardForm";
            this.Text = "MyCardForm";
            this.Load += new System.EventHandler(this.MyCardForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_directory_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelHeader;
        private ReaLTaiizor.Controls.DreamButton dreamButtonExit;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private ReaLTaiizor.Controls.DreamButton dreamButtonChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPersonalNumber;
        private System.Windows.Forms.Label labelWorkNumber;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.Label labelDepartment;
        private ReaLTaiizor.Controls.DreamButton dreamButtonSave;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxEmail;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxPersonalNumber;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxWorkNumber;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxPosition;
        private telephone_directory_DBDataSet telephone_directory_DBDataSet;
        private System.Windows.Forms.BindingSource subscribersBindingSource;
        private telephone_directory_DBDataSetTableAdapters.SubscribersTableAdapter subscribersTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private telephone_directory_DBDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxDepartment;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private telephone_directory_DBDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxOffice;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxBuilding;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private telephone_directory_DBDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private telephone_directory_DBDataSetTableAdapters.OfficesTableAdapter officesTableAdapter;
    }
}