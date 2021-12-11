using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Chef_N_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Field must be 3 characters or more")]
        [Display(Name = "Name of Dish:")]
        public string DishName { get; set; }

        [Required]
        [Range(1,5000)]
        [Display(Name = "Dish Calories:")]
        public string Calories { get; set; }

        [Required]
        [Range(1,5)]
        [Display(Name = "Tastiness:")]
        public string Tastiness { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Field must be 3 characters or more")]
        [Display(Name = "Description:")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Chef AllDishes { get; set; }
        public int ChefId { get; set; }
        //public List<Chef> ChefList { get; set; }


    }
}