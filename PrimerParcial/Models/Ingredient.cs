using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation; 

namespace PrimerParcial.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = "";  

        [Required, StringLength(50)]
        public string Quantity { get; set; } = ""; 

        [Range(1, int.MaxValue, ErrorMessage = "Selecciona una receta válida.")]
        public int RecipeId { get; set; }

        [ValidateNever]
        public Recipe? Recipe { get; set; }
    }
}
