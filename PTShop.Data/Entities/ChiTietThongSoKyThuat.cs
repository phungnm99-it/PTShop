using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class ChiTietThongSoKyThuat
    {
        public int DienThoaiId { get; set; }
        public string ManHinh { get; set; }
        public string HeDieuHanh { get; set; }
        public string CameraSau { get; set; }
        public string CameraTruoc { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string BoNhoTrong { get; set; }
        public string TheSim { get; set; }
        public string DungLuongPin { get; set; }
        public DateTime NgayRaMat { get; set; }
        //public int ThongSoKyThuatId { get; set; }
        //public string ChiTiet { get; set; }
    }
}
