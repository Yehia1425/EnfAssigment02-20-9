using AssigmentENF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfAssigment02.configuarition
{
    internal class Airline_Phonesconfiguarition : IEntityTypeConfiguration<AirLine_Phones>
    {

        public void Configure(EntityTypeBuilder<AirLine_Phones> builder)
        {
            #region Airline_Phones
            builder.HasKey(e => e.Al_Id);
            builder.Property(e => e.PhonesNumber)
                .HasMaxLength(100)
                .IsRequired();

            #endregion
        }
    }
}
