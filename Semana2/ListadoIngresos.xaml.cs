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
    /// Lógica de interacción para ListadoIngresos.xaml
    /// </summary>
    public partial class ListadoIngresos : Window
    {
        private static List<Ingreso> ingresos = new List<Ingreso>
        {
            new Ingreso { Fecha = DateTime.Now.AddDays(-2), Placa = "ABC123", Turno = "Mañana", Conductor = "Juan Pérez", Producto = "Cemento", Peso = 2000, Transporte = "Transporte 1" },
            new Ingreso { Fecha = DateTime.Now.AddDays(-1), Placa = "XYZ789", Turno = "Tarde", Conductor = "María López", Producto = "Arena", Peso = 1500, Transporte = "Transporte 2" },
            new Ingreso { Fecha = DateTime.Now, Placa = "LMN456", Turno = "Noche", Conductor = "Pedro Ruiz", Producto = "Grava", Peso = 2500, Transporte = "Transporte 3" }
        };
        public ListadoIngresos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgIngresos.ItemsSource = ingresos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = ingresos.AsEnumerable();

            // Filtro por fechas
            if (dpFechaInicio.SelectedDate.HasValue)
                query = query.Where(x => x.Fecha >= dpFechaInicio.SelectedDate.Value);

            if (dpFechaFin.SelectedDate.HasValue)
                query = query.Where(x => x.Fecha <= dpFechaFin.SelectedDate.Value);

            // Filtro por placa
            if (!string.IsNullOrWhiteSpace(txtPlacaFiltro.Text))
                query = query.Where(x => x.Placa.ToLower().Contains(txtPlacaFiltro.Text.ToLower()));

            // Filtro por conductor
            if (!string.IsNullOrWhiteSpace(txtConductorFiltro.Text))
                query = query.Where(x => x.Conductor.ToLower().Contains(txtConductorFiltro.Text.ToLower()));

            // Filtro por producto
            if (!string.IsNullOrWhiteSpace(txtProductoFiltro.Text))
                query = query.Where(x => x.Producto.ToLower().Contains(txtProductoFiltro.Text.ToLower()));

            dgIngresos.ItemsSource = query.ToList();
        }

        public class Ingreso
        {
            public DateTime Fecha { get; set; }
            public string Placa { get; set; }
            public string Turno { get; set; }
            public string Conductor { get; set; }
            public string Producto { get; set; }
            public double Peso { get; set; }
            public string Transporte { get; set; }
        }
    }
}
