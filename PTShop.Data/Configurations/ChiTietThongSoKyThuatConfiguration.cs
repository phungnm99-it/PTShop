using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTShop.Data.Entities;

namespace PTShop.Data.Configurations
{
    public class ChiTietThongSoKyThuatConfiguration : IEntityTypeConfiguration<ChiTietThongSoKyThuat>
    {
        public void Configure(EntityTypeBuilder<ChiTietThongSoKyThuat> builder)
        {
            builder.ToTable("ChiTietThongSoKyThuats");
            builder.HasKey(x => x.DienThoaiId);
            builder.Property(x => x.DienThoaiId).ValueGeneratedNever();
        }
    }
}
