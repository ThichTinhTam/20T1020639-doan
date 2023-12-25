using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20T1020639_doan.DTO
{
    public class dtoNhanVien
    {
      
            private string _ma;
            private string _ten;
            private DateTime _ns;
            private string _sdt;

            public dtoNhanVien(string ma, string ten, DateTime ns, string sdt)
            {
                _ma = ma;
                _ten = ten;
                _ns = ns;
                _sdt = sdt;
            }

            public dtoNhanVien()
            {
            }

            public string MaNhanVien { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh { get; set; }
            public string SoDienThoai { get; set; }
        }
    }

