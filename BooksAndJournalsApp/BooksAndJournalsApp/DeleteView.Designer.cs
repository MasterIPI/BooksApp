namespace Forms
{
    partial class DeleteView
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
            this.ContentViewer = new System.Windows.Forms.DataGridView();
            this.dltRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContentViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentViewer
            // 
            this.ContentViewer.AllowUserToAddRows = false;
            this.ContentViewer.AllowUserToDeleteRows = false;
            this.ContentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContentViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ContentViewer.Location = new System.Drawing.Point(12, 38);
            this.ContentViewer.Name = "ContentViewer";
            this.ContentViewer.ReadOnly = true;
            this.ContentViewer.Size = new System.Drawing.Size(551, 353);
            this.ContentViewer.TabIndex = 0;
            // 
            // dltRowBtn
            // 
            this.dltRowBtn.Location = new System.Drawing.Point(12, 12);
            this.dltRowBtn.Name = "dltRowBtn";
            this.dltRowBtn.Size = new System.Drawing.Size(75, 23);
            this.dltRowBtn.TabIndex = 1;
            this.dltRowBtn.Text = "Delete";
            this.dltRowBtn.UseVisualStyleBackColor = true;
            this.dltRowBtn.Click += new System.EventHandler(this.dltRowBtn_Click);
            // 
            // DeleteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 403);
            this.Controls.Add(this.dltRowBtn);
            this.Controls.Add(this.ContentViewer);
            this.Name = "DeleteView";
            this.Text = "DeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.ContentViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ContentViewer;
        private System.Windows.Forms.Button dltRowBtn;
    }
}