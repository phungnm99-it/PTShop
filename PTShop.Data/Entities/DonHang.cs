using PTShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class DonHang
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoDuKien { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string TrangThai { get; set; }
    }
}
