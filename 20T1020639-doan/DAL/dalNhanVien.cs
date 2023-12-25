using _20T1020639_doan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20T1020639_doan.DAL
{
    public class dalNhanVien : Database
    {
        public dtoNhanVien NhanVienDangNhap(dtoTaiKhoan tk)
        {
            dtoNhanVien nv = new dtoNhanVien();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM [NV] WHERE [MaNhanVien] = @ma";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = tk.Username;
            sqlCmd.Parameters.Add(parMa);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = (string)reader.GetSqlString(1);
                DateTime ngaySinh = reader.GetDateTime(2);
                string sdt = reader.GetString(3);

                nv.MaNhanVien = ma;
                nv.HoTen = ten;
                nv.NgaySinh = ngaySinh;
                nv.SoDienThoai = sdt;

            }
            reader.Close();
            return nv;
        }

        public List<string> DanhSachID()
        {
            List<string> ds = new List<string>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from [NV]";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);

                ds.Add(ma);
            }
            reader.Close();
            return ds;

        }

        public DataTable HienThiDanhSach()
        {
            OpenConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [NV]", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CloseConnection();
            return dt;
        }

        public bool ThemNV(dtoNhanVien nv)
        {
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO [NV] VALUES (MaNhanVien, HoTen, NgaySinh, SoDienThoai)";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMa = new SqlParameter("MaNhanVien", SqlDbType.VarChar);
            parMa.Value = nv.MaNhanVien;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("HoTen", SqlDbType.NVarChar);
            parTen.Value = nv.HoTen;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parNS = new SqlParameter("NgaySinh", SqlDbType.Date);
            parNS.Value = nv.NgaySinh;
            sqlCmd.Parameters.Add(parNS);

            SqlParameter parSDT = new SqlParameter("SoDienThoai", SqlDbType.VarChar);
            parSDT.Value = nv.SoDienThoai;
            sqlCmd.Parameters.Add(parSDT);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaNV(string ma)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "Xoa_NV";
            sqlCmd.Parameters.AddWithValue("MaNhanVien", ma);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
