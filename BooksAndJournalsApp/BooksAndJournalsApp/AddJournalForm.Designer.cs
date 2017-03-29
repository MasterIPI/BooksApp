namespace Forms
{
    partial class AddJournalForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.BoxTitle = new System.Windows.Forms.TextBox();
            this.BoxYear = new System.Windows.Forms.TextBox();
            this.BoxAuthor = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxArticle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add journal with only 1 author and 1 article";
            // 
            // BoxTitle
            // 
            this.BoxTitle.Location = new System.Drawing.Point(70, 92);
            this.BoxTitle.Name = "BoxTitle";
            this.BoxTitle.Size = new System.Drawing.Size(100, 20);
            this.BoxTitle.TabIndex = 14;
            // 
            // BoxYear
            // 
            this.BoxYear.Location = new System.Drawing.Point(70, 66);
            this.BoxYear.Name = "BoxYear";
            this.BoxYear.Size = new System.Drawing.Size(100, 20);
            this.BoxYear.TabIndex = 13;
            this.BoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxYear_KeyPress);
            // 
            // BoxAuthor
            // 
            this.BoxAuthor.Location = new System.Drawing.Point(70, 40);
            this.BoxAuthor.Name = "BoxAuthor";
            this.BoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.BoxAuthor.TabIndex = 12;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(95, 160);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.AddJournal);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Birth year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author";
            // 
            // BoxArticle
            // 
            this.BoxArticle.Location = new System.Drawing.Point(70, 118);
            this.BoxArticle.Name = "BoxArticle";
            this.BoxArticle.Size = new System.Drawing.Size(100, 20);
            this.BoxArticle.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Article";
            // 
            // AddJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BoxArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxTitle);
            this.Controls.Add(this.BoxYear);
            this.Controls.Add(this.BoxAuthor);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddJournalForm";
            this.Text = "AddJournalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxTitle;
        private System.Windows.Forms.TextBox BoxYear;
        private System.Windows.Forms.TextBox BoxAuthor;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxArticle;
        private System.Windows.Forms.Label label5;
    }
}