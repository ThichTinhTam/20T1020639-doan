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
    public class dalTaiKhoan : Database
    {
        public bool KiemTraDangNhap(dtoTaiKhoan tk)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Tai_khoan_login";
            cmd.Parameters.AddWithValue("@UserName", tk.Username);
            cmd.Parameters.AddWithValue("@Password", tk.Password);
            cmd.Connection = sqlCon;
            int kq = Convert.ToInt32(cmd.ExecuteScalar());
            if (kq == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public dtoTaiKhoan TaiKhoanDangNhap(dtoTaiKhoan tk)
        {
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT [Phanquyen] FROM [TaiKhoan] WHERE [Username] = @ma";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = tk.Username;
            sqlCmd.Parameters.Add(parMa);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string admin = reader.GetString(0);

                tk.Phanquyen = admin;

            }
            reader.Close();
            return tk;
        }

        public bool ThemTK(dtoTaiKhoan tk)
        {
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO [TaiKhoan] VALUES (@user, @pass, @chucvu)";
            sqlCmd.Connection = sqlCon;

            SqlParameter parUser = new SqlParameter("@user", SqlDbType.VarChar);
            parUser.Value = tk.Username;
            sqlCmd.Parameters.Add(parUser);

            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.VarChar);
            parPass.Value = tk.Password;
            sqlCmd.Parameters.Add(parPass);

            SqlParameter parAd = new SqlParameter("@chucvu", SqlDbType.VarChar);
            parAd.Value = tk.Phanquyen;
            sqlCmd.Parameters.Add(parAd);


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
