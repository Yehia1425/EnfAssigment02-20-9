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
    internal class AirLineconfiguarition : IEntityTypeConfiguration<AirCarft_Routes>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AirCarft_Routes> builder)
        {
            #region AirCarft_Routes
           builder
                .HasKey(A => A.AC_Id);
           builder
                .Property(A => A.Route_Id).IsRequired();
           builder.Property
                (A => A.Departure)
                .IsRequired();
           builder.Property
                (A => A.Num_Of_Pass)
                .IsRequired();
           builder.Property
                (A => A.price)
                .IsRequired();
           builder.Property
                (A => A.Arrival)
                .IsRequired()
                .HasMaxLength(100);

            #endregion
        }
    }
}
