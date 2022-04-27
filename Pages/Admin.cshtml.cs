using FilmFabriken.wwwroot.cs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilmFabriken.Pages
{
    
    [Authorize(Roles = Role.Admin)]
    public class Admin : PageModel
    {
        public void OnGet()
        {
            
        }
    }
}