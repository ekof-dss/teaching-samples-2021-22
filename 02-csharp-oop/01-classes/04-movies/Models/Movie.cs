using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public class Movie
    {
        public long Id { get; set; }
        string Title { get; set; }
        public Country? Country { get; set; }
        public DateTime? DateOfRelease { get; set; }
        public Director? Director { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }

    }
}