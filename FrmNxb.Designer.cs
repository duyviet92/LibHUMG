namespace LibHUMG
{
    partial class FrmNxb
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
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.Btnluu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgvnxb = new System.Windows.Forms.DataGridView();
            this.NxbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnxbid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvnxb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(264, 286);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(183, 286);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Btnluu
            // 
            this.Btnluu.Location = new System.Drawing.Point(102, 286);
            this.Btnluu.Name = "Btnluu";
            this.Btnluu.Size = new System.Drawing.Size(75, 23);
            this.Btnluu.TabIndex = 3;
            this.Btnluu.Text = "Lưu";
            this.Btnluu.UseVisualStyleBackColor = true;
            this.Btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(345, 286);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(161, 103);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(141, 20);
            this.txttennxb.TabIndex = 5;
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(161, 71);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(141, 20);
            this.txtmanxb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Nxb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Nxb";
            // 
            // Dgvnxb
            // 
            this.Dgvnxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvnxb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NxbID,
            this.MaNxb,
            this.Tennxb});
            this.Dgvnxb.Location = new System.Drawing.Point(21, 130);
            this.Dgvnxb.Name = "Dgvnxb";
            this.Dgvnxb.Size = new System.Drawing.Size(399, 150);
            this.Dgvnxb.TabIndex = 9;
            this.Dgvnxb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvnxb_CellClick);
            // 
            // NxbID
            // 
            this.NxbID.HeaderText = "NxbID";
            this.NxbID.Name = "NxbID";
            // 
            // MaNxb
            // 
            this.MaNxb.HeaderText = "Mã Nxb";
            this.MaNxb.Name = "MaNxb";
            // 
            // Tennxb
            // 
            this.Tennxb.HeaderText = "Tên Nxb";
            this.Tennxb.Name = "Tennxb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "NxbID";
            // 
            // txtnxbid
            // 
            this.txtnxbid.Location = new System.Drawing.Point(161, 37);
            this.txtnxbid.Name = "txtnxbid";
            this.txtnxbid.Size = new System.Drawing.Size(141, 20);
            this.txtnxbid.TabIndex = 10;
            this.txtnxbid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(127, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 107;
            this.label4.Text = "NHÀ XUẤT BẢN";
            // 
            // FrmNxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnxbid);
            this.Controls.Add(this.Dgvnxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmanxb);
            this.Controls.Add(this.txttennxb);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.Btnluu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Name = "FrmNxb";
            this.Text = "FrmNxb";
            this.Load += new System.EventHandler(this.FrmNxb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvnxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button Btnluu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgvnxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NxbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnxbid;
        private System.Windows.Forms.Label label4;
    }
}