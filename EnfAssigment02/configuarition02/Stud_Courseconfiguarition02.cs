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
    internal class Stud_Courseconfiguarition02 : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            #region Stud_Course
          builder
                .HasKey(sc => sc.StudentId);
          builder
                .Property(sc => sc.CourseId).IsRequired();
          builder
                .Property(sc => sc.Grade).HasMaxLength(5);

            #endregion        }
        }
    }
