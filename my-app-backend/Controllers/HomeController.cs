using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    [Route("Home")]
    [ApiController]
    public class HomeController : Controller
    {
        //Authenticate user
        [HttpPost("login")]
        public ActionResult login(string username, string password)
        {
            if (username == "prerna@gmail.com" && password == "abcd123")
                return Ok();
            else
                return BadRequest();  // return bad request http error 400
        }

        //get method to send movie list
        [HttpGet("movies")]
        public ActionResult getMovies()
        {
            string[] movies = {"HIT", "ME", "Time,Darlings","Katteri","Bhool Bhulaiya 2","Love in the villa",
              "Shabaash Mithu","365 days","Jaadugar","Sherdil" };

            return Json(movies);
        }

    }
}
