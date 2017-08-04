namespace BTL.HienThi
{
    partial class NhomHang
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
            this.txt_sTenNhomhang = new System.Windows.Forms.TextBox();
            this.txt_sMota = new System.Windows.Forms.TextBox();
            this.lb_sTenNhomhang = new System.Windows.Forms.Label();
            this.lb_sMota = new System.Windows.Forms.Label();
            this.dataNhomHang = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhomHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sTenNhomhang
            // 
            this.txt_sTenNhomhang.Location = new System.Drawing.Point(136, 19);
            this.txt_sTenNhomhang.Name = "txt_sTenNhomhang";
            this.txt_sTenNhomhang.Size = new System.Drawing.Size(197, 20);
            this.txt_sTenNhomhang.TabIndex = 0;
            this.txt_sTenNhomhang.Validating += new System.ComponentModel.CancelEventHandler(this.txt_sTenNhomhang_Validating);
            // 
            // txt_sMota
            // 
            this.txt_sMota.Location = new System.Drawing.Point(136, 55);
            this.txt_sMota.Name = "txt_sMota";
            this.txt_sMota.Size = new System.Drawing.Size(198, 20);
            this.txt_sMota.TabIndex = 1;
            // 
            // lb_sTenNhomhang
            // 
            this.lb_sTenNhomhang.AutoSize = true;
            this.lb_sTenNhomhang.Location = new System.Drawing.Point(15, 19);
            this.lb_sTenNhomhang.Name = "lb_sTenNhomhang";
            this.lb_sTenNhomhang.Size = new System.Drawing.Size(82, 13);
            this.lb_sTenNhomhang.TabIndex = 2;
            this.lb_sTenNhomhang.Text = "Tên nhóm hàng";
            // 
            // lb_sMota
            // 
            this.lb_sMota.AutoSize = true;
            this.lb_sMota.Location = new System.Drawing.Point(15, 55);
            this.lb_sMota.Name = "lb_sMota";
            this.lb_sMota.Size = new System.Drawing.Size(34, 13);
            this.lb_sMota.TabIndex = 3;
            this.lb_sMota.Text = "Mô tả";
            // 
            // dataNhomHang
            // 
            this.dataNhomHang.AllowUserToAddRows = false;
            this.dataNhomHang.AllowUserToDeleteRows = false;
            this.dataNhomHang.AllowUserToResizeRows = false;
            this.dataNhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhomHang.Location = new System.Drawing.Point(0, 151);
            this.dataNhomHang.MultiSelect = false;
            this.dataNhomHang.Name = "dataNhomHang";
            this.dataNhomHang.ReadOnly = true;
            this.dataNhomHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNhomHang.Size = new System.Drawing.Size(721, 294);
            this.dataNhomHang.TabIndex = 4;
            this.dataNhomHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhomHang_CellClick);
            this.dataNhomHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhomHang_CellContentClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(525, 11);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(82, 28);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Location = new System.Drawing.Point(625, 41);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 27);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(643, 86);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(64, 49);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Thoát";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Enabled = false;
            this.btn_sua.Location = new System.Drawing.Point(525, 41);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(82, 27);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(625, 11);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(82, 27);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(525, 74);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(82, 30);
            this.btn_Tim.TabIndex = 8;
            this.btn_Tim.Text = "Tìm Kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 445);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataNhomHang);
            this.Controls.Add(this.lb_sMota);
            this.Controls.Add(this.lb_sTenNhomhang);
            this.Controls.Add(this.txt_sMota);
            this.Controls.Add(this.txt_sTenNhomhang);
            this.Name = "NhomHang";
            this.Text = "Nhóm hàng";
            this.Load += new System.EventHandler(this.NhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhomHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sTenNhomhang;
        private System.Windows.Forms.TextBox txt_sMota;
        private System.Windows.Forms.Label lb_sTenNhomhang;
        private System.Windows.Forms.Label lb_sMota;
        private System.Windows.Forms.DataGridView dataNhomHang;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Tim;
    }
}