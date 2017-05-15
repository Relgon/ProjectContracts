using ProjectContracts.Model;
using ProjectContracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectContracts.Service {
	public interface IPositionService {

		ICollection<PositionVM> GetPositions();
	}
}
