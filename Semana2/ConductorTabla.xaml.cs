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

namespace Semana2
{
    /// <summary>
    /// Lógica de interacción para ConductorTabla.xaml
    /// </summary>
    public partial class ConductorTabla : Window
    {
        public ConductorTabla()
        {
            InitializeComponent();
            dgConductores.ItemsSource = Conductor.ListaConductores;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Menues menu = new Menues();
            menu.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NuevoConductor nv = new NuevoConductor();
            nv.Show();
            this.Close();
        }
    }
}
