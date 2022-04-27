using System;

namespace FilmFabriken.wwwroot.cs
{
    public class Util
    {
        public enum Role {Default, Admin, All}
    
        public static String GetRole(Role role)
        {
            return role == Role.All ? String.Join(',', Enum.GetValues(typeof(Role))) : role.ToString();
        }
        
        public static string EnumToString(Enum e)
        {
            return e.ToString().Replace('_', ' ');
        } 
    }
}