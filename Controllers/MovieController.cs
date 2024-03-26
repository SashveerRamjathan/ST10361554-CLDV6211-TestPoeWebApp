using Microsoft.AspNetCore.Mvc;
using System.Collections;
using TestWebAppDemo.Models;


namespace TestWebAppDemo.Controllers
{
    public class MovieController : Controller
    {
       
        public IActionResult Index()
        {
            string description0 = "\"Jaws,\" directed by Steven Spielberg, is a gripping thriller about a coastal town terrorized by a giant man-eating shark. The police chief, a marine biologist, and a shark hunter team up to hunt down the predator in a tense and suspenseful mission. Packed with iconic moments, \"Jaws\" is a timeless classic that continues to captivate audiences with its thrilling narrative and shark encounters.";
            string description1 = "\"Back to the Future,\" directed by Robert Zemeckis, is a timeless sci-fi adventure following inventor Dr. Emmett \"Doc\" Brown and high schooler Marty McFly on a thrilling time-travel journey. As Marty accidentally lands in 1955, he navigates ensuring his parents' romance and returning to the present. Filled with humor, heart, and iconic scenes, \"Back to the Future\" remains a beloved classic captivating audiences of all ages.";
            string description2 = "Directed by Steven Spielberg and based on Michael Crichton's novel, 'Jurassic Park' is a thrilling adventure set on a remote island theme park with genetically engineered dinosaurs. Chaos ensues when security systems fail, endangering visitors' lives. The film delves into themes of danger, ethics, and humanity's relationship with science and nature, all depicted with awe-inspiring visuals and suspenseful storytelling.";

            string imagePath0 = "\\images\\image 1.jpeg";
            string imagePath1 = "\\images\\image 2.jpg";
            string imagePath2 = "\\images\\image 3.jpg";

            string reviewLink0 = "https://www.imdb.com/title/tt0073195/";
            string reviewLink1 = "https://www.imdb.com/title/tt0088763/";
            string reviewLink2 = "https://www.imdb.com/title/tt0107290/";

            List<Movie> moviesList = new List<Movie>()
            {
                new Movie{Id=0, Title="Jaws", Description=description0, Year="1975", ImagePath=imagePath0, ReviewLink=reviewLink0},

                new Movie{Id=1, Title="Back to the Future", Description=description1, Year="1985", ImagePath=imagePath1, ReviewLink=reviewLink1},

                new Movie{Id=2, Title="Jurassic Park", Description=description2, Year="1993", ImagePath=imagePath2, ReviewLink=reviewLink2}

            };

            return View(moviesList);
        }
        
        
    }
}
