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
        [Display(Name = "Nome da Unidade")]
        public string NomeUnidade { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o endereço")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o município")]
        public string Municipio { get; set; }

        public string O_Positive { get; set; }
        public string O_Negative { get; set; }
        public string A_Positive { get; set; }
        public string A_Negative { get; set; }
        public string B_Positive { get; set; }
        public string B_Negative { get; set; }
        public string AB_Positive { get; set; }
        public string AB_Negative { get; set; }
    }

}     