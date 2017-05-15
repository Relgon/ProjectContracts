using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectContracts.Service;
using ProjectContracts.ViewModel;

namespace ProjectContracts.Controllers {
	[Produces("application/json")]
	[Route("api/Position")]
	public class PositionController : Controller {

		private readonly IPositionService _postionService;

		public PositionController(IPositionService positionService) {
			_postionService = positionService;
		}

		public ICollection<PositionVM> Get() {
			return _postionService.GetPositions();
		}
	}
}