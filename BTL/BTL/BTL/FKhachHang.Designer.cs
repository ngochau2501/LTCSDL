namespace BTL
{
    partial class FKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gVKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTimKH = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.btTKH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVKhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(416, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gVKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 487);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // gVKhachHang
            // 
            this.gVKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVKhachHang.Location = new System.Drawing.Point(19, 22);
            this.gVKhachHang.Name = "gVKhachHang";
            this.gVKhachHang.Size = new System.Drawing.Size(702, 459);
            this.gVKhachHang.TabIndex = 0;
            this.gVKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVKhachHang_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReport);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btTimKH);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSdt);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Location = new System.Drawing.Point(772, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 487);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // btReport
            // 
            this.btReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.Image = ((System.Drawing.Image)(resources.GetObject("btReport.Image")));
            this.btReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.Location = new System.Drawing.Point(179, 356);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(134, 80);
            this.btReport.TabIndex = 16;
            this.btReport.Text = "Báo cáo";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(332, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 80);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tải lại";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::BTL.Properties.Resources.Stop;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(333, 356);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(134, 80);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::BTL.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(15, 356);
            this.btXoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(134, 80);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTimKH
            // 
            this.btTimKH.BackColor = System.Drawing.SystemColors.Control;
            this.btTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKH.Image = global::BTL.Properties.Resources.Upload;
            this.btTimKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKH.Location = new System.Drawing.Point(179, 262);
            this.btTimKH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btTimKH.Name = "btTimKH";
            this.btTimKH.Size = new System.Drawing.Size(134, 80);
            this.btTimKH.TabIndex = 14;
            this.btTimKH.Text = "Sửa";
            this.btTimKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKH.UseVisualStyleBackColor = false;
            this.btTimKH.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.Control;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::BTL.Properties.Resources.free_icons_round_up_84;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(15, 261);
            this.btThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(134, 80);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng:";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(143, 193);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(231, 22);
            this.txtSdt.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(143, 89);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(231, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(143, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(143, 44);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(231, 22);
            this.txtMaKH.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(787, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(915, 47);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(231, 22);
            this.txtKH.TabIndex = 4;
            // 
            // btTKH
            // 
            this.btTKH.Location = new System.Drawing.Point(1157, 38);
            this.btTKH.Name = "btTKH";
            this.btTKH.Size = new System.Drawing.Size(81, 41);
            this.btTKH.TabIndex = 5;
            this.btTKH.Text = "Tìm kiếm";
            this.btTKH.UseVisualStyleBackColor = true;
            this.btTKH.Click += new System.EventHandler(this.btTKH_Click);
            // 
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 590);
            this.Controls.Add(this.btTKH);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FKhachHang";
            this.Text = "Quản lí khác hàng";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVKhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView gVKhachHang;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTimKH;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Button btTKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btReport;
    }
}