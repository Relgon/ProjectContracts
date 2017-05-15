using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DAL.Context;
using ProjectContracts.ViewModel;

namespace ProjectContracts.Service {


	public class ProjectService : BaseService, IProjectService {
		public ProjectService(EntityDbContext context, IMapper mapper) : base(context, mapper) {
		}

		public ICollection<ProjectVM> GetProjects() {
			var projects = _context.Projects.ToList();
			return _mapper.Map<ICollection<ProjectVM>>(projects);
		}
	}
}
