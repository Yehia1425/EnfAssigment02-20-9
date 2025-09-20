using AssigmentENF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EnfAssigment02.configuarition
{
    internal class AirLineconfiguarition : IEntityTypeConfiguration<AirLine>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AirLine> builder)
        {
            #region AirLine
            builder.HasKey
                 (e => e.AirLineId);
            builder.Property(e => e.AirLineName)
                 .IsRequired()
                 .HasMaxLength(100);
            builder.Property(e => e.ContactAddress)
                 .HasMaxLength(100)
                 .IsRequired();
            builder.Property(e => e.Cont_Person)
                 .IsRequired();

            #endregion        
        }
    }
}
