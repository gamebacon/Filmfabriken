using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FilmFabriken.Model.MovieStuff
{
    public class MovieList
    {
        
        [Key]
        public Guid Id { get; set; }
        
        public Guid UserId { get; set; }
        
        [Display(Name = "Namn")]
        public string Name { get; set; }
        
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        
        //Nav prop
        public List<Movie> Movies { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}";
        }
    }
}