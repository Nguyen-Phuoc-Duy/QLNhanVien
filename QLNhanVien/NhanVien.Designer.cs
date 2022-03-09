
namespace QLNhanVien
{
    partial class NhanVien
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
            this.dgrNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManhanvien = new System.Windows.Forms.TextBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbDienthoai = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbMaphongban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrNhanVien
            // 
            this.dgrNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgrNhanVien.Location = new System.Drawing.Point(1, 198);
            this.dgrNhanVien.Name = "dgrNhanVien";
            this.dgrNhanVien.Size = new System.Drawing.Size(680, 150);
            this.dgrNhanVien.TabIndex = 0;
            this.dgrNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sManhanvien";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sHoten";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bGioitinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tNgaysinh";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sDienthoai";
            this.Column5.HeaderText = "Điện thoại";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sDiachi";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sMaphongban";
            this.Column7.HeaderText = "Mã phòng ban";
            this.Column7.Name = "Column7";
            // 
            // tbManhanvien
            // 
            this.tbManhanvien.Location = new System.Drawing.Point(106, 9);
            this.tbManhanvien.Name = "tbManhanvien";
            this.tbManhanvien.Size = new System.Drawing.Size(100, 20);
            this.tbManhanvien.TabIndex = 1;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(106, 60);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(100, 20);
            this.tbHoten.TabIndex = 2;
            // 
            // tbDienthoai
            // 
            this.tbDienthoai.Location = new System.Drawing.Point(106, 111);
            this.tbDienthoai.Name = "tbDienthoai";
            this.tbDienthoai.Size = new System.Drawing.Size(100, 20);
            this.tbDienthoai.TabIndex = 3;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(360, 12);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(100, 20);
            this.tbDiachi.TabIndex = 4;
            // 
            // tbMaphongban
            // 
            this.tbMaphongban.Location = new System.Drawing.Point(366, 59);
            this.tbMaphongban.Name = "tbMaphongban";
            this.tbMaphongban.Size = new System.Drawing.Size(100, 20);
            this.tbMaphongban.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã phòng ban";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(366, 111);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 12;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(467, 111);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 13;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(537, 11);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(131, 20);
            this.dtNgaysinh.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(106, 157);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(260, 157);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 16;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(384, 157);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(476, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(582, 157);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 19;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 355);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaphongban);
            this.Controls.Add(this.tbDiachi);
            this.Controls.Add(this.tbDienthoai);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.tbManhanvien);
            this.Controls.Add(this.dgrNhanVien);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox tbManhanvien;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbDienthoai;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbMaphongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimkiem;
    }
}