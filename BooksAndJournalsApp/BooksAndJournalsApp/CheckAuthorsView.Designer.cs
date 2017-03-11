namespace Forms.View
{
    partial class CheckAuthorsView
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
            this.MatchedBox = new System.Windows.Forms.ComboBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MatchedBox
            // 
            this.MatchedBox.FormattingEnabled = true;
            this.MatchedBox.Location = new System.Drawing.Point(12, 39);
            this.MatchedBox.Name = "MatchedBox";
            this.MatchedBox.Size = new System.Drawing.Size(260, 21);
            this.MatchedBox.TabIndex = 0;
            this.MatchedBox.SelectedIndexChanged += new System.EventHandler(this.MatchedBox_SelectedIndexChanged);
            // 
            // YesBtn
            // 
            this.YesBtn.Enabled = false;
            this.YesBtn.Location = new System.Drawing.Point(12, 78);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(75, 23);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.Enabled = false;
            this.NoBtn.Location = new System.Drawing.Point(197, 78);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(75, 23);
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Is this author is a someone from this list?";
            // 
            // CheckAuthorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.MatchedBox);
            this.Name = "CheckAuthorsView";
            this.Text = "CheckAuthorsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MatchedBox;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Label label1;
    }
}