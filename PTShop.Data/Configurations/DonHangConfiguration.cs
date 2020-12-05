using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTShop.Data.Entities;
using PTShop.Data.Enums;

namespace PTShop.Data.Configurations
{
    public class DonHangConfiguration : IEntityTypeConfiguration<DonHang>
    {
        public void Configure(EntityTypeBuilder<DonHang> builder)
        {
            builder.ToTable("DonHangs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.HinhThucThanhToan).HasDefaultValue(HinhThucThanhToan.ThanhToanTrucTiep);
            builder.Property(x => x.TrangThai).HasDefaultValue(TrangThaiDonHang.ChuaGiaoHang);
            builder.Property(x => x.Email).IsRequired().IsUnicode(false);
        }
    }
}
