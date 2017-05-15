using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Context;
using ProjectContracts.ViewModel;

namespace ProjectContracts.Service {
	public class EmployeeService : BaseService, IEmployeeService {
		public EmployeeService(EntityDbContext context, IMapper mapper) : base(context, mapper) {
		}

		public ICollection<EmployeeProjectVM> GetEmployeeProjects(int employeeId) {
			var employeeProjects = _context.EmployeeProjects.Where(t => t.EmployeeId == employeeId);
			return _mapper.Map<ICollection<EmployeeProjectVM>>(employeeProjects);
		}

		public ICollection<EmployeeVM> GetEmployees() {
			var employees = _context.EmployeeProjects.ToList();
			return _mapper.Map<ICollection<EmployeeVM>>(employees);
		}
	}
}
