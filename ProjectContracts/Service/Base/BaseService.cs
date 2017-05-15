using AutoMapper;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectContracts.Service {
	public abstract class BaseService : IBaseService {
		protected readonly EntityDbContext _context;
		protected readonly IMapper _mapper;

		public BaseService(EntityDbContext context, IMapper mapper) {
			_context = context;
			_mapper = mapper;
		}
	}
}
