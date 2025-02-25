﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ModelLayer
{
    public class City
    {
        [Key]
        public int CityID { get; set; }


        [Required]
        [MinLength(length: 3, ErrorMessage = "*Atleast have 3 characters.")]
        [MaxLength(length: 20, ErrorMessage = "*Only 20 characters allowed.")]
        
        public string CityName { get; set; }

        public City()
        {

        }

        public City( int id, string name)
        {
            CityID = id;
            CityName = name;
        }
    }

    

}
