using ProjectContracts.ViewModel;
using System.Collections.Generic;

namespace ProjectContracts.Service {
	public interface IEmployeeService {

		ICollection<EmployeeVM> GetEmployees();
		ICollection<EmployeeProjectVM> GetEmployeeProjects(int employeeId);
	}
}
