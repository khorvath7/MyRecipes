using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyRecipes.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Difficulty must be between 1-5")]
        public int Diffictuly { get; set; }
        [Display(Name = "Cook Time")]
        public string CookTime { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Ingredients { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Instructions { get; set; }
        }
}