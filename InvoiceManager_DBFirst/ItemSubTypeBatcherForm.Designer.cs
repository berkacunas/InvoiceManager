namespace InvoiceManager_DBFirst
{
    partial class ItemSubTypeBatcherForm
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
            this.buttonBatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBatch
            // 
            this.buttonBatch.Location = new System.Drawing.Point(65, 51);
            this.buttonBatch.Name = "buttonBatch";
            this.buttonBatch.Size = new System.Drawing.Size(75, 23);
            this.buttonBatch.TabIndex = 0;
            this.buttonBatch.Text = "Batch";
            this.buttonBatch.UseVisualStyleBackColor = true;
            this.buttonBatch.Click += new System.EventHandler(this.buttonBatch_Click);
            // 
            // ItemSubTypeBatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 118);
            this.Controls.Add(this.buttonBatch);
            this.Name = "ItemSubTypeBatcherForm";
            this.Text = "ItemSubTypeBatcherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBatch;
    }
}