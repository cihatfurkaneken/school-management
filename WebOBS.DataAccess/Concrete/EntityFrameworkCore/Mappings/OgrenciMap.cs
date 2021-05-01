using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Entity;

namespace WebOBS.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class OgrenciMap : IEntityTypeConfiguration<Ogrenci>
    {
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.ToTable(@"tbl_ogrenci", @"dbo");
            builder.HasKey(d => d.ogrId);
            builder.Property(d => d.ogrAdi).HasColumnName("ogrAdi");
            builder.Property(d => d.ogrNo).HasColumnName("ogrNo");
            
            builder.Property(d => d.eposta).HasColumnName("eposta");
        }
    }
}
