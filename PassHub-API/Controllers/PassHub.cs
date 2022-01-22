using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PassHub_API.Controllers
{
	[Route("PassHub")]
	public class PassHub : Controller
	{
		[HttpGet]
		// Add Validate Tag
		[Route("GetAllPasswords")]
		public ActionResult GetAllPasswords(string UserID)
		{
			var test = "hello";
			return new EmptyResult();
		}
	}
}
