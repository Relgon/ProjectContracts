using AutoMapper;
using ProjectContracts.Model;
using ProjectContracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectContracts.AutoMapper {
	public class MappingProfile : Profile {

		public MappingProfile() {
			CreateMap<BaseModel, BaseVM>();
			CreateMap<Position, PositionVM>();
			CreateMap<Address, AddressVM>();
			CreateMap<Project, ProjectVM>();
			CreateMap<Employee, EmployeeVM>()
				.ForMember(desc => desc.PositionName, opt => opt.MapFrom(t => t.Position.Name));

			CreateMap<EmployeeProject, EmployeeProjectVM>()
				.ForMember(dest => dest.DaysOnProject, opt => opt.MapFrom(t => (t.EndDate - t.StartDate).Days));
		}
	}
}
