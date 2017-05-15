using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectContracts.Service;
using ProjectContracts.ViewModel;

namespace ProjectContracts.Controllers {
	[Produces("application/json")]
	[Route("api/Project")]
	public class ProjectController : Controller {

		private readonly IProjectService _projectService;

		public ProjectController(IProjectService projectService) {
			_projectService = projectService;
		}

		public ICollection<ProjectVM> Get() {
			return _projectService.GetProjects();
		}
	}
}