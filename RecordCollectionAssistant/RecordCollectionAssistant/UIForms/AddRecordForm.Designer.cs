namespace RecordCollectionAssistant.UIForms
{
    partial class AddRecordForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecordForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.albumName_lbl = new System.Windows.Forms.Label();
            this.artistName_lbl = new System.Windows.Forms.Label();
            this.currentValue_lbl = new System.Windows.Forms.Label();
            this.albumName_txtBox = new System.Windows.Forms.TextBox();
            this.artistName_txtBox = new System.Windows.Forms.TextBox();
            this.currentValue_txtBox = new System.Windows.Forms.TextBox();
            this.notes_lbl = new System.Windows.Forms.Label();
            this.albumArt_lbl = new System.Windows.Forms.Label();
            this.notes_txtBox = new System.Windows.Forms.TextBox();
            this.publishYear_lbl = new System.Windows.Forms.Label();
            this.yearReleased_txtBox = new System.Windows.Forms.TextBox();
            this.mediaCondition_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mediaCondition_comboBox = new System.Windows.Forms.ComboBox();
            this.sleeveCondition_comboBox = new System.Windows.Forms.ComboBox();
            this.addRecord_btn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.badAlbumName_lbl = new System.Windows.Forms.Label();
            this.badArtistName_lbl = new System.Windows.Forms.Label();
            this.badValue_lbl = new System.Windows.Forms.Label();
            this.badYear_lbl = new System.Windows.Forms.Label();
            this.checkBox_priceSuggestion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.title_lbl.Location = new System.Drawing.Point(384, 36);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(290, 45);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Add A New Record";
            // 
            // albumName_lbl
            // 
            this.albumName_lbl.AutoSize = true;
            this.albumName_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.albumName_lbl.Location = new System.Drawing.Point(454, 127);
            this.albumName_lbl.Name = "albumName_lbl";
            this.albumName_lbl.Size = new System.Drawing.Size(141, 30);
            this.albumName_lbl.TabIndex = 2;
            this.albumName_lbl.Text = "Album Name:";
            // 
            // artistName_lbl
            // 
            this.artistName_lbl.AutoSize = true;
            this.artistName_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.artistName_lbl.Location = new System.Drawing.Point(452, 213);
            this.artistName_lbl.Name = "artistName_lbl";
            this.artistName_lbl.Size = new System.Drawing.Size(129, 30);
            this.artistName_lbl.TabIndex = 3;
            this.artistName_lbl.Text = "Artist Name:";
            // 
            // currentValue_lbl
            // 
            this.currentValue_lbl.AutoSize = true;
            this.currentValue_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValue_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.currentValue_lbl.Location = new System.Drawing.Point(452, 302);
            this.currentValue_lbl.Name = "currentValue_lbl";
            this.currentValue_lbl.Size = new System.Drawing.Size(143, 30);
            this.currentValue_lbl.TabIndex = 4;
            this.currentValue_lbl.Text = "Current Value:";
            // 
            // albumName_txtBox
            // 
            this.albumName_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.albumName_txtBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.albumName_txtBox.Location = new System.Drawing.Point(623, 128);
            this.albumName_txtBox.Name = "albumName_txtBox";
            this.albumName_txtBox.Size = new System.Drawing.Size(221, 35);
            this.albumName_txtBox.TabIndex = 5;
            this.albumName_txtBox.TextChanged += new System.EventHandler(this.albumName_txtBox_TextChanged);
            // 
            // artistName_txtBox
            // 
            this.artistName_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.artistName_txtBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.artistName_txtBox.Location = new System.Drawing.Point(623, 214);
            this.artistName_txtBox.Name = "artistName_txtBox";
            this.artistName_txtBox.Size = new System.Drawing.Size(221, 35);
            this.artistName_txtBox.TabIndex = 6;
            this.artistName_txtBox.TextChanged += new System.EventHandler(this.artistName_txtBox_TextChanged);
            // 
            // currentValue_txtBox
            // 
            this.currentValue_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.currentValue_txtBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValue_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.currentValue_txtBox.Location = new System.Drawing.Point(623, 303);
            this.currentValue_txtBox.Name = "currentValue_txtBox";
            this.currentValue_txtBox.Size = new System.Drawing.Size(221, 35);
            this.currentValue_txtBox.TabIndex = 7;
            // 
            // notes_lbl
            // 
            this.notes_lbl.AutoSize = true;
            this.notes_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.notes_lbl.Location = new System.Drawing.Point(95, 502);
            this.notes_lbl.Name = "notes_lbl";
            this.notes_lbl.Size = new System.Drawing.Size(73, 30);
            this.notes_lbl.TabIndex = 8;
            this.notes_lbl.Text = "Notes:";
            // 
            // albumArt_lbl
            // 
            this.albumArt_lbl.AutoSize = true;
            this.albumArt_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArt_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.albumArt_lbl.Location = new System.Drawing.Point(231, 85);
            this.albumArt_lbl.Name = "albumArt_lbl";
            this.albumArt_lbl.Size = new System.Drawing.Size(108, 30);
            this.albumArt_lbl.TabIndex = 9;
            this.albumArt_lbl.Text = "Album Art";
            // 
            // notes_txtBox
            // 
            this.notes_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.notes_txtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.notes_txtBox.Location = new System.Drawing.Point(172, 493);
            this.notes_txtBox.Multiline = true;
            this.notes_txtBox.Name = "notes_txtBox";
            this.notes_txtBox.Size = new System.Drawing.Size(672, 121);
            this.notes_txtBox.TabIndex = 10;
            // 
            // publishYear_lbl
            // 
            this.publishYear_lbl.AutoSize = true;
            this.publishYear_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishYear_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.publishYear_lbl.Location = new System.Drawing.Point(168, 428);
            this.publishYear_lbl.Name = "publishYear_lbl";
            this.publishYear_lbl.Size = new System.Drawing.Size(145, 30);
            this.publishYear_lbl.TabIndex = 11;
            this.publishYear_lbl.Text = "Year Released:";
            // 
            // yearReleased_txtBox
            // 
            this.yearReleased_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.yearReleased_txtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearReleased_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.yearReleased_txtBox.Location = new System.Drawing.Point(334, 428);
            this.yearReleased_txtBox.Name = "yearReleased_txtBox";
            this.yearReleased_txtBox.Size = new System.Drawing.Size(105, 29);
            this.yearReleased_txtBox.TabIndex = 12;
            this.yearReleased_txtBox.TextChanged += new System.EventHandler(this.yearReleased_txtBox_TextChanged);
            // 
            // mediaCondition_lbl
            // 
            this.mediaCondition_lbl.AutoSize = true;
            this.mediaCondition_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.mediaCondition_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.mediaCondition_lbl.Location = new System.Drawing.Point(487, 395);
            this.mediaCondition_lbl.Name = "mediaCondition_lbl";
            this.mediaCondition_lbl.Size = new System.Drawing.Size(71, 30);
            this.mediaCondition_lbl.TabIndex = 14;
            this.mediaCondition_lbl.Text = "Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(675, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sleeve";
            // 
            // mediaCondition_comboBox
            // 
            this.mediaCondition_comboBox.BackColor = System.Drawing.Color.DimGray;
            this.mediaCondition_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaCondition_comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaCondition_comboBox.ForeColor = System.Drawing.Color.Transparent;
            this.mediaCondition_comboBox.FormattingEnabled = true;
            this.mediaCondition_comboBox.Items.AddRange(new object[] {
            "Mint (M)",
            "Near Mint (NM or M-)",
            "Very Good Plus (VG+)",
            "Good Plus (G+)",
            "Good (G)",
            "Fair (F)",
            "Poor (P)"});
            this.mediaCondition_comboBox.Location = new System.Drawing.Point(491, 428);
            this.mediaCondition_comboBox.Name = "mediaCondition_comboBox";
            this.mediaCondition_comboBox.Size = new System.Drawing.Size(165, 29);
            this.mediaCondition_comboBox.TabIndex = 16;
            // 
            // sleeveCondition_comboBox
            // 
            this.sleeveCondition_comboBox.BackColor = System.Drawing.Color.DimGray;
            this.sleeveCondition_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleeveCondition_comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleeveCondition_comboBox.ForeColor = System.Drawing.Color.Transparent;
            this.sleeveCondition_comboBox.FormattingEnabled = true;
            this.sleeveCondition_comboBox.Items.AddRange(new object[] {
            "Mint (M)",
            "Near Mint (NM or M-)",
            "Very Good Plus (VG+)",
            "Good Plus (G+)",
            "Good (G)",
            "Fair (F)",
            "Poor (P)"});
            this.sleeveCondition_comboBox.Location = new System.Drawing.Point(679, 428);
            this.sleeveCondition_comboBox.Name = "sleeveCondition_comboBox";
            this.sleeveCondition_comboBox.Size = new System.Drawing.Size(165, 29);
            this.sleeveCondition_comboBox.TabIndex = 17;
            // 
            // addRecord_btn
            // 
            this.addRecord_btn.BackColor = System.Drawing.Color.DimGray;
            this.addRecord_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRecord_btn.FlatAppearance.BorderSize = 2;
            this.addRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecord_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addRecord_btn.Location = new System.Drawing.Point(392, 643);
            this.addRecord_btn.Name = "addRecord_btn";
            this.addRecord_btn.Size = new System.Drawing.Size(229, 74);
            this.addRecord_btn.TabIndex = 18;
            this.addRecord_btn.Text = "Add Record";
            this.addRecord_btn.UseVisualStyleBackColor = false;
            this.addRecord_btn.Click += new System.EventHandler(this.addRecord_btn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderSize = 2;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Location = new System.Drawing.Point(823, 24);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(156, 43);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(597, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(173, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Click  here  to  upload  a new  profile  picture");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // badAlbumName_lbl
            // 
            this.badAlbumName_lbl.AutoSize = true;
            this.badAlbumName_lbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.badAlbumName_lbl.ForeColor = System.Drawing.Color.LightSalmon;
            this.badAlbumName_lbl.Location = new System.Drawing.Point(620, 101);
            this.badAlbumName_lbl.Name = "badAlbumName_lbl";
            this.badAlbumName_lbl.Size = new System.Drawing.Size(178, 25);
            this.badAlbumName_lbl.TabIndex = 22;
            this.badAlbumName_lbl.Text = "Invalid album name";
            this.badAlbumName_lbl.Visible = false;
            // 
            // badArtistName_lbl
            // 
            this.badArtistName_lbl.AutoSize = true;
            this.badArtistName_lbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.badArtistName_lbl.ForeColor = System.Drawing.Color.LightSalmon;
            this.badArtistName_lbl.Location = new System.Drawing.Point(619, 185);
            this.badArtistName_lbl.Name = "badArtistName_lbl";
            this.badArtistName_lbl.Size = new System.Drawing.Size(167, 25);
            this.badArtistName_lbl.TabIndex = 23;
            this.badArtistName_lbl.Text = "Invalid artist name";
            this.badArtistName_lbl.Visible = false;
            // 
            // badValue_lbl
            // 
            this.badValue_lbl.AutoSize = true;
            this.badValue_lbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.badValue_lbl.ForeColor = System.Drawing.Color.LightSalmon;
            this.badValue_lbl.Location = new System.Drawing.Point(620, 276);
            this.badValue_lbl.Name = "badValue_lbl";
            this.badValue_lbl.Size = new System.Drawing.Size(118, 25);
            this.badValue_lbl.TabIndex = 24;
            this.badValue_lbl.Text = "Invalid value";
            this.badValue_lbl.Visible = false;
            // 
            // badYear_lbl
            // 
            this.badYear_lbl.AutoSize = true;
            this.badYear_lbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.badYear_lbl.ForeColor = System.Drawing.Color.LightSalmon;
            this.badYear_lbl.Location = new System.Drawing.Point(330, 401);
            this.badYear_lbl.Name = "badYear_lbl";
            this.badYear_lbl.Size = new System.Drawing.Size(109, 25);
            this.badYear_lbl.TabIndex = 25;
            this.badYear_lbl.Text = "Invalid year";
            this.badYear_lbl.Visible = false;
            // 
            // checkBox_priceSuggestion
            // 
            this.checkBox_priceSuggestion.AutoSize = true;
            this.checkBox_priceSuggestion.FlatAppearance.BorderSize = 2;
            this.checkBox_priceSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_priceSuggestion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkBox_priceSuggestion.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox_priceSuggestion.Location = new System.Drawing.Point(624, 344);
            this.checkBox_priceSuggestion.Name = "checkBox_priceSuggestion";
            this.checkBox_priceSuggestion.Size = new System.Drawing.Size(226, 21);
            this.checkBox_priceSuggestion.TabIndex = 26;
            this.checkBox_priceSuggestion.Text = "Use Suggested Price from Discogs";
            this.checkBox_priceSuggestion.UseVisualStyleBackColor = true;
            this.checkBox_priceSuggestion.Visible = false;
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.checkBox_priceSuggestion);
            this.Controls.Add(this.badYear_lbl);
            this.Controls.Add(this.badValue_lbl);
            this.Controls.Add(this.badArtistName_lbl);
            this.Controls.Add(this.badAlbumName_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addRecord_btn);
            this.Controls.Add(this.sleeveCondition_comboBox);
            this.Controls.Add(this.mediaCondition_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mediaCondition_lbl);
            this.Controls.Add(this.yearReleased_txtBox);
            this.Controls.Add(this.publishYear_lbl);
            this.Controls.Add(this.notes_txtBox);
            this.Controls.Add(this.albumArt_lbl);
            this.Controls.Add(this.notes_lbl);
            this.Controls.Add(this.currentValue_txtBox);
            this.Controls.Add(this.artistName_txtBox);
            this.Controls.Add(this.albumName_txtBox);
            this.Controls.Add(this.currentValue_lbl);
            this.Controls.Add(this.artistName_lbl);
            this.Controls.Add(this.albumName_lbl);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRecordForm";
            this.Text = "Record Collection Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label albumName_lbl;
        private System.Windows.Forms.Label artistName_lbl;
        private System.Windows.Forms.Label currentValue_lbl;
        private System.Windows.Forms.TextBox albumName_txtBox;
        private System.Windows.Forms.TextBox artistName_txtBox;
        private System.Windows.Forms.TextBox currentValue_txtBox;
        private System.Windows.Forms.Label notes_lbl;
        private System.Windows.Forms.Label albumArt_lbl;
        private System.Windows.Forms.TextBox notes_txtBox;
        private System.Windows.Forms.Label publishYear_lbl;
        private System.Windows.Forms.TextBox yearReleased_txtBox;
        private System.Windows.Forms.Label mediaCondition_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mediaCondition_comboBox;
        private System.Windows.Forms.ComboBox sleeveCondition_comboBox;
        private System.Windows.Forms.Button addRecord_btn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label badAlbumName_lbl;
        private System.Windows.Forms.Label badArtistName_lbl;
        private System.Windows.Forms.Label badValue_lbl;
        private System.Windows.Forms.Label badYear_lbl;
        private System.Windows.Forms.CheckBox checkBox_priceSuggestion;
    }
}