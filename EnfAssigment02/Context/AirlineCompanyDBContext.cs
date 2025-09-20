using AssigmentENF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfAssigment02.Context
{
    internal class AirlineCompanyDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AirLineContext;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region AirCarft_Routes
            modelBuilder.Entity<AirCarft_Routes>()
                .HasKey(A => A.AC_Id);
            modelBuilder.Entity<AirCarft_Routes>()
                .Property(A => A.Route_Id).IsRequired();
            modelBuilder.Entity<AirCarft_Routes>().Property
                (A => A.Departure)
                .IsRequired();
            modelBuilder.Entity<AirCarft_Routes>().Property
                (A => A.Num_Of_Pass)
                .IsRequired();
            modelBuilder.Entity<AirCarft_Routes>().Property
                (A => A.price)
                .IsRequired();
            modelBuilder.Entity<AirCarft_Routes>().Property
                (A => A.Arrival)
                .IsRequired()
                .HasMaxLength(100);

            #endregion

            #region AirCarft
            modelBuilder.Entity<AirCraft>().HasKey
                (e => e.Id);
                modelBuilder.Entity<AirCraft>().Property(e => e.Capacity)
                .IsRequired();
            modelBuilder.Entity<AirCraft>().Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<AirCraft>().Property(e => e.MajPilot)
                .IsRequired();
            modelBuilder.Entity<AirCraft>().Property(e => e.Assistant)
                .HasMaxLength(80);
            modelBuilder.Entity<AirCraft>().Property(e => e.Host01)
                .IsRequired();
            modelBuilder.Entity<AirCraft>().Property(e => e.Host02)
                .IsRequired();
            modelBuilder.Entity<AirCraft>().Property(e => e.Al_Id)
                .IsRequired();

            #endregion

            #region AirLine
            modelBuilder.Entity<AirLine>().HasKey
                (e => e.AirLineId);
            modelBuilder.Entity<AirLine>().Property(e => e.AirLineName)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<AirLine>().Property(e => e.ContactAddress)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<AirLine>().Property(e => e.Cont_Person)
                .IsRequired();

            #endregion

            #region Airline_Phones
            modelBuilder.Entity<AirLine_Phones>().HasKey(e => e.Al_Id);
            modelBuilder.Entity<AirLine_Phones>().Property(e => e.PhonesNumber)
                .HasMaxLength(100)
                .IsRequired();

            #endregion

            #region Emp_Qualifiction
            modelBuilder.Entity<Emp_Qualifications>().HasKey(e => e.Emp_id);
            modelBuilder.Entity<Emp_Qualifications>().Property(e => e.Qualifications)
                .HasMaxLength(100)
                .IsRequired();
            #endregion

            #region Employee
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            modelBuilder.Entity<Employee>().Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Employee>().Property(e => e.Gender)
                .IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Position)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.BD_Year)
                .HasColumnType("date")
                .IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.BD_Month)
                .HasColumnType("date")
                .IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.BD_Day)
                .HasColumnType("date")
                .IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Al_Id)
                .IsRequired();


            #endregion

            #region Route
            modelBuilder.Entity<Route>().HasKey(e => e.Id);
            modelBuilder.Entity<Route>().Property(e => e.Distance)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Route>().Property(e => e.Destination)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Route>().Property(e => e.Origin)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Route>().Property(e => e.Classification)
                .HasMaxLength(100)
                .IsRequired();
            #endregion

            #region Transaction
            modelBuilder.Entity<Transaction>().HasKey(e => e.Id);
            modelBuilder.Entity<Transaction>().Property(e => e.Description)
                .HasMaxLength(200)
                .IsRequired();
            modelBuilder.Entity<Transaction>().Property(e => e.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            modelBuilder.Entity<Transaction>().Property(e => e.Date)
                .HasColumnType("date")
                .IsRequired();
            modelBuilder.Entity<Transaction>().Property(e => e.Al_Id)
                .IsRequired();

            #endregion

        }

        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<AirLine_Phones> AirLine_Phones { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<AirCarft_Routes> AirCarft_Routes { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Emp_Qualifications> Emp_Qualifications { get; set; }
    }
}
