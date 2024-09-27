using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTerra.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]public int id_usuario { get; set; }
        public string? nome { get; set; }
        public string? login { get; set; }
        public string? senha { get; set; }
        public string? perfil { get; set; }

    }
}
