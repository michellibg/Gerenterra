using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTerra.Models
{
    [Table("parametro")]
    public class Parametro
    {
        [Key]public int id_parametro { get; set; }
        public string? nome { get; set; }
        public string? valor { get; set; }
        public string? descricao { get; set; }

    }
}
