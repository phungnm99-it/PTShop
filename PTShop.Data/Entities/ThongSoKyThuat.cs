using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class ThongSoKyThuat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LoaiThongSoKyThuatId { get; set; }

        //public LoaiThongSoKyThuat LoaiThongSoKyThuat { get; set; }
    }
}
