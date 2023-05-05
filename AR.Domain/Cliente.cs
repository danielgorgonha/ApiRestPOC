using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Campo {0} deve ter no máximo {1} caracteres")]
        public int Nome { get; set; }
        public int CPF { get; set; }
        public int Idade { get; set; }
    }
}