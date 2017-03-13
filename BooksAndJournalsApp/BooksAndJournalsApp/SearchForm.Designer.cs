namespace Forms
{
    partial class SearchForm
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
            this.searchResultsView = new System.Windows.Forms.ListBox();
            this.AuthorsGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResultsView
            // 
            this.searchResultsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsView.FormattingEnabled = true;
            this.searchResultsView.Location = new System.Drawing.Point(288, 13);
            this.searchResultsView.Name = "searchResultsView";
            this.searchResultsView.Size = new System.Drawing.Size(309, 290);
            this.searchResultsView.TabIndex = 3;
            // 
            // AuthorsGV
            // 
            this.AuthorsGV.AllowUserToAddRows = false;
            this.AuthorsGV.AllowUserToDeleteRows = false;
            this.AuthorsGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsGV.Location = new System.Drawing.Point(12, 12);
            this.AuthorsGV.Name = "AuthorsGV";
            this.AuthorsGV.ReadOnly = true;
            this.AuthorsGV.Size = new System.Drawing.Size(270, 291);
            this.AuthorsGV.TabIndex = 5;
            this.AuthorsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsGV_CellClick);
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 316);
            this.Controls.Add(this.AuthorsGV);
            this.Controls.Add(this.searchResultsView);
            this.Name = "SearchView";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox searchResultsView;
        private System.Windows.Forms.DataGridView AuthorsGV;
    }
}