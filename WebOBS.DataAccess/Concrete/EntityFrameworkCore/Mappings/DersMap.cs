using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.Entity;

namespace WebOBS.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class DersMap : IEntityTypeConfiguration<Ders>
    {
        public void Configure(EntityTypeBuilder<Ders> builder)
        {
            builder.ToTable(@"tbl_ders", @"dbo");
            builder.HasKey(d => d.dersId);
            builder.Property(d => d.dersAdi).HasColumnName("dersAdi");
            builder.Property(d => d.dersKredi).HasColumnName("dersKredi");
            builder.Property(d => d.dersNo).HasColumnName("dersNo");
            builder.Property(d => d.ogretmen).HasColumnName("ogretmen");
        }
    }
}
