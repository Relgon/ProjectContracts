using System.Collections.Generic;
using System.Linq;
using ProjectContracts.ViewModel;
using DAL.Context;
using AutoMapper;

namespace ProjectContracts.Service {
	public class PositionService :BaseService, IPositionService {
		public PositionService(EntityDbContext context, IMapper mapper) : base(context, mapper) {
		}

		public ICollection<PositionVM> GetPositions() {
			var positions = _context.Positions.ToList();
			return _mapper.Map<ICollection<PositionVM>>(positions);
		}
	}
}
