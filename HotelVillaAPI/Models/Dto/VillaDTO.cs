﻿using System.ComponentModel.DataAnnotations;

namespace HotelVillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        // applying data annotation will give errors if the below constraints are not met they are built in for this validation to be active you 
        // have to make sure your controller has the [APIController] at the top or you have to directly check model state in your controller method
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
    }
}