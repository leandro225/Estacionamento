using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Entrada
    {

       public int entradaId {get ; set ;}

       public string DataEstacionar { get; set; }

        public int clienteId { get; set; }

        public Carro carro { get; set; }

        public double Total { get; set; }

       

    }
}
