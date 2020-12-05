using PTShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string HoVaTen { get; set; }
        public GioiTinh GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
    }
}
