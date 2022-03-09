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
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            hienPhongBan();
        }

        private void hienPhongBan()
        {
            using (DataTable tblPhongban = getPhongBan())
            {
                DataView dvPhongban = new DataView(tblPhongban);
                dgrPhongBan.AutoGenerateColumns = false;
                dgrPhongBan.ReadOnly = true;
                dgrPhongBan.DataSource = dvPhongban;
            }
        }

        private DataTable getPhongBan()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spPhongban_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblPhongban");
                        Da.Fill(tbl);
                        return tbl;
                    }
                }
            }
            //throw new NotImplementedException();
        }

        private void dgrPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaphongban.Text = dgrPhongBan.CurrentRow.Cells[0].Value.ToString();
            tbTenphongban.Text = dgrPhongBan.CurrentRow.Cells[1].Value.ToString();

            /*if (dgrKhachhang.CurrentRow.Cells[5].Value.ToString().Equals(1))
            { 
                rbNu.Checked = true;
            }
            else
            {
                rbNam.Checked = true;
            }*/

            dgrPhongBan.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                
                using (SqlCommand Cmd = new SqlCommand("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.CommandText = "spPhongban_Insert";
                    Cmd.Parameters.AddWithValue("@sMaphongban", tbMaphongban.Text);
                    Cmd.Parameters.AddWithValue("@sTenphongban", tbTenphongban.Text);
                    DialogResult dg = MessageBox.Show("Bạn thêm thành công", "Thông báo");
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    hienPhongBan();
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            tbMaphongban.Text
            = tbTenphongban.Text           
                    = String.Empty;
            hienPhongBan();
            dgrPhongBan.Enabled = true;
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
                    DataView dvPhongban = (DataView)dgrPhongBan.DataSource;
                    DataRowView drvPhongban = dvPhongban[dgrPhongBan.CurrentRow.Index];
                    string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
                    using (SqlConnection Cnn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand Cmd = new SqlCommand("spPhongban_Delete", Cnn))
                        {
                            Cmd.CommandType = CommandType.StoredProcedure;
                            Cmd.Parameters.AddWithValue("@sMaphongban", drvPhongban["sMaphongban"]);
                            Cnn.Open();
                            Cmd.ExecuteNonQuery();
                            Cnn.Close();
                            btnBoqua_Click(sender, e);
                            hienPhongBan();
                        }
                        //Cmd
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE"))
                        MessageBox.Show("Phòng ban có dữ liệu liên quan, không xoá được"
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
            string constr = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            string tim = "select * from tblPhongban where sMaphongban is not null";
            if (tbMaphongban.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sMaphongban like'%" + tbMaphongban.Text + "%'";
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgrPhongBan.DataSource = tb;
                    }

                }
            }
        }
    }
}
