using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Context;
using ProjectContracts.Model;
using ProjectContracts.Service;

namespace ProjectContracts.Controllers {
	[Route("api/[controller]")]
	public class ValuesController : Controller {

		private readonly EntityDbContext _context;
		private readonly IPositionService _positionService;

		public ValuesController(EntityDbContext context, IPositionService positionService) {
			_context = context;
			_positionService = positionService;
		}

		// GET api/values
		[HttpGet]
		public IEnumerable<string> Get() {
			//_context.Add(new Position { Name = "qweqw", Salary = 1231231 });
			var  a = _positionService.GetPositions();
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id) {
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]string value) {
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
		}
	}
}
