
namespace QLNhanVien
{
    partial class PhongBan
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
            this.tbMaphongban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenphongban = new System.Windows.Forms.TextBox();
            this.dgrPhongBan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng ban";
            // 
            // tbMaphongban
            // 
            this.tbMaphongban.Location = new System.Drawing.Point(131, 34);
            this.tbMaphongban.Name = "tbMaphongban";
            this.tbMaphongban.Size = new System.Drawing.Size(100, 20);
            this.tbMaphongban.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng ban";
            // 
            // tbTenphongban
            // 
            this.tbTenphongban.Location = new System.Drawing.Point(131, 80);
            this.tbTenphongban.Name = "tbTenphongban";
            this.tbTenphongban.Size = new System.Drawing.Size(100, 20);
            this.tbTenphongban.TabIndex = 3;
            // 
            // dgrPhongBan
            // 
            this.dgrPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgrPhongBan.Location = new System.Drawing.Point(12, 231);
            this.dgrPhongBan.Name = "dgrPhongBan";
            this.dgrPhongBan.Size = new System.Drawing.Size(386, 150);
            this.dgrPhongBan.TabIndex = 4;
            this.dgrPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrPhongBan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaphongban";
            this.Column1.HeaderText = "Mã phòng ban";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenphongban";
            this.Column2.HeaderText = "Tên phòng ban";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(270, 120);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 24;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(156, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(156, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(53, 165);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 21;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 393);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrPhongBan);
            this.Controls.Add(this.tbTenphongban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaphongban);
            this.Controls.Add(this.label1);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaphongban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenphongban;
        private System.Windows.Forms.DataGridView dgrPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnThem;
    }
}