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
    /// Lógica de interacción para NuevoConductor.xaml
    /// </summary>
    public partial class NuevoConductor : Window
    {
        public NuevoConductor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conductor nuevo = new Conductor
            {
                NombreConductor = txtNombreConductor.Text,
                Licencia = txtLicencia.Text,
                Transporte = txtTransporte.Text
            };

            // Guardarlo en la lista estática
            Conductor.ListaConductores.Add(nuevo);

            MessageBox.Show("Conductor agregado a la lista");

            ConductorTabla conductorTabla = new ConductorTabla();
            conductorTabla.Show();
            this.Close();
        }

        
    }
}
