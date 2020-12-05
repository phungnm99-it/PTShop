using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTShop.Data.Entities;
using PTShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Configurations
{
    public class DienThoaiConfiguration : IEntityTypeConfiguration<DienThoai>
    {
        public void Configure(EntityTypeBuilder<DienThoai> builder)
        {
            builder.ToTable("DienThoais");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Gia).IsRequired();
            builder.Property(x => x.GiaGoc).IsRequired();
            builder.Property(x => x.HinhAnh).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.NgayRaMat).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ThuongHieuId).IsRequired();
            builder.Property(x => x.TinhTrang).IsRequired().HasDefaultValue(TrangThaiDienThoai.DangKinhDoanh);

            //builder.HasOne(x => x.ThuongHieu)
                //.WithMany(x => x.DienThoais)
                //.HasForeignKey(x => x.ThuongHieuId);
        }
    }
}
