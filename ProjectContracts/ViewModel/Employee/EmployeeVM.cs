namespace ProjectContracts.ViewModel {
	public class EmployeeVM : BaseVM {
		public string Name { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Characteristics { get; set; }
		public int PositionId { get; set; }
		public string PositionName { get; set; }
		public AddressVM Address { get; set; }

	}
}
