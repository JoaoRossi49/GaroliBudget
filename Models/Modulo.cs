using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Models
{
    public class Modulo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEquipamento { get; set; }  
        public int IdOrcamento { get; set; }
        public int Ordem { get; set; }
    }
}
