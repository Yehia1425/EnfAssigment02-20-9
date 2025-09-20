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
    internal class Routeconfiguarition : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            #region Route
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Distance)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(e => e.Destination)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(e => e.Origin)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(e => e.Classification)
                .HasMaxLength(100)
                .IsRequired();
            #endregion        }
        }
    }
}
