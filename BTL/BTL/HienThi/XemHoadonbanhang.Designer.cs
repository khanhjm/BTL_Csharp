namespace BTL.HienThi
{
    partial class XemHoadonbanhang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhachhang = new System.Windows.Forms.TextBox();
            this.txtTenNhanvien = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.dateThoigianban = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtHoadonbanhangID = new System.Windows.Forms.MaskedTextBox();
            this.txtNhanvienID = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxNgay = new System.Windows.Forms.CheckBox();
            this.checkBoxThang = new System.Windows.Forms.CheckBox();
            this.checkBoxNam = new System.Windows.Forms.CheckBox();
            this.dataGridViewHoadonbanhang = new System.Windows.Forms.DataGridView();
            this.iHoadonbanhangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNhanvienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dThoigianban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonTaobaocao = new System.Windows.Forms.Button();
            this.buttonBoqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadonbanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // txtTenKhachhang
            // 
            this.txtTenKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachhang.Location = new System.Drawing.Point(128, 44);
            this.txtTenKhachhang.Name = "txtTenKhachhang";
            this.txtTenKhachhang.Size = new System.Drawing.Size(145, 23);
            this.txtTenKhachhang.TabIndex = 3;
            this.txtTenKhachhang.TextChanged += new System.EventHandler(this.txtTenKhachhang_TextChanged);
            // 
            // txtTenNhanvien
            // 
            this.txtTenNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanvien.Location = new System.Drawing.Point(399, 44);
            this.txtTenNhanvien.Name = "txtTenNhanvien";
            this.txtTenNhanvien.Size = new System.Drawing.Size(144, 23);
            this.txtTenNhanvien.TabIndex = 4;
            this.txtTenNhanvien.TextChanged += new System.EventHandler(this.txtTenNhanvien_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(128, 73);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(145, 23);
            this.txtDiachi.TabIndex = 5;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // dateThoigianban
            // 
            this.dateThoigianban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThoigianban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateThoigianban.Location = new System.Drawing.Point(129, 103);
            this.dateThoigianban.Name = "dateThoigianban";
            this.dateThoigianban.Size = new System.Drawing.Size(144, 23);
            this.dateThoigianban.TabIndex = 11;
            this.dateThoigianban.ValueChanged += new System.EventHandler(this.dateThoigianban_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thời gian bán";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(399, 75);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(144, 20);
            this.txtSdt.TabIndex = 6;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            // 
            // txtHoadonbanhangID
            // 
            this.txtHoadonbanhangID.Location = new System.Drawing.Point(129, 16);
            this.txtHoadonbanhangID.Mask = "00000000";
            this.txtHoadonbanhangID.Name = "txtHoadonbanhangID";
            this.txtHoadonbanhangID.Size = new System.Drawing.Size(144, 20);
            this.txtHoadonbanhangID.TabIndex = 1;
            this.txtHoadonbanhangID.TextChanged += new System.EventHandler(this.txtHoadonbanhangID_TextChanged);
            // 
            // txtNhanvienID
            // 
            this.txtNhanvienID.Location = new System.Drawing.Point(399, 16);
            this.txtNhanvienID.Mask = "00000000";
            this.txtNhanvienID.Name = "txtNhanvienID";
            this.txtNhanvienID.Size = new System.Drawing.Size(144, 20);
            this.txtNhanvienID.TabIndex = 2;
            this.txtNhanvienID.TextChanged += new System.EventHandler(this.txtNhanvienID_TextChanged);
            // 
            // checkBoxNgay
            // 
            this.checkBoxNgay.AutoSize = true;
            this.checkBoxNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNgay.Location = new System.Drawing.Point(303, 107);
            this.checkBoxNgay.Name = "checkBoxNgay";
            this.checkBoxNgay.Size = new System.Drawing.Size(60, 21);
            this.checkBoxNgay.TabIndex = 16;
            this.checkBoxNgay.Text = "Ngày";
            this.checkBoxNgay.UseVisualStyleBackColor = true;
            this.checkBoxNgay.CheckedChanged += new System.EventHandler(this.checkBoxNgay_CheckedChanged);
            // 
            // checkBoxThang
            // 
            this.checkBoxThang.AutoSize = true;
            this.checkBoxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxThang.Location = new System.Drawing.Point(369, 107);
            this.checkBoxThang.Name = "checkBoxThang";
            this.checkBoxThang.Size = new System.Drawing.Size(68, 21);
            this.checkBoxThang.TabIndex = 17;
            this.checkBoxThang.Text = "Tháng";
            this.checkBoxThang.UseVisualStyleBackColor = true;
            this.checkBoxThang.CheckedChanged += new System.EventHandler(this.checkBoxThang_CheckedChanged);
            // 
            // checkBoxNam
            // 
            this.checkBoxNam.AutoSize = true;
            this.checkBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNam.Location = new System.Drawing.Point(443, 107);
            this.checkBoxNam.Name = "checkBoxNam";
            this.checkBoxNam.Size = new System.Drawing.Size(56, 21);
            this.checkBoxNam.TabIndex = 18;
            this.checkBoxNam.Text = "Năm";
            this.checkBoxNam.UseVisualStyleBackColor = true;
            this.checkBoxNam.CheckedChanged += new System.EventHandler(this.checkBoxNam_CheckedChanged);
            // 
            // dataGridViewHoadonbanhang
            // 
            this.dataGridViewHoadonbanhang.AllowUserToAddRows = false;
            this.dataGridViewHoadonbanhang.AllowUserToDeleteRows = false;
            this.dataGridViewHoadonbanhang.AllowUserToResizeRows = false;
            this.dataGridViewHoadonbanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoadonbanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoadonbanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iHoadonbanhangID,
            this.iNhanvienID,
            this.sTenNhanvien,
            this.sTenKhachhang,
            this.sDiachi,
            this.sSdt,
            this.dThoigianban,
            this.iTongtien});
            this.dataGridViewHoadonbanhang.EnableHeadersVisualStyles = false;
            this.dataGridViewHoadonbanhang.Location = new System.Drawing.Point(12, 146);
            this.dataGridViewHoadonbanhang.MultiSelect = false;
            this.dataGridViewHoadonbanhang.Name = "dataGridViewHoadonbanhang";
            this.dataGridViewHoadonbanhang.ReadOnly = true;
            this.dataGridViewHoadonbanhang.RowHeadersVisible = false;
            this.dataGridViewHoadonbanhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoadonbanhang.Size = new System.Drawing.Size(689, 333);
            this.dataGridViewHoadonbanhang.TabIndex = 19;
            this.dataGridViewHoadonbanhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoadonbanhang_CellClick);
            this.dataGridViewHoadonbanhang.DoubleClick += new System.EventHandler(this.dataGridViewHoadonbanhang_DoubleClick);
            // 
            // iHoadonbanhangID
            // 
            this.iHoadonbanhangID.DataPropertyName = "PK_iHoadonbanhangID";
            this.iHoadonbanhangID.HeaderText = "Mã hóa đơn";
            this.iHoadonbanhangID.Name = "iHoadonbanhangID";
            this.iHoadonbanhangID.ReadOnly = true;
            // 
            // iNhanvienID
            // 
            this.iNhanvienID.DataPropertyName = "FK_iNhanvienID";
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
            this.sTenNhanvien.Visible = false;
            // 
            // sTenKhachhang
            // 
            this.sTenKhachhang.DataPropertyName = "sTenKhachhang";
            this.sTenKhachhang.HeaderText = "Tên khách hàng";
            this.sTenKhachhang.Name = "sTenKhachhang";
            this.sTenKhachhang.ReadOnly = true;
            // 
            // sDiachi
            // 
            this.sDiachi.DataPropertyName = "sDiachi";
            this.sDiachi.HeaderText = "Địa chỉ";
            this.sDiachi.Name = "sDiachi";
            this.sDiachi.ReadOnly = true;
            // 
            // sSdt
            // 
            this.sSdt.DataPropertyName = "sSdt";
            this.sSdt.HeaderText = "SĐT";
            this.sSdt.Name = "sSdt";
            this.sSdt.ReadOnly = true;
            // 
            // dThoigianban
            // 
            this.dThoigianban.DataPropertyName = "dThoigianban";
            this.dThoigianban.HeaderText = "Thời gian bán";
            this.dThoigianban.Name = "dThoigianban";
            this.dThoigianban.ReadOnly = true;
            // 
            // iTongtien
            // 
            this.iTongtien.DataPropertyName = "iTongtien";
            this.iTongtien.HeaderText = "Tổng tiền";
            this.iTongtien.Name = "iTongtien";
            this.iTongtien.ReadOnly = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(593, 14);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(109, 23);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Xem chi tiết";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(593, 43);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(109, 23);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonTaobaocao
            // 
            this.buttonTaobaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaobaocao.Location = new System.Drawing.Point(593, 76);
            this.buttonTaobaocao.Name = "buttonTaobaocao";
            this.buttonTaobaocao.Size = new System.Drawing.Size(109, 23);
            this.buttonTaobaocao.TabIndex = 9;
            this.buttonTaobaocao.Text = "Tạo báo cáo";
            this.buttonTaobaocao.UseVisualStyleBackColor = true;
            this.buttonTaobaocao.Click += new System.EventHandler(this.buttonTaobaocao_Click);
            // 
            // buttonBoqua
            // 
            this.buttonBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoqua.Location = new System.Drawing.Point(593, 105);
            this.buttonBoqua.Name = "buttonBoqua";
            this.buttonBoqua.Size = new System.Drawing.Size(109, 23);
            this.buttonBoqua.TabIndex = 10;
            this.buttonBoqua.Text = "Bỏ qua";
            this.buttonBoqua.UseVisualStyleBackColor = true;
            this.buttonBoqua.Click += new System.EventHandler(this.buttonBoqua_Click);
            // 
            // XemHoadonbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.buttonBoqua);
            this.Controls.Add(this.buttonTaobaocao);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.dataGridViewHoadonbanhang);
            this.Controls.Add(this.checkBoxNam);
            this.Controls.Add(this.checkBoxThang);
            this.Controls.Add(this.checkBoxNgay);
            this.Controls.Add(this.txtNhanvienID);
            this.Controls.Add(this.txtHoadonbanhangID);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateThoigianban);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenNhanvien);
            this.Controls.Add(this.txtTenKhachhang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XemHoadonbanhang";
            this.Text = "Danh mục hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.XemHoadonbanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadonbanhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKhachhang;
        private System.Windows.Forms.TextBox txtTenNhanvien;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.DateTimePicker dateThoigianban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.MaskedTextBox txtHoadonbanhangID;
        private System.Windows.Forms.MaskedTextBox txtNhanvienID;
        private System.Windows.Forms.CheckBox checkBoxNgay;
        private System.Windows.Forms.CheckBox checkBoxThang;
        private System.Windows.Forms.CheckBox checkBoxNam;
        private System.Windows.Forms.DataGridView dataGridViewHoadonbanhang;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonTaobaocao;
        private System.Windows.Forms.Button buttonBoqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoadonbanhangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNhanvienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dThoigianban;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTongtien;
    }
}