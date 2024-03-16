using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang
{
    internal class SinhVien
    {
        private int maSinhVien;
        private string tenSinhVien;
        private double dtb;
        private int maKhoa;

        public SinhVien() { }

        public SinhVien(int maSinhVien, string tenSinhVien, double dtb, int maKhoa)
        {
            this.MaSinhVien = maSinhVien;
            this.TenSinhVien = tenSinhVien;
            this.Dtb = dtb;
            this.MaKhoa = maKhoa;
        }

        public int MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string TenSinhVien { get => tenSinhVien; set => tenSinhVien = value; }
        public double Dtb { get => dtb; set => dtb = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
