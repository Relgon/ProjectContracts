using ProjectContracts.Model;
using System;

namespace DAL.Context {
	public class DbInitializer {
		public static void Initialize(EntityDbContext context) {
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
			for (var i = 1; i < 20; i++) {
				context.Positions.Add(new Position {
					Name = "Position" + i,
					Salary = i * 200
				});
			}

			context.SaveChanges();

			for (int i = 1; i < 5; i++) {
				context.Projects.Add(new Project {
					Description = "Project " + i,
					Title = "Project " + i,
					StartDate = DateTime.Now,
					EndDate = DateTime.Now.AddYears(i)
				});
			}

			context.SaveChanges();

			for (int i = 1; i < 20; i++) {
				context.Employees.Add(new Employee {
					Address = new Address {
						AdministrativeArea = "Area",
						Apartment = "Appartment",
						City = "City",
						Country = "Country",
						PostalCode = "Postal code"
					},
					Characteristics = "Charaerqweqw eqweq" + i,
					LastName = "LastName" + i,
					Name = "Name" + i,
					MiddleName = "Middle" + i,
					PositionId = i
				});
			}

			context.SaveChanges();

			for (int i = 1; i < 20; i++) {
				for (int j = 1; j < 5; j++) {
					context.EmployeeProjects.Add(new EmployeeProject {
						StartDate = DateTime.Now,
						EndDate = DateTime.Now.AddDays(10 * j),
						EmployeeId = i,
						ProjectId = j
					});
				}
			}

			context.SaveChanges();
		}

	}
}
