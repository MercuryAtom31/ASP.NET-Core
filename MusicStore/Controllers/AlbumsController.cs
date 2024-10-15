using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
	public class AlbumsController : Controller
	{
		static List<Album> albums = new List<Album>
		{
			new Album { Id = 1, Name = "Taylor Swift",
			Reviews = new List<string>{ "A captivating blend of melodies"} },
			new Album { Id = 2, Name = "Michael Jackson",
			Reviews = new List<string>{ "A captivating blend of melodies"} }
		};

		[HttpGet("")]
		public IActionResult Index()
		{
			return View(albums);
		}

		[HttpGet("{id}")]
		public IActionResult Details(int id)
		{
			var album = albums.FirstOrDefault(a => a.Id == id);
			if (album == null) return NotFound();

			return View(album);
		}

		[HttpGet("{id}/Review")]
		public IActionResult Review(int id)
		{
			var album = albums.FirstOrDefault(a => a.Id == id);
			if (album == null) return NotFound();

			return View(album);
		}

		[HttpPost("{id}/Review")]
		public IActionResult Review(int id, string review)
		{
			var album = albums.FirstOrDefault(a => a.Id == id);
			if (album == null) return NotFound();

			album.Reviews.Add(review);

			return RedirectToAction("Details", new {id = id });
		}
	}
}

