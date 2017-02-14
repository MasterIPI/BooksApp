namespace BooksAndJournalsApp
{
    partial class MainForm
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
            this.BookViewer = new System.Windows.Forms.DataGridView();
            this.JournalViewer = new System.Windows.Forms.DataGridView();
            this.authorsWorksBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // BookViewer
            // 
            this.BookViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookViewer.Location = new System.Drawing.Point(12, 36);
            this.BookViewer.Name = "BookViewer";
            this.BookViewer.Size = new System.Drawing.Size(395, 489);
            this.BookViewer.TabIndex = 0;
            // 
            // JournalViewer
            // 
            this.JournalViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalViewer.Location = new System.Drawing.Point(430, 36);
            this.JournalViewer.Name = "JournalViewer";
            this.JournalViewer.Size = new System.Drawing.Size(395, 489);
            this.JournalViewer.TabIndex = 1;
            // 
            // authorsWorksBtn
            // 
            this.authorsWorksBtn.Location = new System.Drawing.Point(12, 7);
            this.authorsWorksBtn.Name = "authorsWorksBtn";
            this.authorsWorksBtn.Size = new System.Drawing.Size(112, 23);
            this.authorsWorksBtn.TabIndex = 2;
            this.authorsWorksBtn.Text = "View Authors works";
            this.authorsWorksBtn.UseVisualStyleBackColor = true;
            this.authorsWorksBtn.Click += new System.EventHandler(this.authorsWorksBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(430, 7);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 537);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.authorsWorksBtn);
            this.Controls.Add(this.JournalViewer);
            this.Controls.Add(this.BookViewer);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BookViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookViewer;
        private System.Windows.Forms.DataGridView JournalViewer;
        private System.Windows.Forms.Button authorsWorksBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}

