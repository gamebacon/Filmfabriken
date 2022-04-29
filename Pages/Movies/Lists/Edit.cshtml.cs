using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
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
    public class Edit : PageModel
    {

        private readonly ApplicationDbContext _db;
        private readonly HttpClient _client;
        
        [BindProperty]
        public MovieList MovieList { get; set; }

        public List<int> Movie_ids { get; set; }

        public Edit(ApplicationDbContext db, HttpClient client)
        {
            _db = db;
            _client = client;
        }
        
        public async Task<IActionResult> OnGet(Guid id)
        {
            Guid userId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            MovieList = await _db.MovieList.FindAsync(id);

            if (!MovieList.UserId.Equals(userId))
            {
                return Redirect("/Identity/Account/AccessDenied");
            }
                
            MovieList.Movies = await _db.Movie.Where(m => m.MovieListId == MovieList.Id).ToListAsync();

            return Page();
        }



        public async Task<IActionResult> OnPostDelete(Guid id)
        {
            Movie theMovieToDelete = await _db.Movie.FindAsync(id);

            
            Guid listId = theMovieToDelete.MovieListId;
            
            if (theMovieToDelete == null)
                return NotFound();
                
            _db.Movie.Remove(theMovieToDelete);

            await _db.SaveChangesAsync();

            //return to same page (to reload & show updated values)
            return RedirectToPage("/movies/lists/edit",new {id = listId});
        }



        public async Task<IActionResult> OnPost(int[] categoryId)
        {
            
            if (ModelState.IsValid)
            {
                
                MovieList movieListFromDb = await _db.MovieList.FindAsync(MovieList.Id);
                movieListFromDb.Movies = await _db.Movie.Where(m => m.MovieListId == MovieList.Id).ToListAsync();
                

                foreach (int movieId in categoryId)
                {

                    string url = Util.GetMovieUrl(movieId);
                    var response = await _client.GetAsync(url);
                    var result = await response.Content.ReadAsStringAsync();
                    JObject obj = JObject.Parse(result);

                    if (!obj.ContainsKey("title"))
                        continue;

                    movieListFromDb.Movies.Add(new Movie
                    {
                        Title = obj["title"].ToString(),
                        Overview = obj["overview"].ToString(),
                        ImgPath = Util.IMG_URL + obj["poster_path"],
                        Rating = float.Parse(obj["vote_average"].ToString()),
                        MovieId = movieId,
                        MovieListId = MovieList.Id
                    });
                }

                movieListFromDb.Name = this.MovieList.Name;
                movieListFromDb.Description = this.MovieList.Description;
                

                await _db.SaveChangesAsync();
                
                return RedirectToPage("/movies/lists/index");
            }

            return RedirectToPage();
        } 
    }
}