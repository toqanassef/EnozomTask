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
    public class CountryHolidaysConfigration : IEntityTypeConfiguration<CountryHolidays>
    {
        public void Configure(EntityTypeBuilder<CountryHolidays> builder)
        {
            //builder.ToTable("Countries");
            builder.Property(x => x.Id)
                .IsRequired();
            builder.Property(x => x.CountryId)
                .IsRequired();
            builder.Property(at => at.Holiday)
                .HasMaxLength(500).IsRequired();
           
        }
    }
}
