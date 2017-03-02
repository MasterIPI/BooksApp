namespace BooksAndJournalsApp
{
    partial class SearchView
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
            this.AuthorsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResultsView = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorsBox
            // 
            this.AuthorsBox.FormattingEnabled = true;
            this.AuthorsBox.Location = new System.Drawing.Point(56, 12);
            this.AuthorsBox.Name = "AuthorsBox";
            this.AuthorsBox.Size = new System.Drawing.Size(418, 21);
            this.AuthorsBox.TabIndex = 0;
            this.AuthorsBox.SelectedIndexChanged += new System.EventHandler(this.AuthorsBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author";
            // 
            // searchResultsView
            // 
            this.searchResultsView.FormattingEnabled = true;
            this.searchResultsView.Location = new System.Drawing.Point(12, 39);
            this.searchResultsView.Name = "searchResultsView";
            this.searchResultsView.Size = new System.Drawing.Size(585, 212);
            this.searchResultsView.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(504, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 261);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchResultsView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorsBox);
            this.Name = "SearchForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AuthorsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchResultsView;
        private System.Windows.Forms.Button searchBtn;
    }
}