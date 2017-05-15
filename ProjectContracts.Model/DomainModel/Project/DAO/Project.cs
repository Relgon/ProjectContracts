using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectContracts.Model {
	public class Project : BaseModel {

		public virtual string Title { get; set; }
		public virtual DateTime StartDate { get; set; }
		public virtual DateTime? EndDate { get; set; }
		public virtual string Description { get; set; }

		public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
	}
}
