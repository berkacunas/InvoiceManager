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
            this.groupBoxShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.groupBoxShopTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShopTypes)).BeginInit();
            this.groupBoxItemTopGroupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShops
            // 
            this.groupBoxShops.Controls.Add(this.dataGridViewShops);
            this.groupBoxShops.Location = new System.Drawing.Point(12, 12);
            this.groupBoxShops.Name = "groupBoxShops";
            this.groupBoxShops.Size = new System.Drawing.Size(953, 513);
            this.groupBoxShops.TabIndex = 0;
            this.groupBoxShops.TabStop = false;
            this.groupBoxShops.Text = "Shops";
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.Size = new System.Drawing.Size(941, 487);
            this.dataGridViewShops.TabIndex = 0;
            // 
            // groupBoxShopTypes
            // 
            this.groupBoxShopTypes.Controls.Add(this.dataGridViewShopTypes);
            this.groupBoxShopTypes.Location = new System.Drawing.Point(978, 12);
            this.groupBoxShopTypes.Name = "groupBoxShopTypes";
            this.groupBoxShopTypes.Size = new System.Drawing.Size(222, 513);
            this.groupBoxShopTypes.TabIndex = 1;
            this.groupBoxShopTypes.TabStop = false;
            this.groupBoxShopTypes.Text = "Edit shop type...";
            // 
            // dataGridViewShopTypes
            // 
            this.dataGridViewShopTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShopTypes.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewShopTypes.Name = "dataGridViewShopTypes";
            this.dataGridViewShopTypes.Size = new System.Drawing.Size(210, 487);
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
            this.groupBoxItemTopGroupOptions.Location = new System.Drawing.Point(867, 531);
            this.groupBoxItemTopGroupOptions.Name = "groupBoxItemTopGroupOptions";
            this.groupBoxItemTopGroupOptions.Size = new System.Drawing.Size(333, 88);
            this.groupBoxItemTopGroupOptions.TabIndex = 13;
            this.groupBoxItemTopGroupOptions.TabStop = false;
            this.groupBoxItemTopGroupOptions.Text = "Shop Type Options";
            // 
            // comboBoxShopTypeOptionsShopType
            // 
            this.comboBoxShopTypeOptionsShopType.FormattingEnabled = true;
            this.comboBoxShopTypeOptionsShopType.Location = new System.Drawing.Point(80, 24);
            this.comboBoxShopTypeOptionsShopType.Name = "comboBoxShopTypeOptionsShopType";
            this.comboBoxShopTypeOptionsShopType.Size = new System.Drawing.Size(240, 21);
            this.comboBoxShopTypeOptionsShopType.TabIndex = 12;
            // 
            // buttonNewShopType
            // 
            this.buttonNewShopType.Location = new System.Drawing.Point(80, 53);
            this.buttonNewShopType.Name = "buttonNewShopType";
            this.buttonNewShopType.Size = new System.Drawing.Size(55, 23);
            this.buttonNewShopType.TabIndex = 11;
            this.buttonNewShopType.Text = "New";
            this.buttonNewShopType.UseVisualStyleBackColor = true;
            // 
            // labelShopTypeOptionsShopType
            // 
            this.labelShopTypeOptionsShopType.AutoSize = true;
            this.labelShopTypeOptionsShopType.Location = new System.Drawing.Point(11, 29);
            this.labelShopTypeOptionsShopType.Name = "labelShopTypeOptionsShopType";
            this.labelShopTypeOptionsShopType.Size = new System.Drawing.Size(59, 13);
            this.labelShopTypeOptionsShopType.TabIndex = 9;
            this.labelShopTypeOptionsShopType.Text = "Shop Type";
            // 
            // buttonDeleteShopType
            // 
            this.buttonDeleteShopType.Location = new System.Drawing.Point(263, 53);
            this.buttonDeleteShopType.Name = "buttonDeleteShopType";
            this.buttonDeleteShopType.Size = new System.Drawing.Size(55, 23);
            this.buttonDeleteShopType.TabIndex = 8;
            this.buttonDeleteShopType.Text = "Delete";
            this.buttonDeleteShopType.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateShopType
            // 
            this.buttonUpdateShopType.Location = new System.Drawing.Point(202, 53);
            this.buttonUpdateShopType.Name = "buttonUpdateShopType";
            this.buttonUpdateShopType.Size = new System.Drawing.Size(55, 23);
            this.buttonUpdateShopType.TabIndex = 7;
            this.buttonUpdateShopType.Text = "Update";
            this.buttonUpdateShopType.UseVisualStyleBackColor = true;
            // 
            // buttonSaveShopType
            // 
            this.buttonSaveShopType.Location = new System.Drawing.Point(141, 53);
            this.buttonSaveShopType.Name = "buttonSaveShopType";
            this.buttonSaveShopType.Size = new System.Drawing.Size(55, 23);
            this.buttonSaveShopType.TabIndex = 6;
            this.buttonSaveShopType.Text = "Save";
            this.buttonSaveShopType.UseVisualStyleBackColor = true;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 805);
            this.Controls.Add(this.groupBoxItemTopGroupOptions);
            this.Controls.Add(this.groupBoxShopTypes);
            this.Controls.Add(this.groupBoxShops);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
            this.ResumeLayout(false);

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
    }
}