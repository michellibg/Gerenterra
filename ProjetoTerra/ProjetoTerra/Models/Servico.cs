using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTerra.Models
{
    [Table("servico")]
    public class Servico
    {
        [Key]public int id_servico { get; set; }
        public string? nome { get; set; }
        public Double? preco { get; set; }
        public string? tipo { get; set; }
        public string? descricao { get; set; }
    }
}
