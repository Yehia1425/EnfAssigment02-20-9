using AssigmentENF.Model02;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EnfAssigment02.configuarition02
{
    internal class Topicsconfiguarition02 : IEntityTypeConfiguration<Topics>
    {
        public void Configure(EntityTypeBuilder<Topics> builder)
        {
            #region Topics
            builder
                .HasKey(t => t.Id);
            builder
                .Property(t => t.Name).IsRequired().HasMaxLength(100);

            #endregion
        }
    }
}
