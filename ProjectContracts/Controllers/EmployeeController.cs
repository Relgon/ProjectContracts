using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectContracts.Service;
using ProjectContracts.ViewModel;

namespace ProjectContracts.Controllers {
	[Produces("application/json")]
	public class EmployeeController : Controller {

		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService employeeService) {
			_employeeService = employeeService;
		}

		[Route("api/Employee")]
		public ICollection<EmployeeVM> Get() {
			return _employeeService.GetEmployees();
		}

		[Route("api/employee/{id}/project")]
		public ICollection<EmployeeProjectVM> GetEmployeProjects(int id) {
			return _employeeService.GetEmployeeProjects(id);
		}
	}
}