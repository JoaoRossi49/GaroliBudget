using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Models
{
    public class Processo
    {
        public int IdProcesso { get; set; }
        public string Descricao { get; set; }
        public decimal CustoHora { get; set; }
        public bool Ativo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Total
        {
            get { return Quantidade * CustoHora; }
        }
        public Modulo Modulo { get; set; }
        public int IdEquipamento { get; set; }
    }
}
