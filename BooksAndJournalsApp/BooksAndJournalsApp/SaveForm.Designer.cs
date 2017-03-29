namespace Forms
{
    partial class SaveForm
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblBooks = new System.Windows.Forms.Label();
            this.LblJournals = new System.Windows.Forms.Label();
            this.LblNewspapers = new System.Windows.Forms.Label();
            this.DrpBoxBooks = new System.Windows.Forms.ComboBox();
            this.DrpBoxJournals = new System.Windows.Forms.ComboBox();
            this.DrpBoxNewspapers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(113, 197);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save All";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblBooks
            // 
            this.LblBooks.AutoSize = true;
            this.LblBooks.Location = new System.Drawing.Point(24, 39);
            this.LblBooks.Name = "LblBooks";
            this.LblBooks.Size = new System.Drawing.Size(37, 13);
            this.LblBooks.TabIndex = 1;
            this.LblBooks.Text = "Books";
            // 
            // LblJournals
            // 
            this.LblJournals.AutoSize = true;
            this.LblJournals.Location = new System.Drawing.Point(24, 84);
            this.LblJournals.Name = "LblJournals";
            this.LblJournals.Size = new System.Drawing.Size(46, 13);
            this.LblJournals.TabIndex = 2;
            this.LblJournals.Text = "Journals";
            // 
            // LblNewspapers
            // 
            this.LblNewspapers.AutoSize = true;
            this.LblNewspapers.Location = new System.Drawing.Point(24, 126);
            this.LblNewspapers.Name = "LblNewspapers";
            this.LblNewspapers.Size = new System.Drawing.Size(66, 13);
            this.LblNewspapers.TabIndex = 3;
            this.LblNewspapers.Text = "Newspapers";
            // 
            // DrpBoxBooks
            // 
            this.DrpBoxBooks.FormattingEnabled = true;
            this.DrpBoxBooks.Location = new System.Drawing.Point(113, 36);
            this.DrpBoxBooks.Name = "DrpBoxBooks";
            this.DrpBoxBooks.Size = new System.Drawing.Size(86, 21);
            this.DrpBoxBooks.TabIndex = 4;
            this.DrpBoxBooks.SelectedIndexChanged += new System.EventHandler(this.EnableBtnSave);
            // 
            // DrpBoxJournals
            // 
            this.DrpBoxJournals.FormattingEnabled = true;
            this.DrpBoxJournals.Location = new System.Drawing.Point(113, 81);
            this.DrpBoxJournals.Name = "DrpBoxJournals";
            this.DrpBoxJournals.Size = new System.Drawing.Size(86, 21);
            this.DrpBoxJournals.TabIndex = 5;
            this.DrpBoxJournals.SelectedIndexChanged += new System.EventHandler(this.EnableBtnSave);
            // 
            // DrpBoxNewspapers
            // 
            this.DrpBoxNewspapers.FormattingEnabled = true;
            this.DrpBoxNewspapers.Location = new System.Drawing.Point(113, 123);
            this.DrpBoxNewspapers.Name = "DrpBoxNewspapers";
            this.DrpBoxNewspapers.Size = new System.Drawing.Size(86, 21);
            this.DrpBoxNewspapers.TabIndex = 6;
            this.DrpBoxNewspapers.SelectedIndexChanged += new System.EventHandler(this.EnableBtnSave);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 290);
            this.Controls.Add(this.DrpBoxNewspapers);
            this.Controls.Add(this.DrpBoxJournals);
            this.Controls.Add(this.DrpBoxBooks);
            this.Controls.Add(this.LblNewspapers);
            this.Controls.Add(this.LblJournals);
            this.Controls.Add(this.LblBooks);
            this.Controls.Add(this.BtnSave);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblBooks;
        private System.Windows.Forms.Label LblJournals;
        private System.Windows.Forms.Label LblNewspapers;
        private System.Windows.Forms.ComboBox DrpBoxBooks;
        private System.Windows.Forms.ComboBox DrpBoxJournals;
        private System.Windows.Forms.ComboBox DrpBoxNewspapers;
    }
}