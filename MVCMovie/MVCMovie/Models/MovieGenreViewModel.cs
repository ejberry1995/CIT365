using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class MovieGenreViewModel
    {
        public MovieGenreViewModel ()
        {
            Genres = new SelectList(new List<string>() { "Action", "Animation", "Comedy", "Drama", "Documentary", "Romance", "Thriller" });
        }

        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public string Rating { get; set; }
        public string SortOption { get; set; }
    }
}
