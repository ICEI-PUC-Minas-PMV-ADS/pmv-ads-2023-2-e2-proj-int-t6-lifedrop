using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LifeDrop.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o senha")]
        public string Senha { get; set; }

        [Display(Name = "Selecione o usuario")]        
        public Origem Tipo { get; set; }
    }
    public enum Origem
    {
        Doador,
        Banco_De_Sangue
    }
}
