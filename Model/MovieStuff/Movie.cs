using System;
using System.ComponentModel.DataAnnotations;

namespace FilmFabriken.Model.MovieStuff
{
    public class Movie
    {

        [Key] 
        public Guid Id { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string ImgPath { get; set; }
        public float Rating { get; set; }
        public float Popularity { get; set; }

        public Guid MovieListId { get; set; }
        
        //Nav prop
        public MovieList MovieList { get; set; }
    }
}