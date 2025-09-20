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
    internal class Employeeconfiguarition : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            #region Employee
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(e => e.Gender)
                .IsRequired();
            builder.Property(e => e.Position)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(e => e.BD_Year)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(e => e.BD_Month)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(e => e.BD_Day)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(e => e.Al_Id)
                .IsRequired();


            #endregion        }
        }
    }
}
