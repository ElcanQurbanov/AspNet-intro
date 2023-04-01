using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
	public class CalculateController : Controller
	{
		public IActionResult Index()
		{
			int n = 0;
			int m = 1;
			int[] fib = new int[15];
			fib[0] = n;
			fib[1] = m;
			for (int i = 2; i <fib.Length; i++)
			{
				int c = n + m;
				n = m;
				m = c;
				fib[i] = c;
			}
			
			return View(fib);
		}
	}
}
