using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR.Domain
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Campo {0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}