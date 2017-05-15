using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DAL.Context;
using ProjectContracts.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ProjectContracts.Service {
	public class EmployeeService : BaseService, IEmployeeService {
		public EmployeeService(EntityDbContext context, IMapper mapper) : base(context, mapper) {
		}

		public ICollection<EmployeeProjectVM> GetEmployeeProjects(int employeeId) {
			var employeeProjects = _context.EmployeeProjects
				.Include(t => t.Project)
				.Where(t => t.EmployeeId == employeeId);
			return _mapper.Map<ICollection<EmployeeProjectVM>>(employeeProjects);
		}

		public ICollection<EmployeeVM> GetEmployees() {
			var employees = _context.Employees
				.Include(t => t.Address)
				.Include(t => t.Position)
				.ToList();
			return _mapper.Map<ICollection<EmployeeVM>>(employees);
		}
	}
}
