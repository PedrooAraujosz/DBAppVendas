using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "descrição")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter, no maximo, 100 caracteres! ")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo!")]

        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo!")]
        [Display(Name = "Estoque atual")]
        public double QtadeEstoque { get; set; }
        [Display(Name = "Positivo?")]
        public bool? CadastroAtivo { get; set; } = true;
        [Display(Name = "Categoria")]
        /* Chave Estrangeira */
        [Required(ErrorMessage = " Por favor, selecione uma Cliente")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
