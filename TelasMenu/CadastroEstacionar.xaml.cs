using Modelos;
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


namespace TelasMenu
{
    /// <summary>
    /// Interaction logic for Estacionar.xaml
    /// </summary>
    public partial class CadastroEstacionar : Window
    {
        public static List<Carro> novaLista = new List<Carro>();

        public CadastroEstacionar()
        {

            InitializeComponent();
            novaLista = Controllers.CarrosController.retornaTodosCarros();
           // DtGrid.ItemsSource = null;
           // DtGrid.ItemsSource = novaLista;
            txtPlaca.Focus();
        }


        
        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Carro novoCarro = new Carro();

                novoCarro.Placa = txtPlaca.Text;
                novoCarro.Modelo = txtModelo.Text;
                novoCarro.Cor = txtCor.Text;

                Controllers.CarrosController.SalvarCarrosCadastrados(novoCarro);

                MessageBox.Show("Cadastrado Com Sucesso!!!", "Sucesso");
                //DtGrid.ItemsSource = Controllers.CarrosController.retornaTodosCarros();
                //this.Close();



            }
            catch (Exception)
            {

                MessageBox.Show("! Favor Inserir Todos Os Dados Corretamente!", "Atenção");
            }
        }

       
    }
}