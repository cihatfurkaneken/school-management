using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Entity;

namespace WebOBS.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class DersOgrenciMap : IEntityTypeConfiguration<DersOgrenci>
    {
        public void Configure(EntityTypeBuilder<DersOgrenci> builder)
        {
            builder.ToTable(@"tbl_ogrenciders", @"dbo");
            builder.HasKey(d => d.kayitNo);
            builder.Property(d => d.ogrenciId).HasColumnName("ogrenciId");
            builder.Property(d => d.dersId).HasColumnName("dersId");
            builder.Property(d => d.dersNotu).HasColumnName("dersNotu");
            builder.Property(d => d.devamsizlik).HasColumnName("devamsizlik");
        }
    }
}
