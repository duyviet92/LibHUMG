namespace LibHUMG
{
    partial class FrmTacGia
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTacGiaid = new System.Windows.Forms.TextBox();
            this.DgvTacGia = new System.Windows.Forms.DataGridView();
            this.TacGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaTacGia = new System.Windows.Forms.TextBox();
            this.txttenTacGia = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.Btnluu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tác Giả ID";
            // 
            // txtTacGiaid
            // 
            this.txtTacGiaid.Location = new System.Drawing.Point(153, 30);
            this.txtTacGiaid.Name = "txtTacGiaid";
            this.txtTacGiaid.Size = new System.Drawing.Size(141, 20);
            this.txtTacGiaid.TabIndex = 22;
            // 
            // DgvTacGia
            // 
            this.DgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TacGiaID,
            this.MaTacGia,
            this.TenTacGia});
            this.DgvTacGia.Location = new System.Drawing.Point(16, 125);
            this.DgvTacGia.Name = "DgvTacGia";
            this.DgvTacGia.Size = new System.Drawing.Size(399, 150);
            this.DgvTacGia.TabIndex = 21;
            this.DgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTacGia_CellClick);
            // 
            // TacGiaID
            // 
            this.TacGiaID.HeaderText = "Tác Giả ID";
            this.TacGiaID.Name = "TacGiaID";
            // 
            // MaTacGia
            // 
            this.MaTacGia.HeaderText = "Mã Tác Giả";
            this.MaTacGia.Name = "MaTacGia";
            // 
            // TenTacGia
            // 
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Tác Gỉa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Tác Giả";
            // 
            // txtmaTacGia
            // 
            this.txtmaTacGia.Location = new System.Drawing.Point(153, 64);
            this.txtmaTacGia.Name = "txtmaTacGia";
            this.txtmaTacGia.Size = new System.Drawing.Size(141, 20);
            this.txtmaTacGia.TabIndex = 18;
            // 
            // txttenTacGia
            // 
            this.txttenTacGia.Location = new System.Drawing.Point(153, 96);
            this.txttenTacGia.Name = "txttenTacGia";
            this.txttenTacGia.Size = new System.Drawing.Size(141, 20);
            this.txttenTacGia.TabIndex = 17;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(340, 281);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 16;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Btnluu
            // 
            this.Btnluu.Location = new System.Drawing.Point(97, 281);
            this.Btnluu.Name = "Btnluu";
            this.Btnluu.Size = new System.Drawing.Size(75, 23);
            this.Btnluu.TabIndex = 15;
            this.Btnluu.Text = "Lưu";
            this.Btnluu.UseVisualStyleBackColor = true;
            this.Btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(178, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(259, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(149, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 107;
            this.label4.Text = "TÁC GIẢ";
            // 
            // FrmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTacGiaid);
            this.Controls.Add(this.DgvTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaTacGia);
            this.Controls.Add(this.txttenTacGia);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.Btnluu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Name = "FrmTacGia";
            this.Text = "FrmTacGia";
            this.Load += new System.EventHandler(this.FrmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTacGiaid;
        private System.Windows.Forms.DataGridView DgvTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaTacGia;
        private System.Windows.Forms.TextBox txttenTacGia;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button Btnluu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.Label label4;
    }
}