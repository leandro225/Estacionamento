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


        public static void GuardaPlaca(string placa)
        {
          UltimaPlaca = placa;
        }
    }
}
