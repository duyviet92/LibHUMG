namespace LibHUMG
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.btndausach = new DevComponents.DotNetBar.ButtonItem();
            this.btncuonsach = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnnxb = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btndocgia = new DevComponents.DotNetBar.ButtonItem();
            this.btnnhanvien = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnmuon = new DevComponents.DotNetBar.ButtonItem();
            this.btntra = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btndangxuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.Rbhethong = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribquanlydanhmuc = new DevComponents.DotNetBar.RibbonTabItem();
            this.RbmuonTra = new DevComponents.DotNetBar.RibbonTabItem();
            this.InHoaDon = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Rbhethong,
            this.ribquanlydanhmuc,
            this.RbmuonTra});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(609, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar5);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(609, 99);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btndausach,
            this.btncuonsach});
            this.ribbonBar5.Location = new System.Drawing.Point(331, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(127, 96);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar5.TabIndex = 2;
            // 
            // btndausach
            // 
            this.btndausach.Image = ((System.Drawing.Image)(resources.GetObject("btndausach.Image")));
            this.btndausach.ImagePaddingHorizontal = 8;
            this.btndausach.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btndausach.Name = "btndausach";
            this.btndausach.PressedImage = ((System.Drawing.Image)(resources.GetObject("btndausach.PressedImage")));
            this.btndausach.Text = "Đầu Sách";
            this.btndausach.Click += new System.EventHandler(this.btndausach_Click);
            // 
            // btncuonsach
            // 
            this.btncuonsach.Image = ((System.Drawing.Image)(resources.GetObject("btncuonsach.Image")));
            this.btncuonsach.ImagePaddingHorizontal = 8;
            this.btncuonsach.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btncuonsach.Name = "btncuonsach";
            this.btncuonsach.Text = "Cuốn Sách";
            this.btncuonsach.Click += new System.EventHandler(this.btncuonsach_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnnxb,
            this.buttonItem2,
            this.buttonItem3});
            this.ribbonBar3.Location = new System.Drawing.Point(125, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(206, 96);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 1;
            // 
            // btnnxb
            // 
            this.btnnxb.Image = ((System.Drawing.Image)(resources.GetObject("btnnxb.Image")));
            this.btnnxb.ImagePaddingHorizontal = 8;
            this.btnnxb.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnnxb.Name = "btnnxb";
            this.btnnxb.Text = "Nhà Xuất Bản";
            this.btnnxb.Click += new System.EventHandler(this.btnnxb_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Tác Giả";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.ImagePaddingHorizontal = 8;
            this.buttonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "Thể Loại";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btndocgia,
            this.btnnhanvien});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(122, 96);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 0;
            // 
            // btndocgia
            // 
            this.btndocgia.Image = ((System.Drawing.Image)(resources.GetObject("btndocgia.Image")));
            this.btndocgia.ImagePaddingHorizontal = 8;
            this.btndocgia.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btndocgia.Name = "btndocgia";
            this.btndocgia.Text = "Độc Giả";
            this.btndocgia.Click += new System.EventHandler(this.btndocgia_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.Image")));
            this.btnnhanvien.ImagePaddingHorizontal = 8;
            this.btnnhanvien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Controls.Add(this.ribbonBar4);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(609, 99);
            this.ribbonPanel3.TabIndex = 3;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnmuon,
            this.btntra,
            this.InHoaDon});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(204, 96);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar4.TabIndex = 0;
            this.ribbonBar4.Text = "Mượn Trả";
            // 
            // btnmuon
            // 
            this.btnmuon.Image = ((System.Drawing.Image)(resources.GetObject("btnmuon.Image")));
            this.btnmuon.ImagePaddingHorizontal = 8;
            this.btnmuon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnmuon.Name = "btnmuon";
            this.btnmuon.Text = "Mượn Sách";
            this.btnmuon.Click += new System.EventHandler(this.btnmuon_Click);
            // 
            // btntra
            // 
            this.btntra.Image = ((System.Drawing.Image)(resources.GetObject("btntra.Image")));
            this.btntra.ImagePaddingHorizontal = 8;
            this.btntra.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btntra.Name = "btntra";
            this.btntra.Text = "Trả Sách";
            this.btntra.Click += new System.EventHandler(this.btntra_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(609, 99);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btndangxuat,
            this.btnthoat});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(122, 96);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Hệ Thống";
            // 
            // btndangxuat
            // 
            this.btndangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btndangxuat.Image")));
            this.btndangxuat.ImagePaddingHorizontal = 8;
            this.btndangxuat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Text = "Đăng Xuất";
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.ImagePaddingVertical = 8;
            this.btnthoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Rbhethong
            // 
            this.Rbhethong.ImagePaddingHorizontal = 8;
            this.Rbhethong.Name = "Rbhethong";
            this.Rbhethong.Panel = this.ribbonPanel1;
            this.Rbhethong.Text = "Quản Lý Hệ Thống";
            // 
            // ribquanlydanhmuc
            // 
            this.ribquanlydanhmuc.ImagePaddingHorizontal = 8;
            this.ribquanlydanhmuc.Name = "ribquanlydanhmuc";
            this.ribquanlydanhmuc.Panel = this.ribbonPanel2;
            this.ribquanlydanhmuc.Text = "Quản Lý Danh Mục";
            // 
            // RbmuonTra
            // 
            this.RbmuonTra.Checked = true;
            this.RbmuonTra.ImagePaddingHorizontal = 8;
            this.RbmuonTra.Name = "RbmuonTra";
            this.RbmuonTra.Panel = this.ribbonPanel3;
            this.RbmuonTra.Text = "Mượn Trả";
            // 
            // InHoaDon
            // 
            this.InHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("InHoaDon.Image")));
            this.InHoaDon.ImagePaddingHorizontal = 8;
            this.InHoaDon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.InHoaDon.Name = "InHoaDon";
            this.InHoaDon.Text = "In Hóa Đơn";
            this.InHoaDon.Click += new System.EventHandler(this.InHoaDon_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 435);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem Rbhethong;
        private DevComponents.DotNetBar.RibbonTabItem ribquanlydanhmuc;
        private DevComponents.DotNetBar.ButtonItem btndangxuat;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnmuon;
        private DevComponents.DotNetBar.ButtonItem btntra;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnnxb;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btndocgia;
        private DevComponents.DotNetBar.ButtonItem btnnhanvien;
        private DevComponents.DotNetBar.RibbonTabItem RbmuonTra;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem btndausach;
        private DevComponents.DotNetBar.ButtonItem btncuonsach;
        private DevComponents.DotNetBar.ButtonItem InHoaDon;
    }
}