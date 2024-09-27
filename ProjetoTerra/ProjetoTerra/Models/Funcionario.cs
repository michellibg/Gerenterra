using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTerra.Models
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Key]public int id_funcionario { get; set; }
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public string? telefone { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }
        public int? id_usuario { get; set; }
    }
}
