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
    internal class Course_Instructorconfiguarition02 : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            #region Course_Instructor
            builder
                .HasKey(ci => ci.CourseId);
            builder
                .Property(c => c.InstructorId).IsRequired();
            builder
                .Property(c => c.Evaluation).HasMaxLength(500);

            #endregion        
        }
    }
}
