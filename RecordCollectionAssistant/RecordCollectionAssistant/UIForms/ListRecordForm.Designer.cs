namespace RecordCollectionAssistant.UIForms
{
    partial class ListRecordForm
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
            System.Windows.Forms.ColumnHeader viewNotes_header;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRecordForm));
            this.collectionOwner_lbl = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.search_txtBox = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.addViaBarcode_btn = new System.Windows.Forms.Button();
            this.recordListView = new System.Windows.Forms.ListView();
            this.recordName_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artist_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearReleased_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.condition_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentValue_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addRecord_btn = new System.Windows.Forms.Button();
            this.editRecord_btn = new System.Windows.Forms.Button();
            this.collectionSize_lbl = new System.Windows.Forms.Label();
            this.collectionSizeDisplay_lbl = new System.Windows.Forms.Label();
            this.sort_comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.album_lbl = new System.Windows.Forms.Label();
            this.artist_lbl = new System.Windows.Forms.Label();
            this.notes_lbl = new System.Windows.Forms.Label();
            this.notes_richTxtBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_invalidImportError = new System.Windows.Forms.Label();
            this.btn_randomRecord = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.redoBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.artistDisplayBox_txtbox = new System.Windows.Forms.TextBox();
            this.albumDisplayBox_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeTxtBox = new System.Windows.Forms.TextBox();
            this.export_btn = new System.Windows.Forms.Button();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            viewNotes_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewNotes_header
            // 
            viewNotes_header.Width = 0;
            // 
            // collectionOwner_lbl
            // 
            this.collectionOwner_lbl.AutoSize = true;
            this.collectionOwner_lbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionOwner_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.collectionOwner_lbl.Location = new System.Drawing.Point(27, 33);
            this.collectionOwner_lbl.Name = "collectionOwner_lbl";
            this.collectionOwner_lbl.Size = new System.Drawing.Size(0, 37);
            this.collectionOwner_lbl.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout_btn.FlatAppearance.BorderSize = 2;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Transparent;
            this.logout_btn.Location = new System.Drawing.Point(890, 18);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(99, 52);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // search_txtBox
            // 
            this.search_txtBox.BackColor = System.Drawing.Color.DimGray;
            this.search_txtBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtBox.ForeColor = System.Drawing.Color.Transparent;
            this.search_txtBox.Location = new System.Drawing.Point(423, 77);
            this.search_txtBox.Name = "search_txtBox";
            this.search_txtBox.Size = new System.Drawing.Size(209, 35);
            this.search_txtBox.TabIndex = 4;
            this.search_txtBox.TextChanged += new System.EventHandler(this.search_txtBox_TextChanged);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.search_lbl.Location = new System.Drawing.Point(337, 76);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(80, 30);
            this.search_lbl.TabIndex = 5;
            this.search_lbl.Text = "Search:";
            // 
            // delete_btn
            // 
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete_btn.FlatAppearance.BorderSize = 2;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Transparent;
            this.delete_btn.Location = new System.Drawing.Point(753, 651);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(115, 65);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // addViaBarcode_btn
            // 
            this.addViaBarcode_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addViaBarcode_btn.FlatAppearance.BorderSize = 2;
            this.addViaBarcode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addViaBarcode_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addViaBarcode_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addViaBarcode_btn.Location = new System.Drawing.Point(223, 687);
            this.addViaBarcode_btn.Name = "addViaBarcode_btn";
            this.addViaBarcode_btn.Size = new System.Drawing.Size(135, 32);
            this.addViaBarcode_btn.TabIndex = 10;
            this.addViaBarcode_btn.Text = "Add via Barcode";
            this.addViaBarcode_btn.UseVisualStyleBackColor = true;
            this.addViaBarcode_btn.Click += new System.EventHandler(this.addViaBarcode_btn_Click);
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
            this.currentValue_header,
            this.id_header,
            viewNotes_header});
            this.recordListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordListView.ForeColor = System.Drawing.Color.Transparent;
            this.recordListView.FullRowSelect = true;
            this.recordListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.recordListView.Location = new System.Drawing.Point(29, 115);
            this.recordListView.MultiSelect = false;
            this.recordListView.Name = "recordListView";
            this.recordListView.Size = new System.Drawing.Size(705, 481);
            this.recordListView.TabIndex = 13;
            this.recordListView.UseCompatibleStateImageBehavior = false;
            this.recordListView.View = System.Windows.Forms.View.Details;
            this.recordListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // recordName_header
            // 
            this.recordName_header.Text = "Record Name";
            this.recordName_header.Width = 180;
            // 
            // artist_header
            // 
            this.artist_header.Text = "Artist";
            this.artist_header.Width = 120;
            // 
            // yearReleased_header
            // 
            this.yearReleased_header.Text = "Year Released";
            this.yearReleased_header.Width = 85;
            // 
            // condition_header
            // 
            this.condition_header.Text = "Condition (Media / Sleeve)";
            this.condition_header.Width = 151;
            // 
            // currentValue_header
            // 
            this.currentValue_header.Text = "Current Value";
            this.currentValue_header.Width = 80;
            // 
            // id_header
            // 
            this.id_header.Text = "ID";
            this.id_header.Width = 75;
            // 
            // addRecord_btn
            // 
            this.addRecord_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRecord_btn.FlatAppearance.BorderSize = 2;
            this.addRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecord_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addRecord_btn.Location = new System.Drawing.Point(440, 650);
            this.addRecord_btn.Name = "addRecord_btn";
            this.addRecord_btn.Size = new System.Drawing.Size(115, 65);
            this.addRecord_btn.TabIndex = 14;
            this.addRecord_btn.Text = "Add";
            this.addRecord_btn.UseVisualStyleBackColor = true;
            this.addRecord_btn.Click += new System.EventHandler(this.addRecord_btn_Click);
            // 
            // editRecord_btn
            // 
            this.editRecord_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editRecord_btn.FlatAppearance.BorderSize = 2;
            this.editRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRecord_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRecord_btn.ForeColor = System.Drawing.Color.Transparent;
            this.editRecord_btn.Location = new System.Drawing.Point(874, 651);
            this.editRecord_btn.Name = "editRecord_btn";
            this.editRecord_btn.Size = new System.Drawing.Size(115, 65);
            this.editRecord_btn.TabIndex = 15;
            this.editRecord_btn.Text = "Edit";
            this.editRecord_btn.UseVisualStyleBackColor = true;
            this.editRecord_btn.Click += new System.EventHandler(this.editRecord_btn_Click);
            // 
            // collectionSize_lbl
            // 
            this.collectionSize_lbl.AutoSize = true;
            this.collectionSize_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionSize_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.collectionSize_lbl.Location = new System.Drawing.Point(25, 83);
            this.collectionSize_lbl.Name = "collectionSize_lbl";
            this.collectionSize_lbl.Size = new System.Drawing.Size(163, 21);
            this.collectionSize_lbl.TabIndex = 16;
            this.collectionSize_lbl.Text = "Records in Collection: ";
            // 
            // collectionSizeDisplay_lbl
            // 
            this.collectionSizeDisplay_lbl.AutoSize = true;
            this.collectionSizeDisplay_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionSizeDisplay_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.collectionSizeDisplay_lbl.Location = new System.Drawing.Point(192, 83);
            this.collectionSizeDisplay_lbl.Name = "collectionSizeDisplay_lbl";
            this.collectionSizeDisplay_lbl.Size = new System.Drawing.Size(79, 21);
            this.collectionSizeDisplay_lbl.TabIndex = 17;
            this.collectionSizeDisplay_lbl.Text = "0 Records";
            // 
            // sort_comboBox
            // 
            this.sort_comboBox.BackColor = System.Drawing.Color.DimGray;
            this.sort_comboBox.CausesValidation = false;
            this.sort_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_comboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_comboBox.ForeColor = System.Drawing.Color.Transparent;
            this.sort_comboBox.FormattingEnabled = true;
            this.sort_comboBox.Items.AddRange(new object[] {
            "Name",
            "Artist",
            "Oldest To Newest",
            "Newest To Oldest",
            "Lowest Price",
            "Highest Price"});
            this.sort_comboBox.Location = new System.Drawing.Point(643, 83);
            this.sort_comboBox.Name = "sort_comboBox";
            this.sort_comboBox.Size = new System.Drawing.Size(91, 25);
            this.sort_comboBox.TabIndex = 18;
            this.sort_comboBox.Text = "Sort By...";
            this.sort_comboBox.SelectedIndexChanged += new System.EventHandler(this.sort_comboBox_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(764, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // album_lbl
            // 
            this.album_lbl.AutoSize = true;
            this.album_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.album_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.album_lbl.Location = new System.Drawing.Point(760, 357);
            this.album_lbl.Name = "album_lbl";
            this.album_lbl.Size = new System.Drawing.Size(59, 21);
            this.album_lbl.TabIndex = 21;
            this.album_lbl.Text = "Album:";
            // 
            // artist_lbl
            // 
            this.artist_lbl.AutoSize = true;
            this.artist_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.artist_lbl.Location = new System.Drawing.Point(767, 398);
            this.artist_lbl.Name = "artist_lbl";
            this.artist_lbl.Size = new System.Drawing.Size(50, 21);
            this.artist_lbl.TabIndex = 22;
            this.artist_lbl.Text = "Artist:";
            // 
            // notes_lbl
            // 
            this.notes_lbl.AutoSize = true;
            this.notes_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.notes_lbl.Location = new System.Drawing.Point(762, 439);
            this.notes_lbl.Name = "notes_lbl";
            this.notes_lbl.Size = new System.Drawing.Size(54, 21);
            this.notes_lbl.TabIndex = 23;
            this.notes_lbl.Text = "Notes:";
            // 
            // notes_richTxtBox
            // 
            this.notes_richTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.notes_richTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes_richTxtBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_richTxtBox.ForeColor = System.Drawing.Color.Transparent;
            this.notes_richTxtBox.Location = new System.Drawing.Point(826, 442);
            this.notes_richTxtBox.Name = "notes_richTxtBox";
            this.notes_richTxtBox.ReadOnly = true;
            this.notes_richTxtBox.Size = new System.Drawing.Size(158, 154);
            this.notes_richTxtBox.TabIndex = 24;
            this.notes_richTxtBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lbl_invalidImportError);
            this.panel1.Controls.Add(this.btn_randomRecord);
            this.panel1.Controls.Add(this.import_btn);
            this.panel1.Controls.Add(this.redoBtn);
            this.panel1.Controls.Add(this.undoBtn);
            this.panel1.Controls.Add(this.artistDisplayBox_txtbox);
            this.panel1.Controls.Add(this.albumDisplayBox_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.barcodeTxtBox);
            this.panel1.Controls.Add(this.collectionOwner_lbl);
            this.panel1.Controls.Add(this.export_btn);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.addViaBarcode_btn);
            this.panel1.Controls.Add(this.editRecord_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.addRecord_btn);
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.MaximumSize = new System.Drawing.Size(1015, 734);
            this.panel1.MinimumSize = new System.Drawing.Size(1015, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 734);
            this.panel1.TabIndex = 25;
            // 
            // lbl_invalidImportError
            // 
            this.lbl_invalidImportError.AutoSize = true;
            this.lbl_invalidImportError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalidImportError.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_invalidImportError.Location = new System.Drawing.Point(449, 33);
            this.lbl_invalidImportError.Name = "lbl_invalidImportError";
            this.lbl_invalidImportError.Size = new System.Drawing.Size(205, 25);
            this.lbl_invalidImportError.TabIndex = 28;
            this.lbl_invalidImportError.Text = "Please open a valid file";
            this.lbl_invalidImportError.Visible = false;
            // 
            // btn_randomRecord
            // 
            this.btn_randomRecord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_randomRecord.FlatAppearance.BorderSize = 2;
            this.btn_randomRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randomRecord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_randomRecord.ForeColor = System.Drawing.Color.Transparent;
            this.btn_randomRecord.Location = new System.Drawing.Point(34, 651);
            this.btn_randomRecord.Name = "btn_randomRecord";
            this.btn_randomRecord.Size = new System.Drawing.Size(115, 65);
            this.btn_randomRecord.TabIndex = 0;
            this.btn_randomRecord.Text = "Random Record";
            this.btn_randomRecord.Click += new System.EventHandler(this.btn_randomRecord_Click_1);
            // 
            // import_btn
            // 
            this.import_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.import_btn.FlatAppearance.BorderSize = 2;
            this.import_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_btn.ForeColor = System.Drawing.Color.Transparent;
            this.import_btn.Location = new System.Drawing.Point(660, 18);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(99, 52);
            this.import_btn.TabIndex = 27;
            this.import_btn.Text = "Import";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.redoBtn.FlatAppearance.BorderSize = 2;
            this.redoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.redoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.redoBtn.Location = new System.Drawing.Point(606, 686);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(95, 30);
            this.redoBtn.TabIndex = 25;
            this.redoBtn.Text = "Redo";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.undoBtn.FlatAppearance.BorderSize = 2;
            this.undoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.undoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.undoBtn.Location = new System.Drawing.Point(606, 652);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(95, 30);
            this.undoBtn.TabIndex = 24;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // artistDisplayBox_txtbox
            // 
            this.artistDisplayBox_txtbox.BackColor = System.Drawing.Color.DimGray;
            this.artistDisplayBox_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.artistDisplayBox_txtbox.ForeColor = System.Drawing.Color.Transparent;
            this.artistDisplayBox_txtbox.Location = new System.Drawing.Point(831, 404);
            this.artistDisplayBox_txtbox.Name = "artistDisplayBox_txtbox";
            this.artistDisplayBox_txtbox.ReadOnly = true;
            this.artistDisplayBox_txtbox.Size = new System.Drawing.Size(158, 27);
            this.artistDisplayBox_txtbox.TabIndex = 23;
            // 
            // albumDisplayBox_txtbox
            // 
            this.albumDisplayBox_txtbox.BackColor = System.Drawing.Color.DimGray;
            this.albumDisplayBox_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumDisplayBox_txtbox.ForeColor = System.Drawing.Color.Transparent;
            this.albumDisplayBox_txtbox.Location = new System.Drawing.Point(831, 363);
            this.albumDisplayBox_txtbox.Name = "albumDisplayBox_txtbox";
            this.albumDisplayBox_txtbox.ReadOnly = true;
            this.albumDisplayBox_txtbox.Size = new System.Drawing.Size(158, 27);
            this.albumDisplayBox_txtbox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(191, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Record Barcode";
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.barcodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.barcodeTxtBox.ForeColor = System.Drawing.Color.Transparent;
            this.barcodeTxtBox.Location = new System.Drawing.Point(195, 651);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.Size = new System.Drawing.Size(195, 31);
            this.barcodeTxtBox.TabIndex = 20;
            // 
            // export_btn
            // 
            this.export_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.export_btn.FlatAppearance.BorderSize = 2;
            this.export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_btn.ForeColor = System.Drawing.Color.Transparent;
            this.export_btn.Location = new System.Drawing.Point(776, 18);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(99, 52);
            this.export_btn.TabIndex = 19;
            this.export_btn.Text = "Export";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "file.txt";
            // 
            // ListRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.notes_richTxtBox);
            this.Controls.Add(this.notes_lbl);
            this.Controls.Add(this.artist_lbl);
            this.Controls.Add(this.album_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sort_comboBox);
            this.Controls.Add(this.collectionSizeDisplay_lbl);
            this.Controls.Add(this.collectionSize_lbl);
            this.Controls.Add(this.recordListView);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_txtBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListRecordForm";
            this.Text = "Record Collection Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label collectionOwner_lbl;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.TextBox search_txtBox;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button addViaBarcode_btn;
        private System.Windows.Forms.ListView recordListView;
        private System.Windows.Forms.Button addRecord_btn;
        private System.Windows.Forms.ColumnHeader recordName_header;
        private System.Windows.Forms.ColumnHeader artist_header;
        private System.Windows.Forms.ColumnHeader yearReleased_header;
        private System.Windows.Forms.ColumnHeader condition_header;
        private System.Windows.Forms.ColumnHeader currentValue_header;
        private System.Windows.Forms.ColumnHeader id_header;
        private System.Windows.Forms.Button editRecord_btn;
        private System.Windows.Forms.Label collectionSize_lbl;
        private System.Windows.Forms.Label collectionSizeDisplay_lbl;
        private System.Windows.Forms.ComboBox sort_comboBox;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label album_lbl;
        private System.Windows.Forms.Label artist_lbl;
        private System.Windows.Forms.Label notes_lbl;
        private System.Windows.Forms.RichTextBox notes_richTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeTxtBox;
        private System.Windows.Forms.TextBox artistDisplayBox_txtbox;
        private System.Windows.Forms.TextBox albumDisplayBox_txtbox;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Button undoBtn;
		private System.Windows.Forms.Button btn_randomRecord;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Label lbl_invalidImportError;
    }
}

