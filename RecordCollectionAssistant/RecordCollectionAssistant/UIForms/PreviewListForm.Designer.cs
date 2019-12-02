namespace RecordCollectionAssistant
{
    partial class PreviewListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewListForm));
            this.recordListView = new System.Windows.Forms.ListView();
            this.recordName_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artist_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearReleased_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.condition_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentValue_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_collection = new System.Windows.Forms.Label();
            this.lbl_collectionSizeDisplay = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.lbl_userCollectionDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recordListView
            // 
            this.recordListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.recordListView.AllowColumnReorder = true;
            this.recordListView.BackColor = System.Drawing.Color.DimGray;
            this.recordListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recordName_header,
            this.artist_header,
            this.yearReleased_header,
            this.condition_header,
            this.currentValue_header});
            this.recordListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordListView.ForeColor = System.Drawing.Color.Transparent;
            this.recordListView.FullRowSelect = true;
            this.recordListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.recordListView.Location = new System.Drawing.Point(29, 105);
            this.recordListView.MultiSelect = false;
            this.recordListView.Name = "recordListView";
            this.recordListView.Size = new System.Drawing.Size(954, 591);
            this.recordListView.TabIndex = 14;
            this.recordListView.UseCompatibleStateImageBehavior = false;
            this.recordListView.View = System.Windows.Forms.View.Details;
            // 
            // recordName_header
            // 
            this.recordName_header.Text = "Record Name";
            this.recordName_header.Width = 221;
            // 
            // artist_header
            // 
            this.artist_header.Text = "Artist";
            this.artist_header.Width = 194;
            // 
            // yearReleased_header
            // 
            this.yearReleased_header.Text = "Year Released";
            this.yearReleased_header.Width = 154;
            // 
            // condition_header
            // 
            this.condition_header.Text = "Condition (Media / Sleeve)";
            this.condition_header.Width = 276;
            // 
            // currentValue_header
            // 
            this.currentValue_header.Text = "Current Value";
            this.currentValue_header.Width = 336;
            // 
            // lbl_collection
            // 
            this.lbl_collection.AutoSize = true;
            this.lbl_collection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_collection.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_collection.Location = new System.Drawing.Point(25, 71);
            this.lbl_collection.Name = "lbl_collection";
            this.lbl_collection.Size = new System.Drawing.Size(163, 21);
            this.lbl_collection.TabIndex = 17;
            this.lbl_collection.Text = "Records in Collection: ";
            // 
            // lbl_collectionSizeDisplay
            // 
            this.lbl_collectionSizeDisplay.AutoSize = true;
            this.lbl_collectionSizeDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_collectionSizeDisplay.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_collectionSizeDisplay.Location = new System.Drawing.Point(194, 71);
            this.lbl_collectionSizeDisplay.Name = "lbl_collectionSizeDisplay";
            this.lbl_collectionSizeDisplay.Size = new System.Drawing.Size(79, 21);
            this.lbl_collectionSizeDisplay.TabIndex = 18;
            this.lbl_collectionSizeDisplay.Text = "0 Records";
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit_btn.FlatAppearance.BorderSize = 2;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Transparent;
            this.exit_btn.Location = new System.Drawing.Point(884, 25);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(99, 52);
            this.exit_btn.TabIndex = 20;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lbl_userCollectionDisplay
            // 
            this.lbl_userCollectionDisplay.AutoSize = true;
            this.lbl_userCollectionDisplay.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lbl_userCollectionDisplay.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_userCollectionDisplay.Location = new System.Drawing.Point(23, 25);
            this.lbl_userCollectionDisplay.Name = "lbl_userCollectionDisplay";
            this.lbl_userCollectionDisplay.Size = new System.Drawing.Size(183, 31);
            this.lbl_userCollectionDisplay.TabIndex = 19;
            this.lbl_userCollectionDisplay.Text = "User\'s Collection";
            // 
            // PreviewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.lbl_userCollectionDisplay);
            this.Controls.Add(this.lbl_collectionSizeDisplay);
            this.Controls.Add(this.lbl_collection);
            this.Controls.Add(this.recordListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewListForm";
            this.Text = "PreviewListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView recordListView;
        private System.Windows.Forms.ColumnHeader recordName_header;
        private System.Windows.Forms.ColumnHeader artist_header;
        private System.Windows.Forms.ColumnHeader yearReleased_header;
        private System.Windows.Forms.ColumnHeader condition_header;
        private System.Windows.Forms.ColumnHeader currentValue_header;
        private System.Windows.Forms.Label lbl_collection;
        private System.Windows.Forms.Label lbl_collectionSizeDisplay;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label lbl_userCollectionDisplay;
    }
}