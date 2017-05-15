﻿using ProjectContracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectContracts.Service {
	public interface IEmployeeService {

		ICollection<EmployeeVM> GetEmployees();
		ICollection<EmployeeProjectVM> GetEmployeeProjects(int employeeId);
	}
}
