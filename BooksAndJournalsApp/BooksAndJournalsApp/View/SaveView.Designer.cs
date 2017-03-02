namespace BooksAndJournalsApp
{
    partial class SaveView
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.bookslbl = new System.Windows.Forms.Label();
            this.journalslbl = new System.Windows.Forms.Label();
            this.newspaperslbl = new System.Windows.Forms.Label();
            this.booksBox = new System.Windows.Forms.ComboBox();
            this.journalsBox = new System.Windows.Forms.ComboBox();
            this.newspapersBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(113, 197);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save All";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bookslbl
            // 
            this.bookslbl.AutoSize = true;
            this.bookslbl.Location = new System.Drawing.Point(24, 39);
            this.bookslbl.Name = "bookslbl";
            this.bookslbl.Size = new System.Drawing.Size(37, 13);
            this.bookslbl.TabIndex = 1;
            this.bookslbl.Text = "Books";
            // 
            // journalslbl
            // 
            this.journalslbl.AutoSize = true;
            this.journalslbl.Location = new System.Drawing.Point(24, 84);
            this.journalslbl.Name = "journalslbl";
            this.journalslbl.Size = new System.Drawing.Size(46, 13);
            this.journalslbl.TabIndex = 2;
            this.journalslbl.Text = "Journals";
            // 
            // newspaperslbl
            // 
            this.newspaperslbl.AutoSize = true;
            this.newspaperslbl.Location = new System.Drawing.Point(24, 126);
            this.newspaperslbl.Name = "newspaperslbl";
            this.newspaperslbl.Size = new System.Drawing.Size(66, 13);
            this.newspaperslbl.TabIndex = 3;
            this.newspaperslbl.Text = "Newspapers";
            // 
            // booksBox
            // 
            this.booksBox.FormattingEnabled = true;
            this.booksBox.Location = new System.Drawing.Point(113, 36);
            this.booksBox.Name = "booksBox";
            this.booksBox.Size = new System.Drawing.Size(86, 21);
            this.booksBox.TabIndex = 4;
            this.booksBox.SelectedIndexChanged += new System.EventHandler(this.EnableSaveBtn);
            // 
            // journalsBox
            // 
            this.journalsBox.FormattingEnabled = true;
            this.journalsBox.Location = new System.Drawing.Point(113, 81);
            this.journalsBox.Name = "journalsBox";
            this.journalsBox.Size = new System.Drawing.Size(86, 21);
            this.journalsBox.TabIndex = 5;
            this.journalsBox.SelectedIndexChanged += new System.EventHandler(this.EnableSaveBtn);
            // 
            // newspapersBox
            // 
            this.newspapersBox.FormattingEnabled = true;
            this.newspapersBox.Location = new System.Drawing.Point(113, 123);
            this.newspapersBox.Name = "newspapersBox";
            this.newspapersBox.Size = new System.Drawing.Size(86, 21);
            this.newspapersBox.TabIndex = 6;
            this.newspapersBox.SelectedIndexChanged += new System.EventHandler(this.EnableSaveBtn);
            // 
            // SaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 290);
            this.Controls.Add(this.newspapersBox);
            this.Controls.Add(this.journalsBox);
            this.Controls.Add(this.booksBox);
            this.Controls.Add(this.newspaperslbl);
            this.Controls.Add(this.journalslbl);
            this.Controls.Add(this.bookslbl);
            this.Controls.Add(this.saveBtn);
            this.Name = "SaveView";
            this.Text = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label bookslbl;
        private System.Windows.Forms.Label journalslbl;
        private System.Windows.Forms.Label newspaperslbl;
        private System.Windows.Forms.ComboBox booksBox;
        private System.Windows.Forms.ComboBox journalsBox;
        private System.Windows.Forms.ComboBox newspapersBox;
    }
}