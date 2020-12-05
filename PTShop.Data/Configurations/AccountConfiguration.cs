using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserId).ValueGeneratedNever();
        }
    }
}