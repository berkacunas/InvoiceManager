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
            this.textBoxShopOptionsNickName = new System.Windows.Forms.TextBox();
            this.labelShopOptionsShopName = new System.Windows.Forms.Label();
            this.textBoxShopOptionsShopName = new System.Windows.Forms.TextBox();
            this.labelShopOptionsNickName = new System.Windows.Forms.Label();
            this.labelShopOptionsAddress = new System.Windows.Forms.Label();
            this.textBoxShopOptionsAddress = new System.Windows.Forms.TextBox();
            this.buttonDeleteShop = new System.Windows.Forms.Button();
            this.buttonUpdateShop = new System.Windows.Forms.Button();
            this.buttonSaveShop = new System.Windows.Forms.Button();
            this.groupBoxShopGroupOptions = new System.Windows.Forms.GroupBox();
            this.labelShopGroupOptionsGroupName = new System.Windows.Forms.Label();
            this.labelShopGroupOptionsShopType = new System.Windows.Forms.Label();
            this.labelShopGroupOptionsOwner = new System.Windows.Forms.Label();
            this.comboBoxShopGroupOptionsShopType = new System.Windows.Forms.ComboBox();
            this.textBoxShopGroupOptionsOwner = new System.Windows.Forms.TextBox();
            this.textBoxShopGroupOptionsGroupName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxShopGroups = new System.Windows.Forms.GroupBox();
            this.dataGridViewShopGroups = new System.Windows.Forms.DataGridView();
            this.checkBoxSetRelational = new System.Windows.Forms.CheckBox();
            this.textBoxShopOptionsTel = new System.Windows.Forms.TextBox();
            this.labelShopOptionsTel = new System.Windows.Forms.Label();
            this.textBoxShopOptionsEmail = new System.Windows.Forms.TextBox();
            this.labelShopOptionsEmail = new System.Windows.Forms.Label();
            this.textBoxShopOptionsWeb = new System.Windows.Forms.TextBox();
            this.labelShopOptionsWeb = new System.Windows.Forms.Label();
            this.buttonNewShop = new System.Windows.Forms.Button();
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
            this.groupBoxShopTypes.Size = new System.Drawing.Size(208, 775);
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
            this.dataGridViewShopTypes.Size = new System.Drawing.Size(193, 747);
            this.dataGridViewShopTypes.TabIndex = 0;
            // 
            // groupBoxItemTopGroupOptions
            // 
            this.groupBoxItemTopGroupOptions.Controls.Add(this.comboBoxShopTypeOptionsShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonNewShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.labelShopTypeOptionsShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonDeleteShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonUpdateShopType);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonSaveShopType);
            this.groupBoxItemTopGroupOptions.Location = new System.Drawing.Point(806, 706);
            this.groupBoxItemTopGroupOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemTopGroupOptions.Name = "groupBoxItemTopGroupOptions";
            this.groupBoxItemTopGroupOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemTopGroupOptions.Size = new System.Drawing.Size(388, 95);
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
            this.comboBoxShopTypeOptionsShopType.Size = new System.Drawing.Size(279, 23);
            this.comboBoxShopTypeOptionsShopType.TabIndex = 12;
            // 
            // buttonNewShopType
            // 
            this.buttonNewShopType.Location = new System.Drawing.Point(93, 58);
            this.buttonNewShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShopType.Name = "buttonNewShopType";
            this.buttonNewShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonNewShopType.TabIndex = 11;
            this.buttonNewShopType.Text = "New";
            this.buttonNewShopType.UseVisualStyleBackColor = true;
            // 
            // labelShopTypeOptionsShopType
            // 
            this.labelShopTypeOptionsShopType.AutoSize = true;
            this.labelShopTypeOptionsShopType.Location = new System.Drawing.Point(13, 30);
            this.labelShopTypeOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopTypeOptionsShopType.Name = "labelShopTypeOptionsShopType";
            this.labelShopTypeOptionsShopType.Size = new System.Drawing.Size(61, 15);
            this.labelShopTypeOptionsShopType.TabIndex = 9;
            this.labelShopTypeOptionsShopType.Text = "Shop Type";
            // 
            // buttonDeleteShopType
            // 
            this.buttonDeleteShopType.Location = new System.Drawing.Point(307, 58);
            this.buttonDeleteShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShopType.Name = "buttonDeleteShopType";
            this.buttonDeleteShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonDeleteShopType.TabIndex = 8;
            this.buttonDeleteShopType.Text = "Delete";
            this.buttonDeleteShopType.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateShopType
            // 
            this.buttonUpdateShopType.Location = new System.Drawing.Point(236, 58);
            this.buttonUpdateShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShopType.Name = "buttonUpdateShopType";
            this.buttonUpdateShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonUpdateShopType.TabIndex = 7;
            this.buttonUpdateShopType.Text = "Update";
            this.buttonUpdateShopType.UseVisualStyleBackColor = true;
            // 
            // buttonSaveShopType
            // 
            this.buttonSaveShopType.Location = new System.Drawing.Point(164, 58);
            this.buttonSaveShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShopType.Name = "buttonSaveShopType";
            this.buttonSaveShopType.Size = new System.Drawing.Size(64, 27);
            this.buttonSaveShopType.TabIndex = 6;
            this.buttonSaveShopType.Text = "Save";
            this.buttonSaveShopType.UseVisualStyleBackColor = true;
            // 
            // groupBoxShopOptions
            // 
            this.groupBoxShopOptions.Controls.Add(this.buttonNewShop);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsWeb);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsWeb);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsEmail);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsEmail);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsTel);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsTel);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsNickName);
            this.groupBoxShopOptions.Controls.Add(this.labelShopOptionsShopName);
            this.groupBoxShopOptions.Controls.Add(this.textBoxShopOptionsShopName);
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
            this.groupBoxShopOptions.Size = new System.Drawing.Size(561, 201);
            this.groupBoxShopOptions.TabIndex = 14;
            this.groupBoxShopOptions.TabStop = false;
            this.groupBoxShopOptions.Text = "Shop Options";
            // 
            // textBoxShopOptionsNickName
            // 
            this.textBoxShopOptionsNickName.Location = new System.Drawing.Point(377, 27);
            this.textBoxShopOptionsNickName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsNickName.Name = "textBoxShopOptionsNickName";
            this.textBoxShopOptionsNickName.Size = new System.Drawing.Size(165, 23);
            this.textBoxShopOptionsNickName.TabIndex = 6;
            // 
            // labelShopOptionsShopName
            // 
            this.labelShopOptionsShopName.AutoSize = true;
            this.labelShopOptionsShopName.Location = new System.Drawing.Point(28, 32);
            this.labelShopOptionsShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsShopName.Name = "labelShopOptionsShopName";
            this.labelShopOptionsShopName.Size = new System.Drawing.Size(34, 15);
            this.labelShopOptionsShopName.TabIndex = 3;
            this.labelShopOptionsShopName.Text = "Shop";
            // 
            // textBoxShopOptionsShopName
            // 
            this.textBoxShopOptionsShopName.Location = new System.Drawing.Point(90, 27);
            this.textBoxShopOptionsShopName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsShopName.Name = "textBoxShopOptionsShopName";
            this.textBoxShopOptionsShopName.Size = new System.Drawing.Size(206, 23);
            this.textBoxShopOptionsShopName.TabIndex = 4;
            // 
            // labelShopOptionsNickName
            // 
            this.labelShopOptionsNickName.AutoSize = true;
            this.labelShopOptionsNickName.Location = new System.Drawing.Point(330, 32);
            this.labelShopOptionsNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsNickName.Name = "labelShopOptionsNickName";
            this.labelShopOptionsNickName.Size = new System.Drawing.Size(31, 15);
            this.labelShopOptionsNickName.TabIndex = 5;
            this.labelShopOptionsNickName.Text = "Nick";
            // 
            // labelShopOptionsAddress
            // 
            this.labelShopOptionsAddress.AutoSize = true;
            this.labelShopOptionsAddress.Location = new System.Drawing.Point(11, 59);
            this.labelShopOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsAddress.Name = "labelShopOptionsAddress";
            this.labelShopOptionsAddress.Size = new System.Drawing.Size(51, 15);
            this.labelShopOptionsAddress.TabIndex = 7;
            this.labelShopOptionsAddress.Text = "Address";
            // 
            // textBoxShopOptionsAddress
            // 
            this.textBoxShopOptionsAddress.Location = new System.Drawing.Point(90, 59);
            this.textBoxShopOptionsAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsAddress.Multiline = true;
            this.textBoxShopOptionsAddress.Name = "textBoxShopOptionsAddress";
            this.textBoxShopOptionsAddress.Size = new System.Drawing.Size(206, 89);
            this.textBoxShopOptionsAddress.TabIndex = 8;
            // 
            // buttonDeleteShop
            // 
            this.buttonDeleteShop.Location = new System.Drawing.Point(454, 162);
            this.buttonDeleteShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteShop.Name = "buttonDeleteShop";
            this.buttonDeleteShop.Size = new System.Drawing.Size(88, 27);
            this.buttonDeleteShop.TabIndex = 27;
            this.buttonDeleteShop.Text = "Delete";
            this.buttonDeleteShop.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateShop
            // 
            this.buttonUpdateShop.Location = new System.Drawing.Point(357, 162);
            this.buttonUpdateShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateShop.Name = "buttonUpdateShop";
            this.buttonUpdateShop.Size = new System.Drawing.Size(88, 27);
            this.buttonUpdateShop.TabIndex = 26;
            this.buttonUpdateShop.Text = "Update";
            this.buttonUpdateShop.UseVisualStyleBackColor = true;
            // 
            // buttonSaveShop
            // 
            this.buttonSaveShop.Location = new System.Drawing.Point(260, 162);
            this.buttonSaveShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveShop.Name = "buttonSaveShop";
            this.buttonSaveShop.Size = new System.Drawing.Size(88, 27);
            this.buttonSaveShop.TabIndex = 25;
            this.buttonSaveShop.Text = "Save";
            this.buttonSaveShop.UseVisualStyleBackColor = true;
            // 
            // groupBoxShopGroupOptions
            // 
            this.groupBoxShopGroupOptions.Controls.Add(this.button3);
            this.groupBoxShopGroupOptions.Controls.Add(this.button2);
            this.groupBoxShopGroupOptions.Controls.Add(this.button1);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsOwner);
            this.groupBoxShopGroupOptions.Controls.Add(this.textBoxShopGroupOptionsGroupName);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsGroupName);
            this.groupBoxShopGroupOptions.Controls.Add(this.comboBoxShopGroupOptionsShopType);
            this.groupBoxShopGroupOptions.Controls.Add(this.textBoxShopGroupOptionsOwner);
            this.groupBoxShopGroupOptions.Controls.Add(this.labelShopGroupOptionsShopType);
            this.groupBoxShopGroupOptions.Location = new System.Drawing.Point(806, 578);
            this.groupBoxShopGroupOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroupOptions.Name = "groupBoxShopGroupOptions";
            this.groupBoxShopGroupOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxShopGroupOptions.Size = new System.Drawing.Size(610, 123);
            this.groupBoxShopGroupOptions.TabIndex = 15;
            this.groupBoxShopGroupOptions.TabStop = false;
            this.groupBoxShopGroupOptions.Text = "Shop Group Options";
            // 
            // labelShopGroupOptionsGroupName
            // 
            this.labelShopGroupOptionsGroupName.AutoSize = true;
            this.labelShopGroupOptionsGroupName.Location = new System.Drawing.Point(7, 29);
            this.labelShopGroupOptionsGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsGroupName.Name = "labelShopGroupOptionsGroupName";
            this.labelShopGroupOptionsGroupName.Size = new System.Drawing.Size(41, 15);
            this.labelShopGroupOptionsGroupName.TabIndex = 32;
            this.labelShopGroupOptionsGroupName.Text = "Group";
            // 
            // labelShopGroupOptionsShopType
            // 
            this.labelShopGroupOptionsShopType.AutoSize = true;
            this.labelShopGroupOptionsShopType.Location = new System.Drawing.Point(17, 96);
            this.labelShopGroupOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsShopType.Name = "labelShopGroupOptionsShopType";
            this.labelShopGroupOptionsShopType.Size = new System.Drawing.Size(31, 15);
            this.labelShopGroupOptionsShopType.TabIndex = 34;
            this.labelShopGroupOptionsShopType.Text = "Type";
            // 
            // labelShopGroupOptionsOwner
            // 
            this.labelShopGroupOptionsOwner.AutoSize = true;
            this.labelShopGroupOptionsOwner.Location = new System.Drawing.Point(5, 63);
            this.labelShopGroupOptionsOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopGroupOptionsOwner.Name = "labelShopGroupOptionsOwner";
            this.labelShopGroupOptionsOwner.Size = new System.Drawing.Size(43, 15);
            this.labelShopGroupOptionsOwner.TabIndex = 32;
            this.labelShopGroupOptionsOwner.Text = "Owner";
            // 
            // comboBoxShopGroupOptionsShopType
            // 
            this.comboBoxShopGroupOptionsShopType.FormattingEnabled = true;
            this.comboBoxShopGroupOptionsShopType.Location = new System.Drawing.Point(56, 91);
            this.comboBoxShopGroupOptionsShopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxShopGroupOptionsShopType.Name = "comboBoxShopGroupOptionsShopType";
            this.comboBoxShopGroupOptionsShopType.Size = new System.Drawing.Size(206, 23);
            this.comboBoxShopGroupOptionsShopType.TabIndex = 13;
            // 
            // textBoxShopGroupOptionsOwner
            // 
            this.textBoxShopGroupOptionsOwner.Location = new System.Drawing.Point(56, 57);
            this.textBoxShopGroupOptionsOwner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopGroupOptionsOwner.Name = "textBoxShopGroupOptionsOwner";
            this.textBoxShopGroupOptionsOwner.Size = new System.Drawing.Size(206, 23);
            this.textBoxShopGroupOptionsOwner.TabIndex = 33;
            // 
            // textBoxShopGroupOptionsGroupName
            // 
            this.textBoxShopGroupOptionsGroupName.Location = new System.Drawing.Point(56, 23);
            this.textBoxShopGroupOptionsGroupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopGroupOptionsGroupName.Name = "textBoxShopGroupOptionsGroupName";
            this.textBoxShopGroupOptionsGroupName.Size = new System.Drawing.Size(434, 23);
            this.textBoxShopGroupOptionsGroupName.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 32;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // checkBoxSetRelational
            // 
            this.checkBoxSetRelational.AutoSize = true;
            this.checkBoxSetRelational.Location = new System.Drawing.Point(23, 787);
            this.checkBoxSetRelational.Name = "checkBoxSetRelational";
            this.checkBoxSetRelational.Size = new System.Drawing.Size(101, 19);
            this.checkBoxSetRelational.TabIndex = 16;
            this.checkBoxSetRelational.Text = "Set Relational";
            this.checkBoxSetRelational.UseVisualStyleBackColor = true;
            // 
            // textBoxShopOptionsTel
            // 
            this.textBoxShopOptionsTel.Location = new System.Drawing.Point(377, 59);
            this.textBoxShopOptionsTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsTel.Name = "textBoxShopOptionsTel";
            this.textBoxShopOptionsTel.Size = new System.Drawing.Size(165, 23);
            this.textBoxShopOptionsTel.TabIndex = 29;
            // 
            // labelShopOptionsTel
            // 
            this.labelShopOptionsTel.AutoSize = true;
            this.labelShopOptionsTel.Location = new System.Drawing.Point(339, 64);
            this.labelShopOptionsTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsTel.Name = "labelShopOptionsTel";
            this.labelShopOptionsTel.Size = new System.Drawing.Size(22, 15);
            this.labelShopOptionsTel.TabIndex = 28;
            this.labelShopOptionsTel.Text = "Tel";
            // 
            // textBoxShopOptionsEmail
            // 
            this.textBoxShopOptionsEmail.Location = new System.Drawing.Point(377, 92);
            this.textBoxShopOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsEmail.Name = "textBoxShopOptionsEmail";
            this.textBoxShopOptionsEmail.Size = new System.Drawing.Size(165, 23);
            this.textBoxShopOptionsEmail.TabIndex = 31;
            // 
            // labelShopOptionsEmail
            // 
            this.labelShopOptionsEmail.AutoSize = true;
            this.labelShopOptionsEmail.Location = new System.Drawing.Point(319, 97);
            this.labelShopOptionsEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsEmail.Name = "labelShopOptionsEmail";
            this.labelShopOptionsEmail.Size = new System.Drawing.Size(42, 15);
            this.labelShopOptionsEmail.TabIndex = 30;
            this.labelShopOptionsEmail.Text = "E-mail";
            // 
            // textBoxShopOptionsWeb
            // 
            this.textBoxShopOptionsWeb.Location = new System.Drawing.Point(377, 125);
            this.textBoxShopOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxShopOptionsWeb.Name = "textBoxShopOptionsWeb";
            this.textBoxShopOptionsWeb.Size = new System.Drawing.Size(165, 23);
            this.textBoxShopOptionsWeb.TabIndex = 33;
            // 
            // labelShopOptionsWeb
            // 
            this.labelShopOptionsWeb.AutoSize = true;
            this.labelShopOptionsWeb.Location = new System.Drawing.Point(329, 130);
            this.labelShopOptionsWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopOptionsWeb.Name = "labelShopOptionsWeb";
            this.labelShopOptionsWeb.Size = new System.Drawing.Size(32, 15);
            this.labelShopOptionsWeb.TabIndex = 32;
            this.labelShopOptionsWeb.Text = "Web";
            // 
            // buttonNewShop
            // 
            this.buttonNewShop.Location = new System.Drawing.Point(164, 162);
            this.buttonNewShop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewShop.Name = "buttonNewShop";
            this.buttonNewShop.Size = new System.Drawing.Size(88, 27);
            this.buttonNewShop.TabIndex = 34;
            this.buttonNewShop.Text = "New";
            this.buttonNewShop.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1315, 768);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 27);
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 809);
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
        private System.Windows.Forms.TextBox textBoxShopOptionsShopName;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}