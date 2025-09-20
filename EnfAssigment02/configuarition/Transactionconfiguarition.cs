using AssigmentENF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EnfAssigment02.configuarition
{
    internal class Transactionconfiguarition : IEntityTypeConfiguration<Transaction01>
    {
        public void Configure(EntityTypeBuilder<Transaction01> builder)
        {
            #region Transaction
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Description)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(e => e.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            builder.Property(e => e.Date)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(e => e.Al_Id)
                .IsRequired();

            #endregion

        }
    }
}
