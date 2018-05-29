using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controllers
{
   public class EstacionarController
    {
        public static string UltimaPlaca;
        private static List<Carro> carros = new List<Carro>();

        public static void GuardaPlaca(string placa)
        {
          UltimaPlaca = placa;
        }

        public static string RetornaPlaca()
        {
            return UltimaPlaca;

        }

        public static void darEntradaNoEstacionamento(Carro carro)
        {
            carro.setEstaEstacionado(true);
        }

        public static void darSaidaDoEstacionamento(Carro carro)
        {
            carro.setEstaEstacionado(false);
        }
    }
}
