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
    internal class Emp_Qualifictionconfiguarition : IEntityTypeConfiguration<Emp_Qualifications>
    {
        public void Configure(EntityTypeBuilder<Emp_Qualifications> builder)
        {
            #region Emp_Qualifiction
            builder.HasKey(e => e.Emp_id);
            builder.Property(e => e.Qualifications)
                .HasMaxLength(100)
                .IsRequired();
            #endregion        
        }
    }
}
