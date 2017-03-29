namespace Forms
{
    partial class AddBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BoxAuthor = new System.Windows.Forms.TextBox();
            this.BoxYear = new System.Windows.Forms.TextBox();
            this.BoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birth year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(95, 114);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.AddBook);
            // 
            // BoxAuthor
            // 
            this.BoxAuthor.Location = new System.Drawing.Point(70, 36);
            this.BoxAuthor.Name = "BoxAuthor";
            this.BoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.BoxAuthor.TabIndex = 4;
            // 
            // BoxYear
            // 
            this.BoxYear.Location = new System.Drawing.Point(70, 62);
            this.BoxYear.Name = "BoxYear";
            this.BoxYear.Size = new System.Drawing.Size(100, 20);
            this.BoxYear.TabIndex = 5;
            this.BoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxYear_KeyPress);
            // 
            // BoxTitle
            // 
            this.BoxTitle.Location = new System.Drawing.Point(70, 88);
            this.BoxTitle.Name = "BoxTitle";
            this.BoxTitle.Size = new System.Drawing.Size(100, 20);
            this.BoxTitle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add book with only 1 author";
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 233);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxTitle);
            this.Controls.Add(this.BoxYear);
            this.Controls.Add(this.BoxAuthor);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddBook";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox BoxAuthor;
        private System.Windows.Forms.TextBox BoxYear;
        private System.Windows.Forms.TextBox BoxTitle;
        private System.Windows.Forms.Label label4;
    }
}