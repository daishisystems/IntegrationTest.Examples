using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationTest.Api.Controllers
{
	[ApiController]
    [Authorize]
    [Route("api/[controller]")]
	public class MembersController : ControllerBase
	{
		private static readonly string[] Members = new[]
		{
			"John Smith", "Jane Doe"
		};

		private readonly ILogger<MembersController> _logger;

		public MembersController(ILogger<MembersController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "get-members")]
		public IActionResult Get()
		{
			try
			{
				return Ok(Members);
			}
			catch (Exception ex)
			{
                _logger.LogError(ex.Message);
				return BadRequest();
			}
		}
	}
}