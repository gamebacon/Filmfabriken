using System;
using System.Net.Http;
using System.Threading.Tasks;
using FilmFabriken.wwwroot.cs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace FilmFabriken.Pages.Movies
{
    public class MovieDetails : PageModel
    {
        private HttpClient _client;

        public MovieDetails(HttpClient client)
        {
            _client = client;
            Input = new MovieInformation();
        }
        
        [BindProperty(SupportsGet = true)]
        public int movie_id { get; set; }

        [BindProperty] 
        public MovieInformation Input {get; set; }

        public class MovieInformation
        {
            public int MovieId { get; set; }
            public string Title { get; set; }
            public string Overview { get; set; }
            public string ImgPath { get; set; }
            public string ReleaseDate { get; set; }
            public float Rating { get; set; }
        }
        
        public async Task<IActionResult> OnGet(int movie_id)
        {
            
            string url = $"{Util.BASE_URL}/movie/{movie_id}?api_key={Util.API_KEY}";
            
            var response = await _client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(result);
            
            Console.WriteLine(obj);

            if (!obj.ContainsKey("title")) 
                return Redirect("/movies/index");
                
            Input.Title = obj["title"].ToString();
            Input.Overview = obj["overview"].ToString();
            Input.ImgPath = Util.IMG_URL + obj["poster_path"].ToString();
            Input.Rating = float.Parse(obj["vote_average"].ToString());
            Input.ReleaseDate = obj["release_date"].ToString();
            
            return Page();
        }
        
    }
}