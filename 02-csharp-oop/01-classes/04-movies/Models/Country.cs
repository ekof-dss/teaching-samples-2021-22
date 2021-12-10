using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public partial class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Actor> Actors { get; set; }

        public ICollection<Director> Directors { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}