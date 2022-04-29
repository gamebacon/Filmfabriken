using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FilmFabriken.wwwroot.cs
{
    public class Util
    {
        
        public const string API_KEY = "1c345153a54c683b1844784f665df566";
        public const string BASE_URL = "https://api.themoviedb.org/3";
        public const string IMG_URL = "https://image.tmdb.org/t/p/w500";

        
        public enum Role {Default, Admin, All}

        public static String GetRole(Role role)
        {
            return role == Role.All ? String.Join(',', Enum.GetValues(typeof(Role))) : role.ToString();
        }
        
        public static string EnumToString(Enum e)
        {
            return e.ToString().Replace('_', ' ');
        }

        public static string GetImageURL(string imgPath)
        {
            return $"{IMG_URL}{imgPath}";
        }
        
        public static string GetMovieUrl(int movieId)
        {
            return $"{BASE_URL}/movie/{movieId}?api_key={API_KEY}";
        }
        
        

    }
}