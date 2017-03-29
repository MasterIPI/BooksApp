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
            this.LstBoxSearchResultsView = new System.Windows.Forms.ListBox();
            this.DGVAuthors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // LstBoxSearchResultsView
            // 
            this.LstBoxSearchResultsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstBoxSearchResultsView.FormattingEnabled = true;
            this.LstBoxSearchResultsView.Location = new System.Drawing.Point(288, 13);
            this.LstBoxSearchResultsView.Name = "LstBoxSearchResultsView";
            this.LstBoxSearchResultsView.Size = new System.Drawing.Size(309, 290);
            this.LstBoxSearchResultsView.TabIndex = 3;
            // 
            // DGVAuthors
            // 
            this.DGVAuthors.AllowUserToAddRows = false;
            this.DGVAuthors.AllowUserToDeleteRows = false;
            this.DGVAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAuthors.Location = new System.Drawing.Point(12, 12);
            this.DGVAuthors.Name = "DGVAuthors";
            this.DGVAuthors.ReadOnly = true;
            this.DGVAuthors.Size = new System.Drawing.Size(270, 291);
            this.DGVAuthors.TabIndex = 5;
            this.DGVAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAuthors_CellClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 316);
            this.Controls.Add(this.DGVAuthors);
            this.Controls.Add(this.LstBoxSearchResultsView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox LstBoxSearchResultsView;
        private System.Windows.Forms.DataGridView DGVAuthors;
    }
}