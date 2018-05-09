using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Modelos.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("stringConn")
        {

        }

        public DbSet<Carro> Carros { get; set; }
    }
}




   
    

        

       