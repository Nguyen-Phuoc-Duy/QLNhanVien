using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNhanVien
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            hienNhanVien();
        }

        private void hienNhanVien()
        {
            using (DataTable tblNhanvien = getNhanVien())
            {
                DataView dvNhanvien = new DataView(tblNhanvien);
                dgrNhanVien.AutoGenerateColumns = false;
                dgrNhanVien.ReadOnly = true;
                dgrNhanVien.DataSource = dvNhanvien;
            }
            //throw new NotImplementedException();
        }

        private DataTable getNhanVien()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc1"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spNhanvien_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblNhanvien");
                        Da.Fill(tbl);
                        return tbl;

                    }
                }
            }
            //throw new NotImplementedException();
        }

        private void dgrNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbManhanvien.Text = dgrNhanVien.CurrentRow.Cells[0].Value.ToString();
            tbHoten.Text = dgrNhanVien.CurrentRow.Cells[1].Value.ToString();

            tbDiachi.Text = dgrNhanVien.CurrentRow.Cells[5].Value.ToString();
            tbMaphongban.Text = dgrNhanVien.CurrentRow.Cells[6].Value.ToString();


            rbNam.Checked = (bool)dgrNhanVien.CurrentRow.Cells[2].Value;
            rbNu.Checked = !(bool)dgrNhanVien.CurrentRow.Cells[2].Value;
            /*if (dgrKhachhang.CurrentRow.Cells[5].Value.ToString().Equals(1))
            { 
                rbNu.Checked = true;
            }
            else
            {
                rbNam.Checked = true;
            }*/
            tbDienthoai.Text = dgrNhanVien.CurrentRow.Cells[4].Value.ToString();
            dtNgaysinh.Text = dgrNhanVien.CurrentRow.Cells[3].Value.ToString();


            dgrNhanVien.Enabled = true;
        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc1"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))

            {
                /*if (kiemtra() == 1)
                {
                    MessageBox.Show("Trùng khóa chính không thể thêm", "Thông báo");
                    tbMakhachhang.Focus();
                }
                else if (isNumber(tbDienthoai.Text) == false)
                {
                    MessageBox.Show("SĐT chỉ nhận số, dài 10 ký tự, bắt đầu bằng số 0 và số thứ 2 khác 0", "Thông báo");
                    tbDienthoai.Focus();
                }
                else if (kiemtraCMND() == 1)
                {

                    MessageBox.Show("Trùng CMND rồi, không thể thêm", "Thông báo");
                    tbCMND.Focus();
                }
                else if ((isNumber1(tbCMND.Text) == false) && (isNumber2(tbCMND.Text) == false))
                {
                    MessageBox.Show("CMND phải có 9-12 kí tự", "Thông báo");
                    tbCMND.Focus();
                }
                else
                {*/
                using (SqlCommand Cmd = new SqlCommand("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.CommandText = "spNhanvien_Insert";

                    Cmd.Parameters.AddWithValue("@sManhanvien", tbManhanvien.Text);


                    Cmd.Parameters.AddWithValue("@sHoten", tbHoten.Text);
                    Cmd.Parameters.AddWithValue("@sMaphongban", tbMaphongban.Text);
                    Cmd.Parameters.AddWithValue("@sDiachi", tbDiachi.Text);
                    Cmd.Parameters.AddWithValue("@sDienthoai", tbDienthoai.Text);
                    Cmd.Parameters.AddWithValue("@bGioitinh", rbNam.Checked);
                    Cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(dtNgaysinh.Text));
                    DialogResult dg = MessageBox.Show("Bạn thêm thành công", "Thông báo");
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    hienNhanVien();
                }
            }


        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            tbManhanvien.Text
            = tbHoten.Text
            = tbDienthoai.Text
                    = tbDiachi.Text
                    = tbMaphongban.Text
                    = String.Empty;
            dtNgaysinh.ResetText();
            tbManhanvien.Focus();

            hienNhanVien();
            dgrNhanVien.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc1"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))

            {
                /*if (kiemtra() == 1)
                {
                    MessageBox.Show("Trùng khóa chính không thể thêm", "Thông báo");
                    tbMakhachhang.Focus();
                }
                else if (isNumber(tbDienthoai.Text) == false)
                {
                    MessageBox.Show("SĐT chỉ nhận số, dài 10 ký tự, bắt đầu bằng số 0 và số thứ 2 khác 0", "Thông báo");
                    tbDienthoai.Focus();
                }
                else if (kiemtraCMND() == 1)
                {

                    MessageBox.Show("Trùng CMND rồi, không thể thêm", "Thông báo");
                    tbCMND.Focus();
                }
                else if ((isNumber1(tbCMND.Text) == false) && (isNumber2(tbCMND.Text) == false))
                {
                    MessageBox.Show("CMND phải có 9-12 kí tự", "Thông báo");
                    tbCMND.Focus();
                }
                else
                {*/
                using (SqlCommand Cmd = new SqlCommand("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.CommandText = "spNhanvien_Update";

                    Cmd.Parameters.AddWithValue("@sManhanvien", tbManhanvien.Text);


                    Cmd.Parameters.AddWithValue("@sHoten", tbHoten.Text);
                    Cmd.Parameters.AddWithValue("@sMaphongban", tbMaphongban.Text);
                    Cmd.Parameters.AddWithValue("@sDiachi", tbDiachi.Text);
                    Cmd.Parameters.AddWithValue("@sDienthoai", tbDienthoai.Text);
                    Cmd.Parameters.AddWithValue("@bGioitinh", rbNam.Checked);
                    Cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(dtNgaysinh.Text));
                    DialogResult dg = MessageBox.Show("Bạn sửa thành công", "Thông báo");
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    hienNhanVien();
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?"
               , "Khẳng định"
               , MessageBoxButtons.YesNo
               , MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;

                try
                {
                    DataView dvNhanvien = (DataView)dgrNhanVien.DataSource;
                    DataRowView drvNhanvien = dvNhanvien[dgrNhanVien.CurrentRow.Index];
                    string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc1"].ConnectionString;
                    using (SqlConnection Cnn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand Cmd = new SqlCommand("spNhanvien_Delete", Cnn))
                        {
                            Cmd.CommandType = CommandType.StoredProcedure;
                            Cmd.Parameters.AddWithValue("@sManhanvien", drvNhanvien["sManhanvien"]);
                            Cnn.Open();
                            Cmd.ExecuteNonQuery();
                            Cnn.Close();
                            btnBoqua_Click(sender, e);
                            hienNhanVien();
                        }
                        //Cmd
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE"))
                        MessageBox.Show("Nhân viên có dữ liệu liên quan, không xoá được"
                            , "Kết quả"
                            , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Đã có lỗi xảy ra, hãy liên hệ với đội ngũ kĩ thuật"
                            , "Kết quả"
                            , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlNhanLuc1"].ConnectionString;
            string tim = "select * from tblNhanvien where sManhanvien is not null";
            if (tbManhanvien.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sManhanvien like'%" + tbManhanvien.Text + "%'";
            }
           
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgrNhanVien.DataSource = tb;
                    }

                }
            }
        }
    }
}
    

