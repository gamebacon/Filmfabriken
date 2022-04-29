using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilmFabriken.Pages.Movies
{
    [Authorize]
    public class Index : PageModel
    {
        public void OnGet()
        {
            
        }
    }
}