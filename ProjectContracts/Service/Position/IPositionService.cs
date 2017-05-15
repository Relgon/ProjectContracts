using ProjectContracts.ViewModel;
using System.Collections.Generic;

namespace ProjectContracts.Service {
	public interface IPositionService {

		ICollection<PositionVM> GetPositions();
	}
}
