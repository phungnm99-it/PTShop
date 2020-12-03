using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTShop.Data.Entities;

namespace PTShop.Data.Configurations
{
    public class LoaiThongSoKyThuatConfiguration : IEntityTypeConfiguration<LoaiThongSoKyThuat>
    {
        public void Configure(EntityTypeBuilder<LoaiThongSoKyThuat> builder)
        {
            builder.ToTable("LoaiThongSoKyThuats");
            builder.HasKey(x => x.Id);
        }
    }
}
