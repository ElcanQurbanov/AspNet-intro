using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			List<string> users = new List<string>()
			{
				"Eli","Aksin","Saiq","Cavid",
			};
			return View(users);
		}
	}
}
