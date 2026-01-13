using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Models
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public decimal CustoUnitario { get; set; }
        public bool Ativo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Total
        {
            get { return Quantidade * CustoUnitario; }
        }
        public Modulo Modulo { get; set; }
    }
}
