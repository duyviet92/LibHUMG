namespace LibHUMG
{
    partial class FrmDauSach
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
            this.dgvdausach = new System.Windows.Forms.DataGridView();
            this.DauSachID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TomTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NxbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoaiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCuonCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.Btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtdausachid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsocon = new System.Windows.Forms.TextBox();
            this.txttomtat = new System.Windows.Forms.TextBox();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.txtthoihan = new System.Windows.Forms.TextBox();
            this.txttongluot = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.cbotheloai = new System.Windows.Forms.ComboBox();
            this.cbonxb = new System.Windows.Forms.ComboBox();
            this.cbotacgia = new System.Windows.Forms.ComboBox();
            this.txtmadausach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdausach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdausach
            // 
            this.dgvdausach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdausach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DauSachID,
            this.MaDauSach,
            this.TenSach,
            this.TomTat,
            this.TuKhoa,
            this.NxbID,
            this.TacGiaID,
            this.TheLoaiID,
            this.ThoiHan,
            this.TongLuotMuon,
            this.SoCuonCon});
            this.dgvdausach.Location = new System.Drawing.Point(16, 324);
            this.dgvdausach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdausach.Name = "dgvdausach";
            this.dgvdausach.Size = new System.Drawing.Size(953, 325);
            this.dgvdausach.TabIndex = 43;
            this.dgvdausach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdausach_CellClick);
            // 
            // DauSachID
            // 
            this.DauSachID.HeaderText = "Đầu Sách ID";
            this.DauSachID.Name = "DauSachID";
            // 
            // MaDauSach
            // 
            this.MaDauSach.HeaderText = "Mã Đầu Sách";
            this.MaDauSach.Name = "MaDauSach";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // TomTat
            // 
            this.TomTat.HeaderText = "Tóm Tắt";
            this.TomTat.Name = "TomTat";
            // 
            // TuKhoa
            // 
            this.TuKhoa.HeaderText = "Từ Khóa";
            this.TuKhoa.Name = "TuKhoa";
            // 
            // NxbID
            // 
            this.NxbID.HeaderText = "Tên Nxb";
            this.NxbID.Name = "NxbID";
            // 
            // TacGiaID
            // 
            this.TacGiaID.HeaderText = "Tên Tác Giả";
            this.TacGiaID.Name = "TacGiaID";
            // 
            // TheLoaiID
            // 
            this.TheLoaiID.HeaderText = "Tên Thể Loại";
            this.TheLoaiID.Name = "TheLoaiID";
            // 
            // ThoiHan
            // 
            this.ThoiHan.HeaderText = "Thời Hạn";
            this.ThoiHan.Name = "ThoiHan";
            // 
            // TongLuotMuon
            // 
            this.TongLuotMuon.HeaderText = "Tổng Lượt Mượn";
            this.TongLuotMuon.Name = "TongLuotMuon";
            // 
            // SoCuonCon
            // 
            this.SoCuonCon.HeaderText = "Số Cuốn Còn";
            this.SoCuonCon.Name = "SoCuonCon";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(532, 655);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 147;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Btnluu
            // 
            this.Btnluu.Location = new System.Drawing.Point(144, 655);
            this.Btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.Btnluu.Name = "Btnluu";
            this.Btnluu.Size = new System.Drawing.Size(100, 28);
            this.Btnluu.TabIndex = 146;
            this.Btnluu.Text = "Lưu";
            this.Btnluu.UseVisualStyleBackColor = true;
            this.Btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(16, 655);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 145;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(272, 655);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 144;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(392, 655);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 143;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtdausachid
            // 
            this.txtdausachid.Location = new System.Drawing.Point(189, 56);
            this.txtdausachid.Margin = new System.Windows.Forms.Padding(4);
            this.txtdausachid.Name = "txtdausachid";
            this.txtdausachid.Size = new System.Drawing.Size(209, 22);
            this.txtdausachid.TabIndex = 169;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 168;
            this.label11.Text = " Đầu Sách ID";
            // 
            // txtsocon
            // 
            this.txtsocon.Location = new System.Drawing.Point(587, 269);
            this.txtsocon.Margin = new System.Windows.Forms.Padding(4);
            this.txtsocon.Name = "txtsocon";
            this.txtsocon.Size = new System.Drawing.Size(209, 22);
            this.txtsocon.TabIndex = 167;
            // 
            // txttomtat
            // 
            this.txttomtat.Location = new System.Drawing.Point(587, 63);
            this.txttomtat.Margin = new System.Windows.Forms.Padding(4);
            this.txttomtat.Name = "txttomtat";
            this.txttomtat.Size = new System.Drawing.Size(209, 22);
            this.txttomtat.TabIndex = 166;
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(587, 116);
            this.txttukhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(209, 22);
            this.txttukhoa.TabIndex = 165;
            // 
            // txtthoihan
            // 
            this.txtthoihan.Location = new System.Drawing.Point(587, 170);
            this.txtthoihan.Margin = new System.Windows.Forms.Padding(4);
            this.txtthoihan.Name = "txtthoihan";
            this.txtthoihan.Size = new System.Drawing.Size(209, 22);
            this.txtthoihan.TabIndex = 164;
            // 
            // txttongluot
            // 
            this.txttongluot.Location = new System.Drawing.Point(587, 222);
            this.txttongluot.Margin = new System.Windows.Forms.Padding(4);
            this.txttongluot.Name = "txttongluot";
            this.txttongluot.Size = new System.Drawing.Size(209, 22);
            this.txttongluot.TabIndex = 163;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(189, 296);
            this.txttensach.Margin = new System.Windows.Forms.Padding(4);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(209, 22);
            this.txttensach.TabIndex = 162;
            // 
            // cbotheloai
            // 
            this.cbotheloai.FormattingEnabled = true;
            this.cbotheloai.Location = new System.Drawing.Point(189, 254);
            this.cbotheloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbotheloai.Name = "cbotheloai";
            this.cbotheloai.Size = new System.Drawing.Size(209, 24);
            this.cbotheloai.TabIndex = 161;
            // 
            // cbonxb
            // 
            this.cbonxb.FormattingEnabled = true;
            this.cbonxb.Location = new System.Drawing.Point(189, 194);
            this.cbonxb.Margin = new System.Windows.Forms.Padding(4);
            this.cbonxb.Name = "cbonxb";
            this.cbonxb.Size = new System.Drawing.Size(209, 24);
            this.cbonxb.TabIndex = 160;
            // 
            // cbotacgia
            // 
            this.cbotacgia.FormattingEnabled = true;
            this.cbotacgia.Location = new System.Drawing.Point(189, 138);
            this.cbotacgia.Margin = new System.Windows.Forms.Padding(4);
            this.cbotacgia.Name = "cbotacgia";
            this.cbotacgia.Size = new System.Drawing.Size(209, 24);
            this.cbotacgia.TabIndex = 159;
            // 
            // txtmadausach
            // 
            this.txtmadausach.Location = new System.Drawing.Point(189, 96);
            this.txtmadausach.Margin = new System.Windows.Forms.Padding(4);
            this.txtmadausach.Name = "txtmadausach";
            this.txtmadausach.Size = new System.Drawing.Size(209, 22);
            this.txtmadausach.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 157;
            this.label6.Text = "Số Cuốn còn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 156;
            this.label7.Text = "Tổng Lượt Mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 155;
            this.label8.Text = "Thời Hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 154;
            this.label9.Text = "Từ Khóa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 153;
            this.label10.Text = "Tóm Tắt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 152;
            this.label5.Text = "Tên Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 151;
            this.label4.Text = "Tên Thể Loại ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 150;
            this.label3.Text = "Tên Nxb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 149;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 148;
            this.label12.Text = "Mã Đầu Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 170;
            this.label1.Text = "THÔNG TIN ĐẦU SÁCH";
            // 
            // FrmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdausachid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsocon);
            this.Controls.Add(this.txttomtat);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.txtthoihan);
            this.Controls.Add(this.txttongluot);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.cbotheloai);
            this.Controls.Add(this.cbonxb);
            this.Controls.Add(this.cbotacgia);
            this.Controls.Add(this.txtmadausach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.Btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.dgvdausach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDauSach";
            this.Text = "FrmDauSach";
            this.Load += new System.EventHandler(this.FrmDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdausach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdausach;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button Btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txtdausachid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsocon;
        private System.Windows.Forms.TextBox txttomtat;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.TextBox txtthoihan;
        private System.Windows.Forms.TextBox txttongluot;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.ComboBox cbotheloai;
        private System.Windows.Forms.ComboBox cbonxb;
        private System.Windows.Forms.ComboBox cbotacgia;
        private System.Windows.Forms.TextBox txtmadausach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DauSachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TomTat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NxbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoaiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuotMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCuonCon;
        private System.Windows.Forms.Label label1;
    }
}