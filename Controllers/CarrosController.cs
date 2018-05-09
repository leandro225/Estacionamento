using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controllers
{
    public class CarrosController
    {
        static List<Carro> MeusCarrosSalvos = new List<Carro>();
        //static int ultimoID = 0;

        public static void SalvarCarrosCadastrados(Carro carro)
        {
            Contexto ctx = new Contexto();
            ctx.Carros.Add(carro);
            ctx.SaveChanges();

        }

        public static List<Carro> retornaTodosCarros()
        {
            Contexto ctx = new Contexto();
            return ctx.Carros.ToList();
        }


        //    public Carro PesquisarPorID(int idCarro)
        //    {
        //        var c = from x in MeusCarrosSalvos
        //                where x.CarroID.Equals(idCarro)
        //                select x;

        //        if (c != null)
        //            return c.FirstOrDefault();
        //        else
        //            return null;
        //    }

        //public static Carro BuscarPelaPlaca(string busca)
        // {

        // for(int i = 0; i <= MeusCarrosSalvos.Capacity; i++)
        // {
        //    if(busca.Equals(MeusCarrosSalvos))
        //  }


        // }
        //public Carro PesquisarPorPlaca(string buscar)
        //{
        //    var c = from x in MeusCarrosSalvos
        //            where x.Placa.ToLower().Contains(buscar.Trim().ToLower())
        //            select x;

        //    if (c != null)
        //        return c.FirstOrDefault();
        //    else
        //        return null;
        //}

        //public static void DarEntradaNoEstacionamento(Carro carros)
        //{
        //    carros.setEstaEstacionado(true);
        //}
        //public static void DarSaidaNoEstacionamento(Carro carros)
        //{
        //    carros.setEstaEstacionado(false);
        //}

        //public static List<Carro> CarrosNoEstacionamento()

        //{
        //    List <Carro>  ListaDois = new List<Carro>();

        //    for (int i = 0; i < MeusCarrosSalvos.Capacity; i++)
        //    {
        //        if (MeusCarrosSalvos.s)
        //        {

        //        }
        //    }


        //}

        // }
    }
}