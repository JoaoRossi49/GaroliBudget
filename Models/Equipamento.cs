using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Models
{
    public class Equipamento
    {
        public int IdEquipamento { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public List<Material> Materiais { get; set; }
        public List<Componente> Componentes { get; set; }
        public List<Processo> Processos { get; set; }
        public bool Ativo { get; set; }
    }

}
