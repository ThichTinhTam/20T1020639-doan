using _20T1020639_doan.DAL;
using _20T1020639_doan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20T1020639_doan.BLL
{
    public class bllTaiKhoan
    {
        dalTaiKhoan dtk = new dalTaiKhoan();

        public bool DangNhap(dtoTaiKhoan tk)
        {
            return dtk.KiemTraDangNhap(tk);
        }

        public dtoTaiKhoan TaiKhoanDangNhap(dtoTaiKhoan tk)
        {
            return dtk.TaiKhoanDangNhap(tk);
        }

        public bool ThemTK(dtoTaiKhoan tk)
        {
            return dtk.ThemTK(tk);
        }
    }
}
