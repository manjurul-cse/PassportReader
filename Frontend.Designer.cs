namespace VideoOCRDemo
{
    partial class Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            this.Enable = new System.Windows.Forms.Button();
            this.pictureBoxRFID = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrey = new System.Windows.Forms.PictureBox();
            this.GetColourImage = new System.Windows.Forms.Button();
            this.pictureBoxColour = new System.Windows.Forms.PictureBox();
            this.pictureBoxUV = new System.Windows.Forms.PictureBox();
            this.textBoxMRZ = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BusyLabel = new System.Windows.Forms.Label();
            this.DPlabel = new System.Windows.Forms.Label();
            this.PPlabel = new System.Windows.Forms.Label();
            this.MRZlabel = new System.Windows.Forms.Label();
            this.RFIDPlabel = new System.Windows.Forms.Label();
            this.RFIDDlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GetUVImage = new System.Windows.Forms.Button();
            this.GetIRImage = new System.Windows.Forms.Button();
            this.pictureBoxTopBanner = new System.Windows.Forms.PictureBox();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.passportNoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.executeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.DistrictLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // Enable
            // 
            this.Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enable.ForeColor = System.Drawing.Color.Black;
            this.Enable.Location = new System.Drawing.Point(21, 127);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(145, 28);
            this.Enable.TabIndex = 0;
            this.Enable.Text = "&Enable Reader";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // pictureBoxRFID
            // 
            this.pictureBoxRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRFID.Location = new System.Drawing.Point(218, 166);
            this.pictureBoxRFID.Name = "pictureBoxRFID";
            this.pictureBoxRFID.Size = new System.Drawing.Size(186, 243);
            this.pictureBoxRFID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRFID.TabIndex = 2;
            this.pictureBoxRFID.TabStop = false;
            this.pictureBoxRFID.Visible = false;
            // 
            // pictureBoxGrey
            // 
            this.pictureBoxGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGrey.Location = new System.Drawing.Point(298, 185);
            this.pictureBoxGrey.Name = "pictureBoxGrey";
            this.pictureBoxGrey.Size = new System.Drawing.Size(260, 153);
            this.pictureBoxGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGrey.TabIndex = 3;
            this.pictureBoxGrey.TabStop = false;
            // 
            // GetColourImage
            // 
            this.GetColourImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetColourImage.Location = new System.Drawing.Point(38, 611);
            this.GetColourImage.Name = "GetColourImage";
            this.GetColourImage.Size = new System.Drawing.Size(119, 29);
            this.GetColourImage.TabIndex = 4;
            this.GetColourImage.Text = "Get Colour Image";
            this.GetColourImage.UseVisualStyleBackColor = true;
            this.GetColourImage.Visible = false;
            this.GetColourImage.Click += new System.EventHandler(this.ColourSnapshot);
            // 
            // pictureBoxColour
            // 
            this.pictureBoxColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColour.Location = new System.Drawing.Point(21, 185);
            this.pictureBoxColour.Name = "pictureBoxColour";
            this.pictureBoxColour.Size = new System.Drawing.Size(260, 153);
            this.pictureBoxColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColour.TabIndex = 5;
            this.pictureBoxColour.TabStop = false;
            // 
            // pictureBoxUV
            // 
            this.pictureBoxUV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUV.Location = new System.Drawing.Point(573, 185);
            this.pictureBoxUV.Name = "pictureBoxUV";
            this.pictureBoxUV.Size = new System.Drawing.Size(260, 153);
            this.pictureBoxUV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUV.TabIndex = 6;
            this.pictureBoxUV.TabStop = false;
            // 
            // textBoxMRZ
            // 
            this.textBoxMRZ.Location = new System.Drawing.Point(21, 554);
            this.textBoxMRZ.Multiline = true;
            this.textBoxMRZ.Name = "textBoxMRZ";
            this.textBoxMRZ.ReadOnly = true;
            this.textBoxMRZ.Size = new System.Drawing.Size(468, 55);
            this.textBoxMRZ.TabIndex = 7;
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Black;
            this.Restart.Location = new System.Drawing.Point(205, 126);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(131, 29);
            this.Restart.TabIndex = 13;
            this.Restart.Text = "&Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MRZ Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "UV Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Colour Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "IR Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "RFID Image";
            this.label5.Visible = false;
            // 
            // BusyLabel
            // 
            this.BusyLabel.AutoSize = true;
            this.BusyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusyLabel.ForeColor = System.Drawing.Color.Black;
            this.BusyLabel.Location = new System.Drawing.Point(13, 37);
            this.BusyLabel.Name = "BusyLabel";
            this.BusyLabel.Size = new System.Drawing.Size(51, 24);
            this.BusyLabel.TabIndex = 19;
            this.BusyLabel.Text = "Busy";
            // 
            // DPlabel
            // 
            this.DPlabel.AutoSize = true;
            this.DPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPlabel.Location = new System.Drawing.Point(130, 37);
            this.DPlabel.Name = "DPlabel";
            this.DPlabel.Size = new System.Drawing.Size(166, 24);
            this.DPlabel.TabIndex = 20;
            this.DPlabel.Text = "Document Present";
            // 
            // PPlabel
            // 
            this.PPlabel.AutoSize = true;
            this.PPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPlabel.ForeColor = System.Drawing.Color.Black;
            this.PPlabel.Location = new System.Drawing.Point(381, 37);
            this.PPlabel.Name = "PPlabel";
            this.PPlabel.Size = new System.Drawing.Size(151, 24);
            this.PPlabel.TabIndex = 21;
            this.PPlabel.Text = "Passport Present";
            // 
            // MRZlabel
            // 
            this.MRZlabel.AutoSize = true;
            this.MRZlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRZlabel.ForeColor = System.Drawing.Color.Black;
            this.MRZlabel.Location = new System.Drawing.Point(628, 37);
            this.MRZlabel.Name = "MRZlabel";
            this.MRZlabel.Size = new System.Drawing.Size(134, 24);
            this.MRZlabel.TabIndex = 22;
            this.MRZlabel.Text = "MRZ Decoded";
            // 
            // RFIDPlabel
            // 
            this.RFIDPlabel.AutoSize = true;
            this.RFIDPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDPlabel.ForeColor = System.Drawing.Color.Black;
            this.RFIDPlabel.Location = new System.Drawing.Point(649, 18);
            this.RFIDPlabel.Name = "RFIDPlabel";
            this.RFIDPlabel.Size = new System.Drawing.Size(121, 24);
            this.RFIDPlabel.TabIndex = 23;
            this.RFIDPlabel.Text = "RFID Present";
            this.RFIDPlabel.Visible = false;
            // 
            // RFIDDlabel
            // 
            this.RFIDDlabel.AutoSize = true;
            this.RFIDDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDDlabel.ForeColor = System.Drawing.Color.Black;
            this.RFIDDlabel.Location = new System.Drawing.Point(649, 42);
            this.RFIDDlabel.Name = "RFIDDlabel";
            this.RFIDDlabel.Size = new System.Drawing.Size(135, 24);
            this.RFIDDlabel.TabIndex = 24;
            this.RFIDDlabel.Text = "RFID Decoded";
            this.RFIDDlabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BusyLabel);
            this.groupBox1.Controls.Add(this.DPlabel);
            this.groupBox1.Controls.Add(this.PPlabel);
            this.groupBox1.Controls.Add(this.MRZlabel);
            this.groupBox1.Controls.Add(this.RFIDDlabel);
            this.groupBox1.Controls.Add(this.RFIDPlabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 84);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // GetUVImage
            // 
            this.GetUVImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUVImage.Location = new System.Drawing.Point(360, 611);
            this.GetUVImage.Name = "GetUVImage";
            this.GetUVImage.Size = new System.Drawing.Size(119, 29);
            this.GetUVImage.TabIndex = 26;
            this.GetUVImage.Text = "Get UV Image";
            this.GetUVImage.UseVisualStyleBackColor = true;
            this.GetUVImage.Visible = false;
            this.GetUVImage.Click += new System.EventHandler(this.UVSnapshot);
            // 
            // GetIRImage
            // 
            this.GetIRImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetIRImage.Location = new System.Drawing.Point(198, 611);
            this.GetIRImage.Name = "GetIRImage";
            this.GetIRImage.Size = new System.Drawing.Size(119, 29);
            this.GetIRImage.TabIndex = 27;
            this.GetIRImage.Text = "Get IR Image";
            this.GetIRImage.UseVisualStyleBackColor = true;
            this.GetIRImage.Visible = false;
            this.GetIRImage.Click += new System.EventHandler(this.IRSnapshot);
            // 
            // pictureBoxTopBanner
            // 
            this.pictureBoxTopBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopBanner.Image")));
            this.pictureBoxTopBanner.ImageLocation = "";
            this.pictureBoxTopBanner.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTopBanner.Name = "pictureBoxTopBanner";
            this.pictureBoxTopBanner.Size = new System.Drawing.Size(815, 107);
            this.pictureBoxTopBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTopBanner.TabIndex = 29;
            this.pictureBoxTopBanner.TabStop = false;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(730, 549);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(112, 28);
            this.nextPageButton.TabIndex = 33;
            this.nextPageButton.Text = "Next Page Scan";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Districts";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userLabel.Location = new System.Drawing.Point(660, 125);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 17);
            this.userLabel.TabIndex = 35;
            // 
            // logOutButton
            // 
            this.logOutButton.ForeColor = System.Drawing.Color.Red;
            this.logOutButton.Location = new System.Drawing.Point(758, 156);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 36;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Passport No";
            // 
            // passportNoTextBox
            // 
            this.passportNoTextBox.BackColor = System.Drawing.Color.White;
            this.passportNoTextBox.Location = new System.Drawing.Point(97, 459);
            this.passportNoTextBox.Name = "passportNoTextBox";
            this.passportNoTextBox.ReadOnly = true;
            this.passportNoTextBox.Size = new System.Drawing.Size(159, 20);
            this.passportNoTextBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.Location = new System.Drawing.Point(384, 454);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.firstNameTextBox.TabIndex = 38;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.Location = new System.Drawing.Point(382, 490);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.lastNameTextBox.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Last Name";
            // 
            // executeButton
            // 
            this.executeButton.Enabled = false;
            this.executeButton.Location = new System.Drawing.Point(502, 611);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(112, 29);
            this.executeButton.TabIndex = 32;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.Location = new System.Drawing.Point(671, 595);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 45);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(354, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 43;
            // 
            // districtComboBox
            // 
            this.districtComboBox.BackColor = System.Drawing.Color.White;
            this.districtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(544, 553);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(163, 21);
            this.districtComboBox.TabIndex = 31;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.districtComboBox_SelectedIndexChanged_1);
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistrictLabel.Location = new System.Drawing.Point(544, 532);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(0, 20);
            this.DistrictLabel.TabIndex = 42;
            // 
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 652);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.passportNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.GetIRImage);
            this.Controls.Add(this.GetUVImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.textBoxMRZ);
            this.Controls.Add(this.pictureBoxUV);
            this.Controls.Add(this.pictureBoxColour);
            this.Controls.Add(this.GetColourImage);
            this.Controls.Add(this.pictureBoxGrey);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.pictureBoxTopBanner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxRFID);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frontend";
            this.Text = "TMLMRP SOLUTION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button GetColourImage;
        public System.Windows.Forms.PictureBox pictureBoxGrey;
        public System.Windows.Forms.PictureBox pictureBoxColour;
        public System.Windows.Forms.PictureBox pictureBoxUV;
        private System.Windows.Forms.Button Restart;
        public System.Windows.Forms.TextBox textBoxMRZ;   //------------
        public System.Windows.Forms.PictureBox pictureBoxRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BusyLabel;
        private System.Windows.Forms.Label DPlabel;
        private System.Windows.Forms.Label PPlabel;
        private System.Windows.Forms.Label MRZlabel;
        private System.Windows.Forms.Label RFIDPlabel;
        private System.Windows.Forms.Label RFIDDlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetUVImage;
        private System.Windows.Forms.Button GetIRImage;
        private System.Windows.Forms.PictureBox pictureBoxTopBanner;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox passportNoTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.Label DistrictLabel;
//        private System.Windows.Forms.TextBox textBox1;  //-------
    }
}

