﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TruYumWeb.Models
{
    public class MenuItems
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Date Of Launch")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfLaunch { get; set; }



        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Free Delivery")]
        public bool FreeDelivery { get; set; }
    }
}