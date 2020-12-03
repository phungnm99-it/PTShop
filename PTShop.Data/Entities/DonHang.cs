using PTShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class DonHang
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayDatHang { get; set; }
        public HinhThucThanhToan HinhThucThanhToan { get; set; }
        public TrangThaiDonHang TrangThai { get; set; }
    }
}
