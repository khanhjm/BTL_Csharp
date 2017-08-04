namespace BTL.HienThi
{
    partial class Nhanvien
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
            this.dataGridViewtblNhanvien = new System.Windows.Forms.DataGridView();
            this.iNhanvienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUserNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPassNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanvien = new System.Windows.Forms.TextBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.txtUserNV = new System.Windows.Forms.TextBox();
            this.txtPassNV = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonBoqua = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.nhaplaipass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtblNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewtblNhanvien
            // 
            this.dataGridViewtblNhanvien.AllowUserToAddRows = false;
            this.dataGridViewtblNhanvien.AllowUserToDeleteRows = false;
            this.dataGridViewtblNhanvien.AllowUserToResizeRows = false;
            this.dataGridViewtblNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewtblNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtblNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNhanvienID,
            this.sTenNhanvien,
            this.dNgaysinh,
            this.bGioitinh,
            this.sChucvu,
            this.sUserNV,
            this.sPassNV});
            this.dataGridViewtblNhanvien.Location = new System.Drawing.Point(10, 245);
            this.dataGridViewtblNhanvien.MultiSelect = false;
            this.dataGridViewtblNhanvien.Name = "dataGridViewtblNhanvien";
            this.dataGridViewtblNhanvien.ReadOnly = true;
            this.dataGridViewtblNhanvien.RowHeadersVisible = false;
            this.dataGridViewtblNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewtblNhanvien.Size = new System.Drawing.Size(581, 268);
            this.dataGridViewtblNhanvien.TabIndex = 0;
            this.dataGridViewtblNhanvien.Tag = "13";
            this.dataGridViewtblNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtblNhanvien_CellClick);
            // 
            // iNhanvienID
            // 
            this.iNhanvienID.DataPropertyName = "PK_iNhanvienID";
            this.iNhanvienID.HeaderText = "Mã nhân viên";
            this.iNhanvienID.Name = "iNhanvienID";
            this.iNhanvienID.ReadOnly = true;
            // 
            // sTenNhanvien
            // 
            this.sTenNhanvien.DataPropertyName = "sTenNhanvien";
            this.sTenNhanvien.HeaderText = "Tên nhân viên";
            this.sTenNhanvien.Name = "sTenNhanvien";
            this.sTenNhanvien.ReadOnly = true;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.DataPropertyName = "dNgaysinh";
            this.dNgaysinh.HeaderText = "Ngày sinh";
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.ReadOnly = true;
            // 
            // bGioitinh
            // 
            this.bGioitinh.DataPropertyName = "bGioitinh";
            this.bGioitinh.HeaderText = "Giới tính";
            this.bGioitinh.Name = "bGioitinh";
            this.bGioitinh.ReadOnly = true;
            // 
            // sChucvu
            // 
            this.sChucvu.DataPropertyName = "sChucvu";
            this.sChucvu.HeaderText = "Chức vụ";
            this.sChucvu.Name = "sChucvu";
            this.sChucvu.ReadOnly = true;
            // 
            // sUserNV
            // 
            this.sUserNV.DataPropertyName = "sUserNV";
            this.sUserNV.HeaderText = "User";
            this.sUserNV.Name = "sUserNV";
            this.sUserNV.ReadOnly = true;
            // 
            // sPassNV
            // 
            this.sPassNV.DataPropertyName = "sPassNV";
            this.sPassNV.HeaderText = "Password";
            this.sPassNV.Name = "sPassNV";
            this.sPassNV.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên đăng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật khẩu";
            // 
            // txtTenNhanvien
            // 
            this.txtTenNhanvien.Location = new System.Drawing.Point(118, 20);
            this.txtTenNhanvien.Name = "txtTenNhanvien";
            this.txtTenNhanvien.Size = new System.Drawing.Size(200, 20);
            this.txtTenNhanvien.TabIndex = 8;
            this.txtTenNhanvien.Tag = "1";
            this.txtTenNhanvien.TextChanged += new System.EventHandler(this.txtTenNhanvien_TextChanged);
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.CustomFormat = "";
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaysinh.Location = new System.Drawing.Point(118, 74);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dateNgaysinh.TabIndex = 9;
            this.dateNgaysinh.Tag = "4";
            // 
            // txtChucvu
            // 
            this.txtChucvu.Location = new System.Drawing.Point(118, 105);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(200, 20);
            this.txtChucvu.TabIndex = 10;
            this.txtChucvu.Tag = "5";
            this.txtChucvu.TextChanged += new System.EventHandler(this.txtChucvu_TextChanged);
            // 
            // txtUserNV
            // 
            this.txtUserNV.Location = new System.Drawing.Point(118, 136);
            this.txtUserNV.Name = "txtUserNV";
            this.txtUserNV.Size = new System.Drawing.Size(200, 20);
            this.txtUserNV.TabIndex = 11;
            this.txtUserNV.Tag = "6";
            this.txtUserNV.TextChanged += new System.EventHandler(this.txtUserNV_TextChanged);
            // 
            // txtPassNV
            // 
            this.txtPassNV.Location = new System.Drawing.Point(118, 167);
            this.txtPassNV.Name = "txtPassNV";
            this.txtPassNV.Size = new System.Drawing.Size(200, 20);
            this.txtPassNV.TabIndex = 12;
            this.txtPassNV.Tag = "7";
            this.txtPassNV.TextChanged += new System.EventHandler(this.txtPassNV_TextChanged);
            // 
            // buttonThem
            // 
            this.buttonThem.Enabled = false;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(386, 23);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 38);
            this.buttonThem.TabIndex = 13;
            this.buttonThem.Tag = "8";
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Enabled = false;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(499, 24);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 38);
            this.buttonSua.TabIndex = 14;
            this.buttonSua.Tag = "10";
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Enabled = false;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(499, 84);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 38);
            this.buttonXoa.TabIndex = 15;
            this.buttonXoa.Tag = "11";
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonBoqua
            // 
            this.buttonBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoqua.Location = new System.Drawing.Point(386, 139);
            this.buttonBoqua.Name = "buttonBoqua";
            this.buttonBoqua.Size = new System.Drawing.Size(75, 38);
            this.buttonBoqua.TabIndex = 16;
            this.buttonBoqua.Tag = "12";
            this.buttonBoqua.Text = "Bỏ qua";
            this.buttonBoqua.UseVisualStyleBackColor = true;
            this.buttonBoqua.Click += new System.EventHandler(this.buttonBoqua_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(386, 84);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 38);
            this.buttonTim.TabIndex = 17;
            this.buttonTim.Tag = "9";
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giới tính";
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Checked = true;
            this.radioNam.Location = new System.Drawing.Point(118, 50);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 19;
            this.radioNam.TabStop = true;
            this.radioNam.Tag = "2";
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(210, 51);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 20;
            this.radioNu.Tag = "3";
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(499, 139);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 38);
            this.buttonThoat.TabIndex = 21;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // nhaplaipass
            // 
            this.nhaplaipass.Location = new System.Drawing.Point(118, 193);
            this.nhaplaipass.Name = "nhaplaipass";
            this.nhaplaipass.Size = new System.Drawing.Size(200, 20);
            this.nhaplaipass.TabIndex = 22;
            this.nhaplaipass.Tag = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nhap lai MK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nhaplaipass);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.buttonBoqua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.txtPassNV);
            this.Controls.Add(this.txtUserNV);
            this.Controls.Add(this.txtChucvu);
            this.Controls.Add(this.dateNgaysinh);
            this.Controls.Add(this.txtTenNhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewtblNhanvien);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtblNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtblNhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanvien;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.TextBox txtUserNV;
        private System.Windows.Forms.TextBox txtPassNV;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonBoqua;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNhanvienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUserNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPassNV;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox nhaplaipass;
        private System.Windows.Forms.Label label1;
    }
}