using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using FilmFabriken.Model;
using FilmFabriken.Model.MovieStuff;
using FilmFabriken.wwwroot.cs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace FilmFabriken.Pages.Movies.Lists
{
    [Authorize]
    public class Create : PageModel
    {

        public ApplicationDbContext _db { get; set; }
        public HttpClient _client { get; set; }

        public Create(ApplicationDbContext db, HttpClient client)
        {
            _db = db;
            _client = client;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            
            
            Guid userId = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
            Guid listID = Guid.NewGuid();

            List<Movie> movies = new List<Movie>();
            
            if (false)
                for (int i = 0; i < 4; i++)
                {
                    int movie_Id = RandomNumberGenerator.GetInt32(10, 1000);
                    
                    string url = Util.GetMovieUrl(movie_Id);
                    var response = await _client.GetAsync(url);
                    var result = await response.Content.ReadAsStringAsync();
                    JObject obj = JObject.Parse(result);

                    if (!obj.ContainsKey("title")) 
                        continue;
                
                    movies.Add(new Movie
                    {
                        Title = obj["title"].ToString(),
                        Overview = obj["overview"].ToString(),
                        ImgPath = Util.IMG_URL + obj["poster_path"],
                        Rating = float.Parse(obj["vote_average"].ToString()),
                        MovieId = movie_Id,
                        MovieListId = listID
                    });
                }
                    
            
            MovieList movieList = new MovieList
                
            {
                Id = listID,
                UserId = userId,
                Name = Input.Name,
                Description = Input.Description,
                Movies = movies 
            };
            

            await _db.MovieList.AddAsync(movieList);
            await _db.SaveChangesAsync();


            return Redirect("/movies/lists/index");
        }
        
        public class InputModel
        {


            public InputModel()
            {
                Movies_ids = new List<int>();
            }
            
            [Required(ErrorMessage = "Obligatoriskt fält")]
            [Display(Name = "Namn *")]
            public string Name { get; set; }
            
            [Display(Name = "Beskrivning")]
            public string Description { get; set; }
            
            public List<int> Movies_ids { get; set; }

        } 
        
    }
}