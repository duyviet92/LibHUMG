namespace LibHUMG
{
    partial class SoMuonTra
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
            this.tabmuon = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvmuontra = new System.Windows.Forms.DataGridView();
            this.SoMuonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnChoMuon = new System.Windows.Forms.Button();
            this.btnMuonMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsomuonid = new System.Windows.Forms.TextBox();
            this.cbomacuonsach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabmuon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuontra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabmuon
            // 
            this.tabmuon.BackColor = System.Drawing.Color.White;
            this.tabmuon.Controls.Add(this.groupBox3);
            this.tabmuon.Controls.Add(this.btnKetThuc);
            this.tabmuon.Controls.Add(this.btnChoMuon);
            this.tabmuon.Controls.Add(this.btnMuonMoi);
            this.tabmuon.Controls.Add(this.groupBox2);
            this.tabmuon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabmuon.Location = new System.Drawing.Point(4, 25);
            this.tabmuon.Margin = new System.Windows.Forms.Padding(4);
            this.tabmuon.Name = "tabmuon";
            this.tabmuon.Padding = new System.Windows.Forms.Padding(4);
            this.tabmuon.Size = new System.Drawing.Size(868, 649);
            this.tabmuon.TabIndex = 0;
            this.tabmuon.Text = "Quản Lý Mượn Sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvmuontra);
            this.groupBox3.Location = new System.Drawing.Point(13, 294);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(851, 269);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Cho Mượn";
            // 
            // dgvmuontra
            // 
            this.dgvmuontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmuontra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoMuonID,
            this.TenCuonSach,
            this.DocGiaID,
            this.NgayMuon,
            this.NgayTra});
            this.dgvmuontra.Location = new System.Drawing.Point(8, 34);
            this.dgvmuontra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvmuontra.Name = "dgvmuontra";
            this.dgvmuontra.Size = new System.Drawing.Size(835, 223);
            this.dgvmuontra.TabIndex = 0;
            // 
            // SoMuonID
            // 
            this.SoMuonID.HeaderText = "Sổ Mượn ID";
            this.SoMuonID.Name = "SoMuonID";
            this.SoMuonID.Width = 200;
            // 
            // TenCuonSach
            // 
            this.TenCuonSach.HeaderText = "Tên Cuốn Sách ";
            this.TenCuonSach.Name = "TenCuonSach";
            this.TenCuonSach.Width = 160;
            // 
            // DocGiaID
            // 
            this.DocGiaID.HeaderText = "Mã Độc Giả ";
            this.DocGiaID.Name = "DocGiaID";
            this.DocGiaID.Width = 150;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 150;
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 150;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(536, 191);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(141, 36);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnChoMuon
            // 
            this.btnChoMuon.Location = new System.Drawing.Point(536, 120);
            this.btnChoMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoMuon.Name = "btnChoMuon";
            this.btnChoMuon.Size = new System.Drawing.Size(141, 39);
            this.btnChoMuon.TabIndex = 3;
            this.btnChoMuon.Text = "Cho Mượn";
            this.btnChoMuon.UseVisualStyleBackColor = true;
            this.btnChoMuon.Click += new System.EventHandler(this.btnChoMuon_Click);
            // 
            // btnMuonMoi
            // 
            this.btnMuonMoi.Location = new System.Drawing.Point(536, 39);
            this.btnMuonMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuonMoi.Name = "btnMuonMoi";
            this.btnMuonMoi.Size = new System.Drawing.Size(141, 44);
            this.btnMuonMoi.TabIndex = 2;
            this.btnMuonMoi.Text = "Mượn Mới";
            this.btnMuonMoi.UseVisualStyleBackColor = true;
            this.btnMuonMoi.Click += new System.EventHandler(this.btnMuonMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtsomuonid);
            this.groupBox2.Controls.Add(this.cbomacuonsach);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtNgayHenTra);
            this.groupBox2.Controls.Add(this.dtNgayMuon);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbMaDG);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(21, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(476, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực Hiện Cho Mượn";
            // 
            // txtsomuonid
            // 
            this.txtsomuonid.Location = new System.Drawing.Point(219, 24);
            this.txtsomuonid.Margin = new System.Windows.Forms.Padding(4);
            this.txtsomuonid.Name = "txtsomuonid";
            this.txtsomuonid.Size = new System.Drawing.Size(240, 29);
            this.txtsomuonid.TabIndex = 6;
            this.txtsomuonid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbomacuonsach
            // 
            this.cbomacuonsach.FormattingEnabled = true;
            this.cbomacuonsach.Location = new System.Drawing.Point(219, 117);
            this.cbomacuonsach.Margin = new System.Windows.Forms.Padding(4);
            this.cbomacuonsach.Name = "cbomacuonsach";
            this.cbomacuonsach.Size = new System.Drawing.Size(240, 30);
            this.cbomacuonsach.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sổ Mượn ID:";
            // 
            // dtNgayHenTra
            // 
            this.dtNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHenTra.Location = new System.Drawing.Point(219, 239);
            this.dtNgayHenTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayHenTra.Name = "dtNgayHenTra";
            this.dtNgayHenTra.Size = new System.Drawing.Size(240, 29);
            this.dtNgayHenTra.TabIndex = 3;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(219, 177);
            this.dtNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(240, 29);
            this.dtNgayMuon.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 244);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ngày Hẹn Trả:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 180);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày Mượn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên Sách:";
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(219, 66);
            this.cbMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(240, 30);
            this.cbMaDG.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Độc Giả:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabmuon);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 678);
            this.tabControl1.TabIndex = 1;
            // 
            // SoMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 587);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SoMuonTra";
            this.Text = "SoMuonTra";
            this.Load += new System.EventHandler(this.SoMuonTra_Load);
            this.tabmuon.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuontra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabmuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvmuontra;
        private System.Windows.Forms.Button btnChoMuon;
        private System.Windows.Forms.Button btnMuonMoi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ComboBox cbomacuonsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsomuonid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayHenTra;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMuonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;

    }
}