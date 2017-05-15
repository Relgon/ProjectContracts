using System;

namespace ProjectContracts.Model {

	public class EmployeeProject {
		public virtual int EmployeeId { get; set; }
		public virtual int ProjectId { get; set; }
		public virtual DateTime StartDate { get; set; }
		public virtual DateTime EndDate { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual Project Project { get; set; }
	}
}
