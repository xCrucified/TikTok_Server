using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_logic.Entities;

namespace data_access.data.configs
{
    public class RefreshTokenEntityConfigs : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("RefreshTokens");

            builder
                .HasOne(x => x.User).WithMany(x => x.RefreshTokens).HasForeignKey(x => x.UserId);

        }
    }
}