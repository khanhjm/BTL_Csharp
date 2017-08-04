namespace BTL.HienThi
{
    partial class HangHoa
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
            this.lb_TenHangHoa = new System.Windows.Forms.Label();
            this.Lb_NhaCungCap = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.lb_BaoHanh = new System.Windows.Forms.Label();
            this.txt_TenHangHoa = new System.Windows.Forms.TextBox();
            this.txt_NhaCC = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_BaoHanh = new System.Windows.Forms.TextBox();
            this.dataHangHoa = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cb_NhomHang = new System.Windows.Forms.ComboBox();
            this.lb_NhomHang = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TenHangHoa
            // 
            this.lb_TenHangHoa.AutoSize = true;
            this.lb_TenHangHoa.Location = new System.Drawing.Point(19, 11);
            this.lb_TenHangHoa.Name = "lb_TenHangHoa";
            this.lb_TenHangHoa.Size = new System.Drawing.Size(74, 13);
            this.lb_TenHangHoa.TabIndex = 0;
            this.lb_TenHangHoa.Text = "Tên hàng hóa";
            // 
            // Lb_NhaCungCap
            // 
            this.Lb_NhaCungCap.AutoSize = true;
            this.Lb_NhaCungCap.Location = new System.Drawing.Point(19, 51);
            this.Lb_NhaCungCap.Name = "Lb_NhaCungCap";
            this.Lb_NhaCungCap.Size = new System.Drawing.Size(75, 13);
            this.Lb_NhaCungCap.TabIndex = 1;
            this.Lb_NhaCungCap.Text = "Nhà cung cấp";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(19, 103);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(49, 13);
            this.lb_SoLuong.TabIndex = 2;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Location = new System.Drawing.Point(305, 51);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(46, 13);
            this.lb_DonGia.TabIndex = 3;
            this.lb_DonGia.Text = "Đơn Giá";
            // 
            // lb_BaoHanh
            // 
            this.lb_BaoHanh.AutoSize = true;
            this.lb_BaoHanh.Location = new System.Drawing.Point(305, 96);
            this.lb_BaoHanh.Name = "lb_BaoHanh";
            this.lb_BaoHanh.Size = new System.Drawing.Size(99, 13);
            this.lb_BaoHanh.TabIndex = 4;
            this.lb_BaoHanh.Text = "Thời gian bảo hành";
            // 
            // txt_TenHangHoa
            // 
            this.txt_TenHangHoa.Location = new System.Drawing.Point(109, 8);
            this.txt_TenHangHoa.Name = "txt_TenHangHoa";
            this.txt_TenHangHoa.Size = new System.Drawing.Size(147, 20);
            this.txt_TenHangHoa.TabIndex = 0;
            // 
            // txt_NhaCC
            // 
            this.txt_NhaCC.Location = new System.Drawing.Point(109, 51);
            this.txt_NhaCC.Name = "txt_NhaCC";
            this.txt_NhaCC.Size = new System.Drawing.Size(147, 20);
            this.txt_NhaCC.TabIndex = 2;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(107, 96);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(147, 20);
            this.txt_SoLuong.TabIndex = 3;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(422, 48);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(147, 20);
            this.txt_DonGia.TabIndex = 4;
            // 
            // txt_BaoHanh
            // 
            this.txt_BaoHanh.Location = new System.Drawing.Point(422, 89);
            this.txt_BaoHanh.Name = "txt_BaoHanh";
            this.txt_BaoHanh.Size = new System.Drawing.Size(147, 20);
            this.txt_BaoHanh.TabIndex = 5;
            // 
            // dataHangHoa
            // 
            this.dataHangHoa.AllowUserToAddRows = false;
            this.dataHangHoa.AllowUserToDeleteRows = false;
            this.dataHangHoa.AllowUserToResizeRows = false;
            this.dataHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangHoa.Location = new System.Drawing.Point(-2, 161);
            this.dataHangHoa.MultiSelect = false;
            this.dataHangHoa.Name = "dataHangHoa";
            this.dataHangHoa.ReadOnly = true;
            this.dataHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHangHoa.Size = new System.Drawing.Size(784, 257);
            this.dataHangHoa.TabIndex = 10;
            this.dataHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangHoa_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(615, 15);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(696, 15);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Location = new System.Drawing.Point(615, 58);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 31);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(696, 58);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 31);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(696, 103);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 44);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cb_NhomHang
            // 
            this.cb_NhomHang.FormattingEnabled = true;
            this.cb_NhomHang.Location = new System.Drawing.Point(422, 7);
            this.cb_NhomHang.Name = "cb_NhomHang";
            this.cb_NhomHang.Size = new System.Drawing.Size(147, 21);
            this.cb_NhomHang.TabIndex = 1;
            // 
            // lb_NhomHang
            // 
            this.lb_NhomHang.AutoSize = true;
            this.lb_NhomHang.Location = new System.Drawing.Point(305, 10);
            this.lb_NhomHang.Name = "lb_NhomHang";
            this.lb_NhomHang.Size = new System.Drawing.Size(64, 13);
            this.lb_NhomHang.TabIndex = 17;
            this.lb_NhomHang.Text = "Nhóm Hàng";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(615, 105);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(74, 25);
            this.btn_Tim.TabIndex = 18;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 417);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.lb_NhomHang);
            this.Controls.Add(this.cb_NhomHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataHangHoa);
            this.Controls.Add(this.txt_BaoHanh);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_NhaCC);
            this.Controls.Add(this.txt_TenHangHoa);
            this.Controls.Add(this.lb_BaoHanh);
            this.Controls.Add(this.lb_DonGia);
            this.Controls.Add(this.lb_SoLuong);
            this.Controls.Add(this.Lb_NhaCungCap);
            this.Controls.Add(this.lb_TenHangHoa);
            this.Name = "HangHoa";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TenHangHoa;
        private System.Windows.Forms.Label Lb_NhaCungCap;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.Label lb_BaoHanh;
        private System.Windows.Forms.TextBox txt_TenHangHoa;
        private System.Windows.Forms.TextBox txt_NhaCC;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_BaoHanh;
        private System.Windows.Forms.DataGridView dataHangHoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cb_NhomHang;
        private System.Windows.Forms.Label lb_NhomHang;
        private System.Windows.Forms.Button btn_Tim;
    }
}