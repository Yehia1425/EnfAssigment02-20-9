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
    internal class Instructorconfiguarition02 : IEntityTypeConfiguration<Instructors>
    {
        public void Configure(EntityTypeBuilder<Instructors> builder)
        {
            #region Instructor
            builder
                .HasKey(i => i.Id);
            builder
                .Property(i => i.Name).IsRequired().HasMaxLength(50);
            builder
                .Property(i => i.Address).HasMaxLength(100);
            builder
                .Property(i => i.Bouns).IsRequired().HasColumnType("decimal(18,2)");
            builder
                .Property(i => i.Salary).IsRequired().HasColumnType("decimal(18,2)");
            builder
                .Property(i => i.Hour_Rate).IsRequired().HasColumnType("data");
            builder
                .Property(i => i.Dep_Id).IsRequired();


            #endregion
        }
    }
}
