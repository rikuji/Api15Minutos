using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api15Minutos.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must contain between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must contain between 3 and 60 characters")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "This field needs to have at the max 1024 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "this field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "price must be greater than zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "this field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Category Invalid")]
        public int CategoryId { get; set; }//  to the banc

        public Category Category { get; set; }//property navegation

    }
}
