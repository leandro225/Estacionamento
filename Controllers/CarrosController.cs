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
        public static Carro PesquisaCarroPorPlaca(string pla)
        {
            Contexto ctx = new Contexto();
            List<Carro> lista = ctx.Carros.ToList();
            foreach (var item in lista)
            {
                if (item.Placa == pla)
                {
                    return item;

                }
            }
            return null;

        }


        public static Carro retornaCarroPorId(int id)
        {
            Contexto ctx = new Contexto();
            Carro c = ctx.Carros.Find(id);
            return c;
        }

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