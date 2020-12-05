using PTShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PTShop.Data.Entities
{
    public class Account
    {
        public int UserId { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public TrangThaiAccount TrangThai { get; set; }
    }
}
