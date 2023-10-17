using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LifeDrop.Models
{
    [Table("Doadores")]
    public class Doador
    {
        [Key]
        public int IdDoador { get; set; }

        public int IdUsuario { get; set; }

        //public virtual Usuario Usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo sanguíneo")]
        public string TipoSanguineo { get; set; }
    }
}
