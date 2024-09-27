using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTerra.Models
{
    [Table("ordemservico")]
    public class OrdemServico
    {
        [Key]public int id_ordem_servico { get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }
        public int id_empresa { get; set; }
        public DateTime data_cadastro { get; set; }
        public DateTime hora_agendada { get; set; }
        public string descricao_servico { get; set; }
        public string previsao_duracao { get; set; }
        public string endereco_servico { get; set; }
        public string ponto_ref { get; set; }
        public bool gerar_nf { get; set; }
        public string nome_servico { get; set; }
        public string resp_nome { get; set; }
        public string resp_contato { get; set; }
        public string bairro_servico { get; set; }
        public int id_cidade { get; set; }
        public int id_estado { get; set; }
    }
}
