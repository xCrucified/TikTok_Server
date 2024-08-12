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
    public class CommentEntityConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(x=>x.Video).WithMany(x=>x.Comments).HasForeignKey(x=>x.VideoId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
