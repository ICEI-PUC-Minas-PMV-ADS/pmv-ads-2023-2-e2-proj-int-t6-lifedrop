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
        public int StatusDaDoacao { get; set; }

    }
}
