using System.Net;

namespace IntegrationTest.Api.Test.Controllers
{
	[TestClass]
	public class MembersControllerTest
	{
		[TestMethod]
		public async Task GetMembers_ShouldReturn200StatusCode()
		{
			//Setup
			var client = TestClient.GetTestClient();

			//arrange
			var response = await client.GetAsync("api/members");

			//Assert
			Assert.IsTrue(response.StatusCode == HttpStatusCode.OK);
		}
	}
}
