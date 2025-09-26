using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation; 

namespace PrimerParcial.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        public int PreparationTimeMinutes { get; set; }
        public int Servings { get; set; }

        [Required]
        public string Instructions { get; set; } = "";

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        [ValidateNever]
        public Category? Category { get; set; } 

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
