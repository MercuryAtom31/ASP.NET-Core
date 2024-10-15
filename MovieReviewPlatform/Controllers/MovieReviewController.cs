using Microsoft.AspNetCore.Mvc;
using MovieReviewPlatform.Models;

namespace MovieReviewPlatform.Controllers
{
    public class MovieReviewController : Controller
    {
        private static List<Movie> Reviews = new List<Movie>();

        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(Movie model)
        {
            if (ModelState.IsValid)
            {
                Reviews.Add(model);

                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult AllReviews()
        {
            return View(Reviews);
        }
    }
}
