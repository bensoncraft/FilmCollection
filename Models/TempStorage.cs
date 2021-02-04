using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public static class TempStorage
    {
        private static List<ApplicationResponse> movies = new List<ApplicationResponse>();

        public static IEnumerable<ApplicationResponse> Movies => movies;

        public static void AddMovie(ApplicationResponse movie)
        {
            movies.Add(movie);
        }
    }
}
