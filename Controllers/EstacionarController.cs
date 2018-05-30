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

        public static Entrada ultimoCarro = new Entrada();
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

        public static void SalvarEntrada(Entrada novaEntrada)
        {
            ultimoCarro = novaEntrada; //guarda as informações do último pedido realizado para ser usado na tela de Pedido Finalizado

            //int id = ultimoID + 1;
            //ultimoID = id;
            //novoPedido.PedidoID = ultimoID;
            //pedidos.Add(novoPedido);

            Contexto ctx = new Contexto();
            ctx.Estacionados.Add(novaEntrada);
            ctx.SaveChanges();


        }

        public static List<Carro> retornaCarros()
        {
            Contexto ctx = new Contexto();
            return ctx.Carros.ToList();
        }


    }
}
