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
    internal class Coursesconfiguarition02 : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            #region Course
            builder
                .HasKey(c => c.Id);
            builder
                .Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder
                .Property(c => c.Duration).IsRequired();
            builder
                .Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder
                .Property(c => c.Top_id).IsRequired();

            #endregion        
        }
    }
}
