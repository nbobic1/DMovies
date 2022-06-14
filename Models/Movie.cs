﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMovies.Models
{
    public class Movie
    {
        public Movie()
        {

        }
        [Key]
        public int Id { get; set; }
        public string name { get; set; }    
        public double rating { get; set; }
        public string streamLink { get; set; }
        [ForeignKey("MovieInfo")]
        public MovieInfo movieInfo { get; set; }    

    }
}