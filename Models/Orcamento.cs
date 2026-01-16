using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Models
{
    public class Orcamento
    {
        public int IdOrcamento { get; set; }
        public Cliente cliente { get; set; }
        public Equipamento equipamento { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
        public decimal MargemContribuicao { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Material> Materiais { get; set; }
        public List<Componente> Componentes { get; set; }
        public List<Processo> Processos { get; set; }
        public bool Ativo { get; set; }
    }

}
