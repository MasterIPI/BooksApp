namespace Forms
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
            this.DGVPublishedEditionViewer = new System.Windows.Forms.DataGridView();
            this.BtnAuthorsWorks = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DropBoxTypes = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LstBoxArticle = new System.Windows.Forms.ListBox();
            this.DGVAuthorsViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPublishedEditionViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthorsViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPublishedEditionViewer
            // 
            this.DGVPublishedEditionViewer.AllowUserToAddRows = false;
            this.DGVPublishedEditionViewer.AllowUserToDeleteRows = false;
            this.DGVPublishedEditionViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVPublishedEditionViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPublishedEditionViewer.Location = new System.Drawing.Point(12, 36);
            this.DGVPublishedEditionViewer.MultiSelect = false;
            this.DGVPublishedEditionViewer.Name = "DGVPublishedEditionViewer";
            this.DGVPublishedEditionViewer.ReadOnly = true;
            this.DGVPublishedEditionViewer.Size = new System.Drawing.Size(496, 471);
            this.DGVPublishedEditionViewer.TabIndex = 0;
            this.DGVPublishedEditionViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPublishedEditionViewer_CellClick);
            // 
            // BtnAuthorsWorks
            // 
            this.BtnAuthorsWorks.Location = new System.Drawing.Point(139, 7);
            this.BtnAuthorsWorks.Name = "BtnAuthorsWorks";
            this.BtnAuthorsWorks.Size = new System.Drawing.Size(112, 23);
            this.BtnAuthorsWorks.TabIndex = 2;
            this.BtnAuthorsWorks.Text = "View Authors works";
            this.BtnAuthorsWorks.UseVisualStyleBackColor = true;
            this.BtnAuthorsWorks.Click += new System.EventHandler(this.BtnAuthorsWorks_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(750, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DropBoxTypes
            // 
            this.DropBoxTypes.FormattingEnabled = true;
            this.DropBoxTypes.Location = new System.Drawing.Point(12, 9);
            this.DropBoxTypes.Name = "DropBoxTypes";
            this.DropBoxTypes.Size = new System.Drawing.Size(121, 21);
            this.DropBoxTypes.TabIndex = 4;
            this.DropBoxTypes.SelectedIndexChanged += new System.EventHandler(this.DropBoxTypes_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(352, 7);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(433, 7);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LstBoxArticle
            // 
            this.LstBoxArticle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstBoxArticle.FormattingEnabled = true;
            this.LstBoxArticle.Location = new System.Drawing.Point(514, 36);
            this.LstBoxArticle.Name = "LstBoxArticle";
            this.LstBoxArticle.Size = new System.Drawing.Size(310, 238);
            this.LstBoxArticle.TabIndex = 8;
            this.LstBoxArticle.SelectedIndexChanged += new System.EventHandler(this.LstBoxArticle_SelectedIndexChanged);
            // 
            // DGVAuthorsViewer
            // 
            this.DGVAuthorsViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVAuthorsViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAuthorsViewer.Location = new System.Drawing.Point(514, 280);
            this.DGVAuthorsViewer.Name = "DGVAuthorsViewer";
            this.DGVAuthorsViewer.Size = new System.Drawing.Size(310, 227);
            this.DGVAuthorsViewer.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 519);
            this.Controls.Add(this.DGVAuthorsViewer);
            this.Controls.Add(this.LstBoxArticle);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DropBoxTypes);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAuthorsWorks);
            this.Controls.Add(this.DGVPublishedEditionViewer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPublishedEditionViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthorsViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPublishedEditionViewer;
        private System.Windows.Forms.Button BtnAuthorsWorks;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox DropBoxTypes;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListBox LstBoxArticle;
        private System.Windows.Forms.DataGridView DGVAuthorsViewer;
    }
}

