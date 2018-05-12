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

        List<Carro> ListarCarros = new List<Carro>();
        public TelaEstacionar()
        {
            InitializeComponent();
        }

        

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPesquisarPlaca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // realiza a pesquisa do cliente passando o telefone como parâmetro e recebe o objeto 
                Carro Recep = Controllers.CarrosController.PesquisaCarroPorPlaca(txtPlaca.Text);

                if (Recep == null)
                {
                    MessageBox.Show("Veiculo Não Cadastrado No Sistema", "Informação", MessageBoxButton.OK);
                    Controllers.EstacionarController.GuardaPlaca(txtPlaca.Text);
                    CadastroEstacionar tela = new CadastroEstacionar();
                    tela.ShowDialog();
                }
                //else
                //{
                //    // Caso o cliente já esteja cadastrado, as informações aparecerão na tela
                //    blockPlaca.Text = Recep.ClienteID.ToString();
                //    blockNome.Text = Recep.Nome;
                //    blockFone.Text = Recep.Telefone.ToString();
                //    blockEnd.Text = Recep.Endereco;
                //    blockNr.Text = Recep.Numero.ToString();
                //    blockBairro.Text = Recep.Bairro;
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Por Favor, Insira O Telefone", "Informação", MessageBoxButton.OK);
            }

        }

    }
}
