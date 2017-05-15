using Microsoft.EntityFrameworkCore;
using ProjectContracts.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context {
	public class EntityDbContext : DbContext {

		public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options) { }

		public DbSet<Address> Addresses { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeProject> EmployeeProjects { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Project> Projects { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Address>().ToTable("Address").HasKey(t => t.Id);

			modelBuilder.Entity<Employee>().ToTable("Employee").HasKey(t => t.Id);
			modelBuilder.Entity<Employee>().HasOne(t => t.Address).WithOne();
			modelBuilder.Entity<Employee>().HasOne(t => t.Position).WithOne();

			modelBuilder.Entity<Position>().ToTable("Position").HasKey(t => t.Id);

			modelBuilder.Entity<Project>().ToTable("Project").HasKey(t => t.Id);
			modelBuilder.Entity<EmployeeProject>().ToTable("EmployeeProject")
				.HasKey(t => new {
					t.EmployeeId,t.ProjectId
				});
			modelBuilder.Entity<EmployeeProject>().HasOne(t => t.Employee).WithMany(t => t.EmployeeProjects).HasForeignKey(t => t.EmployeeId);
			modelBuilder.Entity<EmployeeProject>().HasOne(t => t.Project).WithMany(t => t.EmployeeProjects).HasForeignKey(t => t.ProjectId);
			

		}
	}
}
