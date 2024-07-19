using business_logic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.configs
{
    public class VideoEntityConfig : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Videos");

            builder
                .HasOne(x => x.User).WithMany(x => x.Videos).HasForeignKey(x => x.UserId);
            builder
                .HasMany(x => x.Comments).WithOne(x => x.Video).HasForeignKey(x => x.VideoId).OnDelete(DeleteBehavior.ClientCascade);
            builder
                .HasMany(x => x.Likes).WithOne(x => x.Video).HasForeignKey(x => x.VideoId);
            builder
                .HasMany(x => x.Saves).WithOne(x => x.Video).HasForeignKey(x =>x.VideoId);
        }
    }
}
