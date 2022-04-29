using System.Collections.Generic;
using System.Threading.Tasks;
using FilmFabriken.Model;
using FilmFabriken.Model.User;
using FilmFabriken.wwwroot.cs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FilmFabriken.Pages
{
    
    [Authorize(Roles = "Admin")]
    public class Admin : PageModel
    {
        
        private ApplicationDbContext _db { get; set; }

        public Admin(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [BindProperty]
        public List<User> Users { get; set; }
        
        public async Task OnGet()
        {
            Users = await _db.User.ToListAsync();
        }
        
        
        public async Task<IActionResult> OnPostDelete(string id)
        {
            User userToDelete = await _db.User.FindAsync(id);

            if (userToDelete == null)
                return NotFound();
                
            _db.User.Remove(userToDelete);

            await _db.SaveChangesAsync();
            
            //return to same page (to reload & show updated values)
            return RedirectToPage("/admin");
        }
    }
}