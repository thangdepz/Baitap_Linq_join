namespace _21115053120145_huynhkimthang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Khoa> khoas = new List<Khoa>
            {
                new Khoa(1, "Cong nghe so"),
                new Khoa(2, "Dien - Dien tu"),
                new Khoa(3, "Xay dung"),
                new Khoa(4, "Co khi"),
            };
            List<SinhVien> sinhViens = new List<SinhVien>
            {
                new SinhVien(1, "Huynh Kim Thang", 8, 1),
                new SinhVien(2, "Hoang Van Son", 7, 1),
                new SinhVien(3, "Dinh Cong Minh", 7, 4),
                new SinhVien(4, "Le Xuan Thang", 8, 4),
            };
            
            Console.WriteLine($"Danh sách sinh viên theo khoa, sap xep theo tên:");
            foreach (var khoa in khoas)
            {
                Console.WriteLine($"Danh sách sinh viên cua khoa {khoa.TenKhoa}:");
                var sinhVienTrongKhoa = from sv in sinhViens
                                        where sv.MaKhoa == khoa.MaKhoa
                                        orderby sv.TenSinhVien
                                        select sv;
                foreach (var sv in sinhVienTrongKhoa)
                {
                    Console.WriteLine($"- {sv.TenSinhVien}");
                }
            }
           
            var dtmlonhon7 = sinhViens.Where(sinhvien => sinhvien.Dtb > 7).ToList();
            Console.WriteLine();
            Console.WriteLine($"Danh sách sinh viên có điểm trung bình lon hơn 7:");
            foreach (var sinhVien in dtmlonhon7)
            {
                Console.WriteLine(sinhVien.TenSinhVien);
            }
            var dtbnhohon4 = sinhViens.Where(sinhvien => sinhvien.Dtb < 4).ToList();
            Console.WriteLine();
            Console.WriteLine($"Danh sách sinh viên có diem trung bình nho hơn 4:");
            foreach (var sinhVien in dtbnhohon4)
            {
                Console.WriteLine(sinhVien.TenSinhVien);
            }
            var ktTen = sinhViens.Where(sv => sv.TenSinhVien == "Khoa").ToList();
            Console.WriteLine();
            Console.WriteLine("Sinh vien co ten la Khoa:");
            if (ktTen.Count <= 0)
                Console.WriteLine($"Không có sinh viên nào tên Khoa trong danh sách!");
            foreach (var sv in ktTen)
            {
                Console.WriteLine(sv.TenSinhVien);
            }
            Console.WriteLine();
            Console.WriteLine($"Danh sách sinh viên và thông tin khoa:");
            var sinhVienTheoKhoa = from sv in sinhViens
                                   join khoa in khoas on sv.MaKhoa equals khoa.MaKhoa
                                   select new { TenSinhVien = sv.TenSinhVien, TenKhoa = khoa.TenKhoa };
            foreach (var sv in sinhVienTheoKhoa)
            {
                Console.WriteLine($"Sinh viên: {sv.TenSinhVien}, Khoa: {sv.TenKhoa}");
            }
            Console.WriteLine();
            var sinhVienGioiNhat = sinhViens.OrderByDescending(sv => sv.Dtb).FirstOrDefault();
            Console.WriteLine($"Sinh viên gioi nhat là: {sinhVienGioiNhat.TenSinhVien} - Diem trung bình: {sinhVienGioiNhat.Dtb}");
        }
    }
}