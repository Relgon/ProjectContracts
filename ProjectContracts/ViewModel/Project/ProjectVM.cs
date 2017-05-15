using System;

namespace ProjectContracts.ViewModel {
	public class ProjectVM : BaseVM {

		public string Title { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public string Description { get; set; }
	}
}
