using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FilmFabriken.Model.User
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

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