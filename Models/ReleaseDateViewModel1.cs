using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class ReleaseDateViewModel1
    {
        public List<Movie> Movies1 { get; set; }
        public string ReleaseDates { get; set; }
        public SelectList Dates { get; set; }
        public System.DateTime SearchString { get; set; }
    }
}