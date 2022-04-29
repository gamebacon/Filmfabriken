using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using FilmFabriken.Model;
using FilmFabriken.Model.MovieStuff;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace FilmFabriken.Pages.Movies.Lists
{
    [Authorize]
    public class Index : PageModel
    {
        private readonly HttpClient _client;

        
        private readonly ApplicationDbContext _db;
        
        public IEnumerable<MovieList> MovieLists { get; set; }

        public Index(ApplicationDbContext db, HttpClient client)
        {
            _db = db;
            _client = client;
        }
        
        public async Task OnGet()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            MovieLists = await _db.MovieList
                .Include(ml => ml.Movies)
                .Where(list => list.UserId == Guid.Parse(userId))
                .ToListAsync();
        }

        public async Task OnPost(int sortBy)
        {
            
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            MovieLists = await _db.MovieList
                .Include(ml => ml.Movies)
                .Where(list => list.UserId == Guid.Parse(userId))
                .ToListAsync();
            
            
            foreach (MovieList movieList in MovieLists)
                bubbleSort(movieList.Movies, sortBy);
        }
        
        static void bubbleSort(List<Movie> movies, int by) {
            int size = movies.Count;
    
            for (int i = 0; i < size - 1; i++)
    
            for (int j = 0; j < size - i - 1; j++)

                if (by == 0 ? (movies[j].Rating < movies[j + 1].Rating) : (movies[j].Title.CompareTo(movies[j + 1].Title) > 0)) {

                    Movie temp = movies[j];
                    movies[j] = movies[j + 1];
                    movies[j + 1] = temp; 
                }
        }

        public async Task<IActionResult> OnPostDelete(Guid id)
        {
            MovieList theMovieListToDelete = await _db.MovieList.FindAsync(id);
            
            if (theMovieListToDelete == null)
                return NotFound();
                
            _db.MovieList.Remove(theMovieListToDelete);

            await _db.SaveChangesAsync();
            
            //return to same page (to reload & show updated values)
            return RedirectToPage("/movies/lists/index");
        }
    }
}