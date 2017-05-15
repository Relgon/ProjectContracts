using ProjectContracts.ViewModel;
using System.Collections.Generic;

namespace ProjectContracts.Service {
	public interface IProjectService {

		ICollection<ProjectVM> GetProjects();
	}
}
