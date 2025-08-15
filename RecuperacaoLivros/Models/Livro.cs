using System.ComponentModel.DataAnnotations;

namespace RecuperacaoLivros.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 100 caracteres")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O autor é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O autor deve ter entre 3 e 50 caracteres")]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O ano de publicação é obrigatório")]
        [Range(1500, 2100, ErrorMessage = "Ano inválido")]
        public int AnoPublicacao { get; set; }
    }
}
