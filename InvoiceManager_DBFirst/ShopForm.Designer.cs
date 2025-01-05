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
            this.groupBoxShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxShops
            // 
            this.groupBoxShops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxShops.Controls.Add(this.dataGridViewShops);
            this.groupBoxShops.Location = new System.Drawing.Point(12, 12);
            this.groupBoxShops.Name = "groupBoxShops";
            this.groupBoxShops.Size = new System.Drawing.Size(1158, 370);
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
            this.dataGridViewShops.Size = new System.Drawing.Size(1146, 345);
            this.dataGridViewShops.TabIndex = 0;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 772);
            this.Controls.Add(this.groupBoxShops);
            this.Name = "ShopForm";
            this.Text = "Edit Shops...";
            this.groupBoxShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShops;
        private System.Windows.Forms.DataGridView dataGridViewShops;
    }
}