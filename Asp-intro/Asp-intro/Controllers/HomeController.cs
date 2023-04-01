
using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            int[] nums = { 1, 4, 7, 8, 9, 0, 3 };
			return View(nums);

			//int[] nums = { 1, 4, 70, 8, 9, 0, 30 };
			//Data data = new Data();
			//data.Nums1 = nums1;
			//data.Nums2 = nums2;
		}


		//public string Index(int id)
		//{
		//    if (id == 0)
		//    {
		//        return "Aqshin";
		//    }
		//    return "Aqshin - " + id;
		//}

		//public string Detail(string slug, string name)
		//{
		//    return slug + " " + name;
		//}

		//private string GetName()
		//{
		//    return "Aqshin";
		//}

	}
    //class Data 
    //{
    //    public int[] Nums1 { get; set; }
    //    public int[] Nums2 { get; set; }
    //}
}
