using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectContracts.Service;
using ProjectContracts.ViewModel;

namespace ProjectContracts.Controllers {
	[Produces("application/json")]
	[Route("api/Employee")]
	public class EmployeeController : Controller {

		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService employeeService) {
			_employeeService = employeeService;
		}

		public ICollection<EmployeeVM> Get() {
			return _employeeService.GetEmployees();
		}

		[Route("api/employee/{employeeId}/project")]
		public ICollection<EmployeeProjectVM> GetEmployeProjects(int employeeId) {
			return _employeeService.GetEmployeeProjects(employeeId);
		}
	}
}