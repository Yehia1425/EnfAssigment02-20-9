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
    internal class Studentsconfiguarition02 : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            #region Students
           builder
                .HasKey(s => s.Id);
           builder
                .Property(s => s.FName).IsRequired().HasMaxLength(50);
           builder
                .Property(s => s.LName).IsRequired().HasMaxLength(50);
           builder
                .Property(s => s.Age).IsRequired();
           builder
                .Property(s => s.Address).IsRequired().HasMaxLength(200);
           builder
                .Property(s => s.Dept_id).IsRequired();


            #endregion

        }
    }
}
