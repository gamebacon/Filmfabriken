using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FilmFabriken.Model.User
{
    public class User : IdentityUser
    {
        [Required]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "Kön")]
        public Gender Gender { get; set; }
        
        public override string ToString()
        {
            return
                $"firstname: {FirstName}\n" +
                $"lastname: {LastName}\n" +
                $"gender: {Gender}";
        } 
    }
}