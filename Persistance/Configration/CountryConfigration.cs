using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configration
{
    public class CountryConfigration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            //builder.ToTable("Countries");
            builder.Property(x => x.Id)
                .IsRequired();
            builder.Property(at => at.Name)
                .HasMaxLength(500).IsRequired();
           
        }
    }
}
