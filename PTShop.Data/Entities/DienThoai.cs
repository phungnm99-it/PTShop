using System;
using System.Collections.Generic;
using System.Text;
using PTShop.Data.Enums;

namespace PTShop.Data.Entities
{
    public class DienThoai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HinhAnh { get; set; }
        public string TinhTrang { get; set; }
        public float Gia { get; set; }
        public float GiaGoc { get; set; }
        public int SoLuong { get; set; }
        public int ThuongHieuId { get; set; }

        //public ThuongHieu ThuongHieu { get; set; }

        //public List<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
