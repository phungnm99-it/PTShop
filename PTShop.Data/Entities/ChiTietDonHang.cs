using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class ChiTietDonHang
    {
        public int DonHangId { get; set; }
        public int DienThoaiId { get; set; }
        public int SoLuong { get; set; }
        public float Gia { get; set; }

        public List<DienThoai> DienThoais { get; set; }
    }
}
