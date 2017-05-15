using AutoMapper;
using ProjectContracts.Model;
using ProjectContracts.ViewModel;

namespace ProjectContracts.AutoMapper {
	public class MappingProfile : Profile {

		public MappingProfile() {
			CreateMap<BaseModel, BaseVM>();
			CreateMap<Position, PositionVM>();
			CreateMap<Address, AddressVM>();
			CreateMap<Project, ProjectVM>();
			CreateMap<Employee, EmployeeVM>()
				.ForMember(desc => desc.PositionName, opt => opt.MapFrom(t => t.Position.Name))
				.ForMember(dest => dest.Address, opt => opt.MapFrom(t => t.Address));

			CreateMap<EmployeeProject, EmployeeProjectVM>()
				.ForMember(dest => dest.DaysOnProject, opt => opt.MapFrom(t => (t.EndDate - t.StartDate).Days));

		}
	}
}
