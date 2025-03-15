namespace InvoiceManager_DBFirst
{
    partial class ShopForm
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
            this.groupBoxShops = new System.Windows.Forms.GroupBox();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.groupBoxShopTypes = new System.Windows.Forms.GroupBox();
            this.dataGridViewShopTypes = new System.Windows.Forms.DataGridView();
            this.groupBoxItemTopGroupOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxShopTypeOptionsShopType = new System.Windows.Forms.ComboBox();
            this.buttonNewShopType = new System.Windows.Forms.Button();
            this.labelShopTypeOptionsShopType = new System.Windows.Forms.Label();
            this.buttonDeleteShopType = new System.Windows.Forms.Button();
            this.buttonUpdateShopType = new System.Windows.Forms.Button();
            this.buttonSaveShopType = new System.Windows.Forms.Button();
            this.groupBoxShopOptions = new System.Windows.Forms.GroupBox();
            this.labelShopOptionsShopGroup = new System.Windows.Forms.Label();
            this.comboBoxShopOptionsShopGroup = new System.Windows.Forms.ComboBox();
            this.buttonNewShop = new System.Windows.Forms.Button();
            this.textBoxShopOptionsWeb = new System.Windows.Forms.TextBox();
            this.labelShopOptionsWeb = new System.Windows.Forms.Label();
            this.textBoxShopOptionsEmail = new System.Windows.Forms.TextBox();
            this.labelShopOptionsEmail = new System.Windows.Forms.Label();
            this.textBoxShopOptionsTel = new System.Windows.Forms.TextBox();
            this.labelShopOptionsTel = new System.Windows.Forms.Label();
            this.textBoxShopOptionsNickName = new System.Windows.Forms.TextBox();
            this.labelShopOptionsShopName = new System.Windows.Forms.Label();
            this.textBoxShopOptionsShop = new System.Windows.Forms.TextBox();
            this.labelShopOptionsNickName = new System.Windows.Forms.Label();
            this.labelShopOptionsAddress = new System.Windows.Forms.Label();
            this.textBoxShopOptionsAddress = new System.Windows.Forms.TextBox();
            this.buttonDeleteShop = new System.Windows.Forms.Button();
            this.buttonUpdateShop = new System.Windows.Forms.Button();
            this.buttonSaveShop = new System.Windows.Forms.Button();
            this.groupBoxShopGroupOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxShopGroupOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewShopGroup = new System.Windows.Forms.Button();
            this.buttonSaveShopGroup = new System.Windows.Forms.Button();
            this.buttonUpdateShopGroup = new System.Windows.Forms.Button();
            this.buttonDeleteShopGroup = new System.Windows.Forms.Button();
            this.labelShopGroupOptionsOwner = new System.Windows.Forms.Label();
            this.textBoxShopGroupOptionsGroupName = new System.Windows.Forms.TextBox();
            this.labelShopGroupOptionsGroupName = new System.Windows.Forms.Label();
            this.comboBoxShopGroupOptionsShopType = new System.Windows.Forms.ComboBox();
            this.textBoxShopGroupOptionsOwner = new System.Windows.Forms.TextBox();
            this.labelShopGroupOptionsShopType = new System.Windows.Forms.Label();
            this.groupBoxShopGroups = new System.Windows.Forms.GroupBox();
            this.dataGridViewShopGroups = new System.Windows.Forms.DataGridView();
            this.checkBoxSetRelational = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.groupBoxShopTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopTypes)).BeginInit();
            this.groupBoxItemTopGroupOptions.SuspendLayout();
            this.groupBoxShopOptions.SuspendLayout();
            this.groupBoxShopGroupOptions.SuspendLayout();
            this.groupBoxShopGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxShops
            // 
            this.groupBoxShops.Controls.Add(this.dataGridViewShops);
            this.groupBoxShops.Location = new System.Drawing.Point(230, 14);
            this.groupBoxShops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShops.Name = "groupBoxShops";
            this.groupBoxShops.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShops.Size = new System.Drawing.Size(561, 558);
            this.groupBoxShops.TabIndex = 0;
            this.groupBoxShops.TabStop = false;
            this.groupBoxShops.Text = "Shops";
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewShops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.Size = new System.Drawing.Size(546, 530);
            this.dataGridViewShops.TabIndex = 0;
            this.dataGridViewShops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShops_CellClick);
            this.dataGridViewShops.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewShops_DataBindingComplete);
            // 
            // groupBoxShopTypes
            // 
            this.groupBoxShopTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxShopTypes.Controls.Add(this.dataGridViewShopTypes);
            this.groupBoxShopTypes.Location = new System.Drawing.Point(14, 14);
            this.groupBoxShopTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopTypes.Name = "groupBoxShopTypes";
            this.groupBoxShopTypes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopTypes.Size = new System.Drawing.Size(208, 765);
            this.groupBoxShopTypes.TabIndex = 1;
            this.groupBoxShopTypes.TabStop = false;
            this.groupBoxShopTypes.Text = "Edit shop type...";
            // 
            // dataGridViewShopTypes
            // 
            this.dataGridViewShopTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShopTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShopTypes.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewShopTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewShopTypes.Name = "dataGridViewShopTypes";
            this.dataGridViewShopTypes.Size = new System.Drawing.Size(193, 733);
            this.dataGridViewShopTypes.TabIndex = 0;
            this.dataGridViewShopTypes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewShopTypes_DataBindingComplete);
            // 
            // groupBoxItemTopGroupOptions
            // 
            this.groupBoxItemTopGroupOptions.Controls.Add(this.comboBoxShopTypeOptionsShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonNewShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.labelShopTypeOptionsShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonDeleteShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonUpdateShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonSaveShopType);
            this.groupBoxItemTopGroupOptions.Location = new System.Drawing.Point(1098, 578);
            this.groupBoxItemTopGroupOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemTopGroupOptions.Name = "groupBoxItemTopGroupOptions";
            this.groupBoxItemTopGroupOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemTopGroupOptions.Size = new System.Drawing.Size(318, 95);
            this.groupBoxItemTopGroupOptions.TabIndex = 13;
            this.groupBoxItemTopGroupOptions.TabStop = false;
            this.groupBoxItemTopGroupOptions.Text = "Shop Type Options";
            // 
            // comboBoxShopTypeOptionsShopType
            // 
            this.comboBoxShopTypeOptionsShopType.FormattingEnabled = true;
            this.comboBoxShopTypeOptionsShopType.Location = new System.Drawing.Point(93, 25);
            this.comboBoxShopTypeOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxShopTypeOptionsShopType.Name = "comboBoxShopTypeOptionsShopType";
            this.comboBoxShopTypeOptionsShopType.Size = new System.Drawing.Size(207, 23);
            this.comboBoxShopTypeOptionsShopType.TabIndex = 12;
            // 
            // buttonNewShopType
            // 
            this.buttonNewShopType.Location = new System.Drawing.Point(22, 58);
            this.buttonNewShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShopType.Name = "buttonNewShopType";
            this.buttonNewShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonNewShopType.TabIndex = 11;
            this.buttonNewShopType.Text = "New";
            this.buttonNewShopType.UseVisualStyleBackColor = true;
            this.buttonNewShopType.Click += new System.EventHandler(this.buttonNewShopType_Click);
            // 
            // labelShopTypeOptionsShopType
            // 
            this.labelShopTypeOptionsShopType.AutoSize = true;
            this.labelShopTypeOptionsShopType.Location = new System.Drawing.Point(13, 29);
            this.labelShopTypeOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopTypeOptionsShopType.Name = "labelShopTypeOptionsShopType";
            this.labelShopTypeOptionsShopType.Size = new System.Drawing.Size(61, 15);
            this.labelShopTypeOptionsShopType.TabIndex = 9;
            this.labelShopTypeOptionsShopType.Text = "Shop Type";
            // 
            // buttonDeleteShopType
            // 
            this.buttonDeleteShopType.Location = new System.Drawing.Point(236, 58);
            this.buttonDeleteShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShopType.Name = "buttonDeleteShopType";
            this.buttonDeleteShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonDeleteShopType.TabIndex = 8;
            this.buttonDeleteShopType.Text = "Delete";
            this.buttonDeleteShopType.UseVisualStyleBackColor = true;
            this.buttonDeleteShopType.Click += new System.EventHandler(this.buttonDeleteShopType_Click);
            // 
            // buttonUpdateShopType
            // 
            this.buttonUpdateShopType.Location = new System.Drawing.Point(165, 58);
            this.buttonUpdateShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShopType.Name = "buttonUpdateShopType";
            this.buttonUpdateShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonUpdateShopType.TabIndex = 7;
            this.buttonUpdateShopType.Text = "Update";
            this.buttonUpdateShopType.UseVisualStyleBackColor = true;
            this.buttonUpdateShopType.Click += new System.EventHandler(this.buttonUpdateShopType_Click);
            // 
            // buttonSaveShopType
            // 
            this.buttonSaveShopType.Location = new System.Drawing.Point(93, 58);
            this.buttonSaveShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShopType.Name = "buttonSaveShopType";
            this.buttonSaveShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonSaveShopType.TabIndex = 6;
            this.buttonSaveShopType.Text = "Save";
            this.buttonSaveShopType.UseVisualStyleBackColor = true;
            this.buttonSaveShopType.Click += new System.EventHandler(this.buttonSaveShopType_Click);
            // 
            // groupBoxShopOptions
            // 
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsShopGroup);
            this.groupBoxShopOptions.Controls.Add(this.comboBoxShopOptionsShopGroup);
            this.groupBoxShopOptions.Controls.Add(this.buttonNewShop);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsWeb);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsWeb);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsEmail);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsEmail);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsTel);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsTel);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsNickName);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsShopName);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsShop);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsNickName);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsAddress);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsAddress);
            this.groupBoxShopOptions.Controls.Add(this.buttonDeleteShop);
            this.groupBoxShopOptions.Controls.Add(this.buttonUpdateShop);
            this.groupBoxShopOptions.Controls.Add(this.buttonSaveShop);
            this.groupBoxShopOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShopOptions.Location = new System.Drawing.Point(230, 578);
            this.groupBoxShopOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopOptions.Name = "groupBoxShopOptions";
            this.groupBoxShopOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopOptions.Size = new System.Drawing.Size(522, 201);
            this.groupBoxShopOptions.TabIndex = 14;
            this.groupBoxShopOptions.TabStop = false;
            this.groupBoxShopOptions.Text = "Shop Options";
            // 
            // labelShopOptionsShopGroup
            // 
            this.labelShopOptionsShopGroup.AutoSize = true;
            this.labelShopOptionsShopGroup.Location = new System.Drawing.Point(23, 31);
            this.labelShopOptionsShopGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsShopGroup.Name = "labelShopOptionsShopGroup";
            this.labelShopOptionsShopGroup.Size = new System.Drawing.Size(41, 15);
            this.labelShopOptionsShopGroup.TabIndex = 36;
            this.labelShopOptionsShopGroup.Text = "Group";
            // 
            // comboBoxShopOptionsShopGroup
            // 
            this.comboBoxShopOptionsShopGroup.FormattingEnabled = true;
            this.comboBoxShopOptionsShopGroup.Location = new System.Drawing.Point(81, 27);
            this.comboBoxShopOptionsShopGroup.Name = "comboBoxShopOptionsShopGroup";
            this.comboBoxShopOptionsShopGroup.Size = new System.Drawing.Size(194, 23);
            this.comboBoxShopOptionsShopGroup.TabIndex = 35;
            // 
            // buttonNewShop
            // 
            this.buttonNewShop.Location = new System.Drawing.Point(164, 163);
            this.buttonNewShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShop.Name = "buttonNewShop";
            this.buttonNewShop.Size = new System.Drawing.Size(78, 27);
            this.buttonNewShop.TabIndex = 34;
            this.buttonNewShop.Text = "New";
            this.buttonNewShop.UseVisualStyleBackColor = true;
            this.buttonNewShop.Click += new System.EventHandler(this.buttonNewShop_Click);
            // 
            // textBoxShopOptionsWeb
            // 
            this.textBoxShopOptionsWeb.Location = new System.Drawing.Point(348, 126);
            this.textBoxShopOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsWeb.Name = "textBoxShopOptionsWeb";
            this.textBoxShopOptionsWeb.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsWeb.TabIndex = 33;
            // 
            // labelShopOptionsWeb
            // 
            this.labelShopOptionsWeb.AutoSize = true;
            this.labelShopOptionsWeb.Location = new System.Drawing.Point(303, 130);
            this.labelShopOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsWeb.Name = "labelShopOptionsWeb";
            this.labelShopOptionsWeb.Size = new System.Drawing.Size(32, 15);
            this.labelShopOptionsWeb.TabIndex = 32;
            this.labelShopOptionsWeb.Text = "Web";
            // 
            // textBoxShopOptionsEmail
            // 
            this.textBoxShopOptionsEmail.Location = new System.Drawing.Point(348, 93);
            this.textBoxShopOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsEmail.Name = "textBoxShopOptionsEmail";
            this.textBoxShopOptionsEmail.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsEmail.TabIndex = 31;
            // 
            // labelShopOptionsEmail
            // 
            this.labelShopOptionsEmail.AutoSize = true;
            this.labelShopOptionsEmail.Location = new System.Drawing.Point(293, 98);
            this.labelShopOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsEmail.Name = "labelShopOptionsEmail";
            this.labelShopOptionsEmail.Size = new System.Drawing.Size(42, 15);
            this.labelShopOptionsEmail.TabIndex = 30;
            this.labelShopOptionsEmail.Text = "E-mail";
            // 
            // textBoxShopOptionsTel
            // 
            this.textBoxShopOptionsTel.Location = new System.Drawing.Point(348, 60);
            this.textBoxShopOptionsTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsTel.Name = "textBoxShopOptionsTel";
            this.textBoxShopOptionsTel.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsTel.TabIndex = 29;
            // 
            // labelShopOptionsTel
            // 
            this.labelShopOptionsTel.AutoSize = true;
            this.labelShopOptionsTel.Location = new System.Drawing.Point(313, 64);
            this.labelShopOptionsTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsTel.Name = "labelShopOptionsTel";
            this.labelShopOptionsTel.Size = new System.Drawing.Size(22, 15);
            this.labelShopOptionsTel.TabIndex = 28;
            this.labelShopOptionsTel.Text = "Tel";
            // 
            // textBoxShopOptionsNickName
            // 
            this.textBoxShopOptionsNickName.Location = new System.Drawing.Point(348, 27);
            this.textBoxShopOptionsNickName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsNickName.Name = "textBoxShopOptionsNickName";
            this.textBoxShopOptionsNickName.Size = new System.Drawing.Size(158, 23);
            this.textBoxShopOptionsNickName.TabIndex = 6;
            // 
            // labelShopOptionsShopName
            // 
            this.labelShopOptionsShopName.AutoSize = true;
            this.labelShopOptionsShopName.Location = new System.Drawing.Point(30, 64);
            this.labelShopOptionsShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsShopName.Name = "labelShopOptionsShopName";
            this.labelShopOptionsShopName.Size = new System.Drawing.Size(34, 15);
            this.labelShopOptionsShopName.TabIndex = 3;
            this.labelShopOptionsShopName.Text = "Shop";
            // 
            // textBoxShopOptionsShop
            // 
            this.textBoxShopOptionsShop.Location = new System.Drawing.Point(81, 60);
            this.textBoxShopOptionsShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsShop.Name = "textBoxShopOptionsShop";
            this.textBoxShopOptionsShop.Size = new System.Drawing.Size(194, 23);
            this.textBoxShopOptionsShop.TabIndex = 4;
            // 
            // labelShopOptionsNickName
            // 
            this.labelShopOptionsNickName.AutoSize = true;
            this.labelShopOptionsNickName.Location = new System.Drawing.Point(304, 31);
            this.labelShopOptionsNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsNickName.Name = "labelShopOptionsNickName";
            this.labelShopOptionsNickName.Size = new System.Drawing.Size(31, 15);
            this.labelShopOptionsNickName.TabIndex = 5;
            this.labelShopOptionsNickName.Text = "Nick";
            // 
            // labelShopOptionsAddress
            // 
            this.labelShopOptionsAddress.AutoSize = true;
            this.labelShopOptionsAddress.Location = new System.Drawing.Point(13, 96);
            this.labelShopOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsAddress.Name = "labelShopOptionsAddress";
            this.labelShopOptionsAddress.Size = new System.Drawing.Size(51, 15);
            this.labelShopOptionsAddress.TabIndex = 7;
            this.labelShopOptionsAddress.Text = "Address";
            // 
            // textBoxShopOptionsAddress
            // 
            this.textBoxShopOptionsAddress.Location = new System.Drawing.Point(81, 93);
            this.textBoxShopOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsAddress.Multiline = true;
            this.textBoxShopOptionsAddress.Name = "textBoxShopOptionsAddress";
            this.textBoxShopOptionsAddress.Size = new System.Drawing.Size(194, 56);
            this.textBoxShopOptionsAddress.TabIndex = 8;
            // 
            // buttonDeleteShop
            // 
            this.buttonDeleteShop.Location = new System.Drawing.Point(428, 163);
            this.buttonDeleteShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShop.Name = "buttonDeleteShop";
            this.buttonDeleteShop.Size = new System.Drawing.Size(78, 27);
            this.buttonDeleteShop.TabIndex = 27;
            this.buttonDeleteShop.Text = "Delete";
            this.buttonDeleteShop.UseVisualStyleBackColor = true;
            this.buttonDeleteShop.Click += new System.EventHandler(this.buttonDeleteShop_Click);
            // 
            // buttonUpdateShop
            // 
            this.buttonUpdateShop.Location = new System.Drawing.Point(340, 163);
            this.buttonUpdateShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShop.Name = "buttonUpdateShop";
            this.buttonUpdateShop.Size = new System.Drawing.Size(78, 27);
            this.buttonUpdateShop.TabIndex = 26;
            this.buttonUpdateShop.Text = "Update";
            this.buttonUpdateShop.UseVisualStyleBackColor = true;
            this.buttonUpdateShop.Click += new System.EventHandler(this.buttonUpdateShop_Click);
            // 
            // buttonSaveShop
            // 
            this.buttonSaveShop.Location = new System.Drawing.Point(252, 163);
            this.buttonSaveShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShop.Name = "buttonSaveShop";
            this.buttonSaveShop.Size = new System.Drawing.Size(78, 27);
            this.buttonSaveShop.TabIndex = 25;
            this.buttonSaveShop.Text = "Save";
            this.buttonSaveShop.UseVisualStyleBackColor = true;
            this.buttonSaveShop.Click += new System.EventHandler(this.buttonSaveShop_Click);
            // 
            // groupBoxShopGroupOptions
            // 
            this.groupBoxShopGroupOptions.Controls.Add(this.checkBoxShopGroupOptionsEdit);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonNewShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonSaveShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonUpdateShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.buttonDeleteShopGroup);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsOwner);
            this.groupBoxShopGroupOptions.Controls.Add(this.textBoxShopGroupOptionsGroupName);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsGroupName);
            this.groupBoxShopGroupOptions.Controls.Add(this.comboBoxShopGroupOptionsShopType);
            this.groupBoxShopGroupOptions.Controls.Add(this.textBoxShopGroupOptionsOwner);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsShopType);
            this.groupBoxShopGroupOptions.Location = new System.Drawing.Point(760, 578);
            this.groupBoxShopGroupOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroupOptions.Name = "groupBoxShopGroupOptions";
            this.groupBoxShopGroupOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroupOptions.Size = new System.Drawing.Size(330, 201);
            this.groupBoxShopGroupOptions.TabIndex = 15;
            this.groupBoxShopGroupOptions.TabStop = false;
            this.groupBoxShopGroupOptions.Text = "Shop Group Options";
            // 
            // checkBoxShopGroupOptionsEdit
            // 
            this.checkBoxShopGroupOptionsEdit.AutoSize = true;
            this.checkBoxShopGroupOptionsEdit.Location = new System.Drawing.Point(239, 169);
            this.checkBoxShopGroupOptionsEdit.Name = "checkBoxShopGroupOptionsEdit";
            this.checkBoxShopGroupOptionsEdit.Size = new System.Drawing.Size(71, 19);
            this.checkBoxShopGroupOptionsEdit.TabIndex = 36;
            this.checkBoxShopGroupOptionsEdit.Text = "Editable";
            this.checkBoxShopGroupOptionsEdit.UseVisualStyleBackColor = true;
            this.checkBoxShopGroupOptionsEdit.CheckedChanged += new System.EventHandler(this.checkBoxShopGroupOptionsEdit_CheckedChanged);
            // 
            // buttonNewShopGroup
            // 
            this.buttonNewShopGroup.Location = new System.Drawing.Point(24, 130);
            this.buttonNewShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShopGroup.Name = "buttonNewShopGroup";
            this.buttonNewShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonNewShopGroup.TabIndex = 35;
            this.buttonNewShopGroup.Text = "New";
            this.buttonNewShopGroup.UseVisualStyleBackColor = true;
            this.buttonNewShopGroup.Click += new System.EventHandler(this.buttonNewShopGroup_Click);
            // 
            // buttonSaveShopGroup
            // 
            this.buttonSaveShopGroup.Location = new System.Drawing.Point(98, 130);
            this.buttonSaveShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShopGroup.Name = "buttonSaveShopGroup";
            this.buttonSaveShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonSaveShopGroup.TabIndex = 32;
            this.buttonSaveShopGroup.Text = "Save";
            this.buttonSaveShopGroup.UseVisualStyleBackColor = true;
            this.buttonSaveShopGroup.Click += new System.EventHandler(this.buttonSaveShopGroup_Click);
            // 
            // buttonUpdateShopGroup
            // 
            this.buttonUpdateShopGroup.Location = new System.Drawing.Point(172, 130);
            this.buttonUpdateShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShopGroup.Name = "buttonUpdateShopGroup";
            this.buttonUpdateShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonUpdateShopGroup.TabIndex = 33;
            this.buttonUpdateShopGroup.Text = "Update";
            this.buttonUpdateShopGroup.UseVisualStyleBackColor = true;
            this.buttonUpdateShopGroup.Click += new System.EventHandler(this.buttonUpdateShopGroup_Click);
            // 
            // buttonDeleteShopGroup
            // 
            this.buttonDeleteShopGroup.Location = new System.Drawing.Point(246, 130);
            this.buttonDeleteShopGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShopGroup.Name = "buttonDeleteShopGroup";
            this.buttonDeleteShopGroup.Size = new System.Drawing.Size(64, 27);
            this.buttonDeleteShopGroup.TabIndex = 34;
            this.buttonDeleteShopGroup.Text = "Delete";
            this.buttonDeleteShopGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteShopGroup.Click += new System.EventHandler(this.buttonDeleteShopGroup_Click);
            // 
            // labelShopGroupOptionsOwner
            // 
            this.labelShopGroupOptionsOwner.AutoSize = true;
            this.labelShopGroupOptionsOwner.Location = new System.Drawing.Point(5, 64);
            this.labelShopGroupOptionsOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsOwner.Name = "labelShopGroupOptionsOwner";
            this.labelShopGroupOptionsOwner.Size = new System.Drawing.Size(43, 15);
            this.labelShopGroupOptionsOwner.TabIndex = 32;
            this.labelShopGroupOptionsOwner.Text = "Owner";
            // 
            // textBoxShopGroupOptionsGroupName
            // 
            this.textBoxShopGroupOptionsGroupName.Location = new System.Drawing.Point(56, 27);
            this.textBoxShopGroupOptionsGroupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopGroupOptionsGroupName.Name = "textBoxShopGroupOptionsGroupName";
            this.textBoxShopGroupOptionsGroupName.Size = new System.Drawing.Size(254, 23);
            this.textBoxShopGroupOptionsGroupName.TabIndex = 33;
            // 
            // labelShopGroupOptionsGroupName
            // 
            this.labelShopGroupOptionsGroupName.AutoSize = true;
            this.labelShopGroupOptionsGroupName.Location = new System.Drawing.Point(7, 31);
            this.labelShopGroupOptionsGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsGroupName.Name = "labelShopGroupOptionsGroupName";
            this.labelShopGroupOptionsGroupName.Size = new System.Drawing.Size(41, 15);
            this.labelShopGroupOptionsGroupName.TabIndex = 32;
            this.labelShopGroupOptionsGroupName.Text = "Group";
            // 
            // comboBoxShopGroupOptionsShopType
            // 
            this.comboBoxShopGroupOptionsShopType.FormattingEnabled = true;
            this.comboBoxShopGroupOptionsShopType.Location = new System.Drawing.Point(56, 93);
            this.comboBoxShopGroupOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxShopGroupOptionsShopType.Name = "comboBoxShopGroupOptionsShopType";
            this.comboBoxShopGroupOptionsShopType.Size = new System.Drawing.Size(254, 23);
            this.comboBoxShopGroupOptionsShopType.TabIndex = 13;
            // 
            // textBoxShopGroupOptionsOwner
            // 
            this.textBoxShopGroupOptionsOwner.Location = new System.Drawing.Point(56, 60);
            this.textBoxShopGroupOptionsOwner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopGroupOptionsOwner.Name = "textBoxShopGroupOptionsOwner";
            this.textBoxShopGroupOptionsOwner.Size = new System.Drawing.Size(254, 23);
            this.textBoxShopGroupOptionsOwner.TabIndex = 33;
            // 
            // labelShopGroupOptionsShopType
            // 
            this.labelShopGroupOptionsShopType.AutoSize = true;
            this.labelShopGroupOptionsShopType.Location = new System.Drawing.Point(17, 98);
            this.labelShopGroupOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsShopType.Name = "labelShopGroupOptionsShopType";
            this.labelShopGroupOptionsShopType.Size = new System.Drawing.Size(31, 15);
            this.labelShopGroupOptionsShopType.TabIndex = 34;
            this.labelShopGroupOptionsShopType.Text = "Type";
            // 
            // groupBoxShopGroups
            // 
            this.groupBoxShopGroups.Controls.Add(this.dataGridViewShopGroups);
            this.groupBoxShopGroups.Location = new System.Drawing.Point(799, 14);
            this.groupBoxShopGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroups.Name = "groupBoxShopGroups";
            this.groupBoxShopGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroups.Size = new System.Drawing.Size(617, 558);
            this.groupBoxShopGroups.TabIndex = 1;
            this.groupBoxShopGroups.TabStop = false;
            this.groupBoxShopGroups.Text = "Shop Groups";
            // 
            // dataGridViewShopGroups
            // 
            this.dataGridViewShopGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShopGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShopGroups.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewShopGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewShopGroups.Name = "dataGridViewShopGroups";
            this.dataGridViewShopGroups.Size = new System.Drawing.Size(602, 530);
            this.dataGridViewShopGroups.TabIndex = 0;
            this.dataGridViewShopGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShopGroups_CellClick);
            this.dataGridViewShopGroups.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewShopGroups_DataBindingComplete);
            // 
            // checkBoxSetRelational
            // 
            this.checkBoxSetRelational.AutoSize = true;
            this.checkBoxSetRelational.Location = new System.Drawing.Point(1098, 679);
            this.checkBoxSetRelational.Name = "checkBoxSetRelational";
            this.checkBoxSetRelational.Size = new System.Drawing.Size(101, 19);
            this.checkBoxSetRelational.TabIndex = 16;
            this.checkBoxSetRelational.Text = "Set Relational";
            this.checkBoxSetRelational.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1320, 748);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 27);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 785);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkBoxSetRelational);
            this.Controls.Add(this.groupBoxShopGroups);
            this.Controls.Add(this.groupBoxShopGroupOptions);
            this.Controls.Add(this.groupBoxShopOptions);
            this.Controls.Add(this.groupBoxItemTopGroupOptions);
            this.Controls.Add(this.groupBoxShopTypes);
            this.Controls.Add(this.groupBoxShops);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ShopForm";
            this.Text = "Edit Shops...";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.groupBoxShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.groupBoxShopTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopTypes)).EndInit();
            this.groupBoxItemTopGroupOptions.ResumeLayout(false);
            this.groupBoxItemTopGroupOptions.PerformLayout();
            this.groupBoxShopOptions.ResumeLayout(false);
            this.groupBoxShopOptions.PerformLayout();
            this.groupBoxShopGroupOptions.ResumeLayout(false);
            this.groupBoxShopGroupOptions.PerformLayout();
            this.groupBoxShopGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShops;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.GroupBox groupBoxShopTypes;
        private System.Windows.Forms.DataGridView dataGridViewShopTypes;
        private System.Windows.Forms.GroupBox groupBoxItemTopGroupOptions;
        private System.Windows.Forms.ComboBox comboBoxShopTypeOptionsShopType;
        private System.Windows.Forms.Button buttonNewShopType;
        private System.Windows.Forms.Label labelShopTypeOptionsShopType;
        private System.Windows.Forms.Button buttonDeleteShopType;
        private System.Windows.Forms.Button buttonUpdateShopType;
        private System.Windows.Forms.Button buttonSaveShopType;
        private System.Windows.Forms.GroupBox groupBoxShopOptions;
        private System.Windows.Forms.TextBox textBoxShopOptionsNickName;
        private System.Windows.Forms.Label labelShopOptionsShopName;
        private System.Windows.Forms.TextBox textBoxShopOptionsShop;
        private System.Windows.Forms.Label labelShopOptionsNickName;
        private System.Windows.Forms.Label labelShopOptionsAddress;
        private System.Windows.Forms.TextBox textBoxShopOptionsAddress;
        private System.Windows.Forms.Button buttonDeleteShop;
        private System.Windows.Forms.Button buttonUpdateShop;
        private System.Windows.Forms.Button buttonSaveShop;
        private System.Windows.Forms.GroupBox groupBoxShopGroupOptions;
        private System.Windows.Forms.Label labelShopGroupOptionsGroupName;
        private System.Windows.Forms.Label labelShopGroupOptionsShopType;
        private System.Windows.Forms.Label labelShopGroupOptionsOwner;
        private System.Windows.Forms.ComboBox comboBoxShopGroupOptionsShopType;
        private System.Windows.Forms.TextBox textBoxShopGroupOptionsOwner;
        private System.Windows.Forms.TextBox textBoxShopGroupOptionsGroupName;
        private System.Windows.Forms.Button buttonSaveShopGroup;
        private System.Windows.Forms.Button buttonUpdateShopGroup;
        private System.Windows.Forms.Button buttonDeleteShopGroup;
        private System.Windows.Forms.GroupBox groupBoxShopGroups;
        private System.Windows.Forms.DataGridView dataGridViewShopGroups;
        private System.Windows.Forms.CheckBox checkBoxSetRelational;
        private System.Windows.Forms.Button buttonNewShop;
        private System.Windows.Forms.TextBox textBoxShopOptionsWeb;
        private System.Windows.Forms.Label labelShopOptionsWeb;
        private System.Windows.Forms.TextBox textBoxShopOptionsEmail;
        private System.Windows.Forms.Label labelShopOptionsEmail;
        private System.Windows.Forms.TextBox textBoxShopOptionsTel;
        private System.Windows.Forms.Label labelShopOptionsTel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxShopOptionsShopGroup;
        private System.Windows.Forms.Label labelShopOptionsShopGroup;
        private System.Windows.Forms.Button buttonNewShopGroup;
        private System.Windows.Forms.CheckBox checkBoxShopGroupOptionsEdit;
    }
}