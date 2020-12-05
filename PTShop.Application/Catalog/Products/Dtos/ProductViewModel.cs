using PTShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Application.Catalog.Products.Dtos
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string HinhAnh { get; set; }
        public TrangThaiDienThoai TinhTrang { get; set; }
        public float Gia { get; set; }
        public float GiaGoc { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayRaMat { get; set; }
        public int ThuongHieuId { get; set; }
    }
}
