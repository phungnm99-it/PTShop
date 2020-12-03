using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class ChiTietThongSoKyThuat
    {
        public int DienThoaiId { get; set; }
        public int ThongSoKyThuatId { get; set; }
        public int ChiTiet { get; set; }

        //public List<ThongSoKyThuat> ThongSoKyThuats { get; set; }
    }
}
