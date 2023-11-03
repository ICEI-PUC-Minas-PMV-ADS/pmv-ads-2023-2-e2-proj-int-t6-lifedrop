using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LifeDrop.Models
{
    [Table("BancosDeSangue")]
    public class BancoDeSangue
    {
        [Key]
        public int IdBancoDeSangue { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome da unidade")]
        public string NomeUnidade { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o município")]
        public string Municipio { get; set; }
    }
}