using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Modelos;

namespace TelasMenu
{
    /// <summary>
    /// Interaction logic for TelaEstacionar.xaml
    /// </summary>
    public partial class TelaEstacionar : Window
    {
        public static List<Carro> novaLista = new List<Carro>();

        List<Carro> ListarCarros = new List<Carro>();
        public TelaEstacionar()
        {
            InitializeComponent();
            txtPlaca.Focus();
        }



        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPesquisarPlaca_Click(object sender, RoutedEventArgs e)
        {



            if (txtPlaca.Text.Equals(""))
            {

                MessageBox.Show("Por Favor, Insira A Placa", "Informação", MessageBoxButton.OK);

            }
            else
            {
                // realiza a pesquisa da placa passando ela como parâmetro e recebe o objeto 
                Carro Recep = Controllers.CarrosController.PesquisaCarroPorPlaca(txtPlaca.Text);
                if (Recep == null)
                {
                    MessageBox.Show("Veiculo Não Cadastrado No Sistema", "Informação", MessageBoxButton.OK);
                    Controllers.EstacionarController.GuardaPlaca(txtPlaca.Text);

                    CadastroEstacionar tela = new CadastroEstacionar();

                    tela.ShowDialog();

                }
                else
                {

                    //Caso o carro já esteja cadastrado, as informações aparecerão na tela

                    blockPlaca.Text = Recep.Placa;
                    blockModelo.Text = Recep.Modelo;
                    blockCor.Text = Recep.Cor;
                    blockId.Text = Recep.CarroID.ToString();
                }


            }


        }

    
        private void Button_Estacionar_Click(object sender, RoutedEventArgs e)
        {

            
             Entrada novaEntrada = new Entrada();

             novaEntrada.clienteId = int.Parse(blockId.Text);

             novaEntrada.DataEstacionar = DateTime.Now.ToString();

            Controllers.EstacionarController.SalvarEntrada(novaEntrada);
            TelaEstacionado novaTela = new TelaEstacionado();
            novaTela.ShowDialog();

        }
    }
}
