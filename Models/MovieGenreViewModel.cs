using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public SelectList Dates { get; set; }
        public string MovieGenre { get; set; }
        public string ReleaseDates { get; set; }
        public string SearchString { get; set; }
    }
    public class ReleaseDateViewModel
    {
        public List<Movie> Movies1 { get; set; }
        public SelectList Dates { get; set; }
        public string ReleaseDates { get; set; }
        public string SearchString { get; set; }
    }
}