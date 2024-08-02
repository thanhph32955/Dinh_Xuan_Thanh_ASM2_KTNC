using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string Hoten { get; set; }
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string Masv { get; set; }

        public SinhVien(string id, string hoten, string malop, string tenlop, string masv)
        {
            Id = id;
            Hoten = hoten;
            Malop = malop;
            Tenlop = tenlop;
            Masv = masv;
        }     
    }

    public class SinhVienpoly
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sv)
        {
            if (Regex.IsMatch(sv.Tenlop, @"[!@#$%^&*(),.?""{}|<>]")||sv.Tenlop.Any(ch => !char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)))
            {
                throw new ArgumentException("Tenlop không chứa ký tự đặc biệt.");
            }
            danhSachSinhVien.Add(sv);
        }
        public string TimKiemTheoMaSV(string masv)
        {
            return danhSachSinhVien.FirstOrDefault(sv => sv.Masv.Equals(masv, StringComparison.OrdinalIgnoreCase)).Masv;
        }
    }
}
