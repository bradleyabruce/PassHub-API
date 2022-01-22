using Microsoft.AspNetCore.Mvc;
using PassHub_API.Services;

namespace PassHub_API.Controllers
{
	[Route("PassHub")]
	public class PassHub : Controller
	{
		[HttpGet]
		// Add Validate Tag
		[Route("GetAllLogins")]
		public ActionResult GetAllLogins(string userID)
		{
			var service = new PassHubService();
			service.GetAllPasswords(userID);
			return new EmptyResult();
		}
	}
}
