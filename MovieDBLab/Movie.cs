using System;
using System.Collections.Generic;

#nullable disable

namespace MovieDBLab
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public float? Runtime { get; set; }
    }
}
