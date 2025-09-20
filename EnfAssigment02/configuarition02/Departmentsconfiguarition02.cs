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
    internal class Departmentsconfiguarition02 : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            #region Departments
           builder
                .HasKey(d => d.Id);
           builder
                .Property(d => d.DeptName).IsRequired();
           builder
                .Property(d => d.Hiring_Date).IsRequired().HasColumnType("data");
           builder
                .Property(d => d.Ins_Id).IsRequired();



            #endregion
        }
    }
}
