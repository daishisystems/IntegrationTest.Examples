using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationTest.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MembersController : ControllerBase
	{
		private static readonly string[] Movies = new[]
		{
			"Mission Impossible", "John Smith", "Jane Doe"
		};

		private readonly ILogger<MembersController> _logger;

		public MembersController(ILogger<MembersController> logger)
		{
			_logger = logger;
		}

		[Authorize]
		[HttpGet(Name = "get-members")]
		public IActionResult Get()
		{
			try
			{
				return Ok(Movies);
			}
			catch (Exception ex)
			{
                _logger.LogError(ex.Message);
				return BadRequest();
			}
		}
	}
}