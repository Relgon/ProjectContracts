using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectContracts.ViewModel {
	public class EmployeeProjectVM {

		public int EmployeeId { get; set; }
		public int ProjectId { get; set; }
		public string ProjectName { get; set; }
		public int DaysOnProject { get; set; }
	}
}
