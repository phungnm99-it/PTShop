using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTShop.Data.Entities;

namespace PTShop.Data.Configurations
{
    public class ThongSoKyThuatConfiguration : IEntityTypeConfiguration<ThongSoKyThuat>
    {
        public void Configure(EntityTypeBuilder<ThongSoKyThuat> builder)
        {
            builder.ToTable("ThongSoKyThuats");
            builder.HasKey(x => x.Id);

            //builder.HasOne(x => x.LoaiThongSoKyThuat).WithMany(x => x.ThongSoKyThuats).HasForeignKey(x => x.LoaiThongSoKyThuatId);
        }
    }
}
