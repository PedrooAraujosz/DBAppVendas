using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }

        [Display(Name = "descrição")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter, no maximo, 100 caracteres! ")]
        public string CategoriaNome { get; set; }
    }
}
