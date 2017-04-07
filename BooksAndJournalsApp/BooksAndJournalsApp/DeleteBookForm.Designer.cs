namespace Forms
{
    partial class DeleteBookForm
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
            this.DGVContentViewer = new System.Windows.Forms.DataGridView();
            this.BtnDeleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVContentViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVContentViewer
            // 
            this.DGVContentViewer.AllowUserToAddRows = false;
            this.DGVContentViewer.AllowUserToDeleteRows = false;
            this.DGVContentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVContentViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVContentViewer.Location = new System.Drawing.Point(12, 38);
            this.DGVContentViewer.Name = "DGVContentViewer";
            this.DGVContentViewer.ReadOnly = true;
            this.DGVContentViewer.Size = new System.Drawing.Size(551, 353);
            this.DGVContentViewer.TabIndex = 0;
            // 
            // BtnDeleteRow
            // 
            this.BtnDeleteRow.Location = new System.Drawing.Point(12, 12);
            this.BtnDeleteRow.Name = "BtnDeleteRow";
            this.BtnDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteRow.TabIndex = 1;
            this.BtnDeleteRow.Text = "Delete";
            this.BtnDeleteRow.UseVisualStyleBackColor = true;
            this.BtnDeleteRow.Click += new System.EventHandler(this.BtnDeleteRow_Click);
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 403);
            this.Controls.Add(this.BtnDeleteRow);
            this.Controls.Add(this.DGVContentViewer);
            this.Name = "DeleteBookForm";
            this.Text = "DeleteBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVContentViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVContentViewer;
        private System.Windows.Forms.Button BtnDeleteRow;
    }
}