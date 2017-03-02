namespace BooksAndJournalsApp
{
    partial class MainView
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
            this.ContainerViewer = new System.Windows.Forms.DataGridView();
            this.authorsWorksBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.containerBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerViewer
            // 
            this.ContainerViewer.AllowUserToAddRows = false;
            this.ContainerViewer.AllowUserToDeleteRows = false;
            this.ContainerViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.ContainerViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContainerViewer.Location = new System.Drawing.Point(12, 36);
            this.ContainerViewer.MultiSelect = false;
            this.ContainerViewer.Name = "ContainerViewer";
            this.ContainerViewer.Size = new System.Drawing.Size(813, 489);
            this.ContainerViewer.TabIndex = 0;
            // 
            // authorsWorksBtn
            // 
            this.authorsWorksBtn.Location = new System.Drawing.Point(139, 7);
            this.authorsWorksBtn.Name = "authorsWorksBtn";
            this.authorsWorksBtn.Size = new System.Drawing.Size(112, 23);
            this.authorsWorksBtn.TabIndex = 2;
            this.authorsWorksBtn.Text = "View Authors works";
            this.authorsWorksBtn.UseVisualStyleBackColor = true;
            this.authorsWorksBtn.Click += new System.EventHandler(this.authorsWorksBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(750, 7);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // containerBox
            // 
            this.containerBox.FormattingEnabled = true;
            this.containerBox.Location = new System.Drawing.Point(12, 9);
            this.containerBox.Name = "containerBox";
            this.containerBox.Size = new System.Drawing.Size(121, 21);
            this.containerBox.TabIndex = 4;
            this.containerBox.SelectedIndexChanged += new System.EventHandler(this.containerBox_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(352, 7);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(433, 7);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(75, 23);
            this.dltBtn.TabIndex = 6;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 537);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.containerBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.authorsWorksBtn);
            this.Controls.Add(this.ContainerViewer);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ContainerViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ContainerViewer;
        private System.Windows.Forms.Button authorsWorksBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox containerBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button dltBtn;
    }
}

