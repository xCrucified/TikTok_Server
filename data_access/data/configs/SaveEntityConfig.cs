using Bussiness_Logic.DTOs;
using Bussiness_Logic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.configs
{
    public class SaveEntityConfig : IEntityTypeConfiguration<Save>
    {
        public void Configure(EntityTypeBuilder<Save> builder) { 
        
            builder.HasKey(x => x.Id);
            builder.ToTable("Saves");
            
        }
    }
}
