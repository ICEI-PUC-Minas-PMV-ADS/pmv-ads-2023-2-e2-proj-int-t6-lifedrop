using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeDrop.Models
{

    [Table ("Agendamentos")]
    public class Agendamento
    {
        [Key]
        public int IdAgendamento { get; set; }
        public int IdDoador { get; set; }
        public int IdBancoDeSangue { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public Status StatusDaDoacao { get; set; }
        public virtual Doador Doador { get; set; }
        public virtual BancoDeSangue Unidade { get; set; }

    }

    public enum Status
    {
        Agendado = 0,
        Confirmado = 1,
        Cancelado = 2
    }
}