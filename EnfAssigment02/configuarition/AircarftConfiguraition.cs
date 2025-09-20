using AssigmentENF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EnfAssigment02.configuarition
{
    internal class AircarftConfiguraition : IEntityTypeConfiguration<AirCraft>
    {
        public void Configure(EntityTypeBuilder<AirCraft> builder)
        {
            #region AirCarft
           builder.HasKey
                (e => e.Id);
           builder.Property(e => e.Capacity)
            .IsRequired();
           builder.Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(100);
           builder.Property(e => e.MajPilot)
                .IsRequired();
           builder.Property(e => e.Assistant)
                .HasMaxLength(80);
           builder.Property(e => e.Host01)
                .IsRequired();
           builder.Property(e => e.Host02)
                .IsRequired();
           builder.Property(e => e.Al_Id)
                .IsRequired();

            #endregion
        }
    }
}
