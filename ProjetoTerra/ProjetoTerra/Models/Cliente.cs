using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTerra.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key] public int id_cliente { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string? endereco { get; set; }
        public string cidade { get; set; }
        public string? email { get; set; }
        public string? documento { get; set; }
        public string? complemento { get; set; }
        public string? anotacoes { get; set; }
        public string? estado { get; set; }
    }
}
