namespace LibHUMG
{
    partial class FrmTraSach
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbltienphat = new System.Windows.Forms.Label();
            this.dtpngaytrasach = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsomuonid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbomacuonsach = new System.Windows.Forms.ComboBox();
            this.dtNgayHenTra_TraSach = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon_TraSach = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMaDG_TraSach = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Dgvtrasach = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtrasach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txttrangthai);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lbltienphat);
            this.groupBox4.Controls.Add(this.dtpngaytrasach);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtsomuonid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbomacuonsach);
            this.groupBox4.Controls.Add(this.dtNgayHenTra_TraSach);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dtNgayMuon_TraSach);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbMaDG_TraSach);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 39);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(849, 197);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thực Hiện Trả Sách";
            // 
            // lbltienphat
            // 
            this.lbltienphat.AutoSize = true;
            this.lbltienphat.Location = new System.Drawing.Point(638, 164);
            this.lbltienphat.Name = "lbltienphat";
            this.lbltienphat.Size = new System.Drawing.Size(0, 19);
            this.lbltienphat.TabIndex = 23;
            // 
            // dtpngaytrasach
            // 
            this.dtpngaytrasach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaytrasach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytrasach.Location = new System.Drawing.Point(598, 64);
            this.dtpngaytrasach.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaytrasach.Name = "dtpngaytrasach";
            this.dtpngaytrasach.Size = new System.Drawing.Size(203, 29);
            this.dtpngaytrasach.TabIndex = 22;
            this.dtpngaytrasach.ValueChanged += new System.EventHandler(this.hgg);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày Trả:";
            // 
            // txtsomuonid
            // 
            this.txtsomuonid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsomuonid.Location = new System.Drawing.Point(158, 31);
            this.txtsomuonid.Margin = new System.Windows.Forms.Padding(4);
            this.txtsomuonid.Name = "txtsomuonid";
            this.txtsomuonid.Size = new System.Drawing.Size(221, 29);
            this.txtsomuonid.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "SoMuonID:";
            // 
            // cbomacuonsach
            // 
            this.cbomacuonsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomacuonsach.FormattingEnabled = true;
            this.cbomacuonsach.Location = new System.Drawing.Point(158, 115);
            this.cbomacuonsach.Margin = new System.Windows.Forms.Padding(4);
            this.cbomacuonsach.Name = "cbomacuonsach";
            this.cbomacuonsach.Size = new System.Drawing.Size(221, 27);
            this.cbomacuonsach.TabIndex = 18;
            // 
            // dtNgayHenTra_TraSach
            // 
            this.dtNgayHenTra_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayHenTra_TraSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHenTra_TraSach.Location = new System.Drawing.Point(598, 27);
            this.dtNgayHenTra_TraSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayHenTra_TraSach.Name = "dtNgayHenTra_TraSach";
            this.dtNgayHenTra_TraSach.Size = new System.Drawing.Size(203, 29);
            this.dtNgayHenTra_TraSach.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(442, 34);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 22);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ngày Hẹn Trả:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(475, 272);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dtNgayMuon_TraSach
            // 
            this.dtNgayMuon_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon_TraSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon_TraSach.Location = new System.Drawing.Point(158, 157);
            this.dtNgayMuon_TraSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayMuon_TraSach.Name = "dtNgayMuon_TraSach";
            this.dtNgayMuon_TraSach.Size = new System.Drawing.Size(221, 29);
            this.dtNgayMuon_TraSach.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Hẹn Trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày Mượn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiền Phạt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Sách:";
            // 
            // cbMaDG_TraSach
            // 
            this.cbMaDG_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaDG_TraSach.FormattingEnabled = true;
            this.cbMaDG_TraSach.Location = new System.Drawing.Point(158, 75);
            this.cbMaDG_TraSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaDG_TraSach.Name = "cbMaDG_TraSach";
            this.cbMaDG_TraSach.Size = new System.Drawing.Size(221, 30);
            this.cbMaDG_TraSach.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "Mã Độc Giả:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(470, 244);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(169, 244);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 35);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraSach.Location = new System.Drawing.Point(21, 244);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(141, 35);
            this.btnTraSach.TabIndex = 11;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Dgvtrasach);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 324);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(860, 263);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Trả Sách";
            // 
            // Dgvtrasach
            // 
            this.Dgvtrasach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvtrasach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SMID,
            this.MaDG,
            this.MaS,
            this.NgayM,
            this.NgayHT,
            this.TP,
            this.TinhTrang});
            this.Dgvtrasach.Location = new System.Drawing.Point(8, 25);
            this.Dgvtrasach.Margin = new System.Windows.Forms.Padding(4);
            this.Dgvtrasach.Name = "Dgvtrasach";
            this.Dgvtrasach.Size = new System.Drawing.Size(848, 238);
            this.Dgvtrasach.TabIndex = 0;
            this.Dgvtrasach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvtrasach_CellClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(335, 245);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(118, 35);
            this.btnXuatExcel.TabIndex = 12;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(470, 296);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(118, 26);
            this.btntimkiem.TabIndex = 13;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 296);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 26);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhập Mã Sách :";
            // 
            // SMID
            // 
            this.SMID.HeaderText = "Sổ Mượn ID";
            this.SMID.Name = "SMID";
            this.SMID.Width = 150;
            // 
            // MaDG
            // 
            this.MaDG.HeaderText = "Mã Độc Giả";
            this.MaDG.Name = "MaDG";
            this.MaDG.Width = 150;
            // 
            // MaS
            // 
            this.MaS.HeaderText = "Mã Sách";
            this.MaS.Name = "MaS";
            this.MaS.Width = 120;
            // 
            // NgayM
            // 
            this.NgayM.HeaderText = "Ngày Mượn";
            this.NgayM.Name = "NgayM";
            this.NgayM.Width = 140;
            // 
            // NgayHT
            // 
            this.NgayHT.HeaderText = "Ngày Hẹn Trả";
            this.NgayHT.Name = "NgayHT";
            this.NgayHT.Width = 150;
            // 
            // TP
            // 
            this.TP.HeaderText = "Tiền Phạt";
            this.TP.Name = "TP";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Trạng Thái";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // txttrangthai
            // 
            this.txttrangthai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrangthai.Location = new System.Drawing.Point(598, 108);
            this.txttrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(203, 29);
            this.txttrangthai.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Trạng Thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(347, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "TRẢ SÁCH";
            // 
            // FrmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 594);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmTraSach";
            this.Text = "FrmTraSach";
            this.Load += new System.EventHandler(this.FrmTraSach_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtrasach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtNgayHenTra_TraSach;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtNgayMuon_TraSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMaDG_TraSach;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView Dgvtrasach;
        private System.Windows.Forms.ComboBox cbomacuonsach;
        private System.Windows.Forms.TextBox txtsomuonid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpngaytrasach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltienphat;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}