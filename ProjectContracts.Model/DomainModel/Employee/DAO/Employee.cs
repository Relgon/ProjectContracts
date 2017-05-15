using System.Collections.Generic;

namespace ProjectContracts.Model {
	public class Employee : BaseModel {

		public virtual string Name { get; set; }
		public virtual string MiddleName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Characteristics { get; set; }
		public virtual int PositionId { get; set; }
		public virtual int AddressId { get; set; }

		public Address Address { get; set; }
		public Position Position { get; set; }
		public ICollection<EmployeeProject> EmployeeProjects { get; set; }
	}
}
