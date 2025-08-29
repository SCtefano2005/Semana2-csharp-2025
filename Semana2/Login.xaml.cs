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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Credenciales estáticas
            string usuarioValido = "admin";
            string passwordValido = "1234";

            string usuarioIngresado = txtUsername.Text;
            string passwordIngresado = txtPassword.Password;

            if (usuarioIngresado == usuarioValido && passwordIngresado == passwordValido)
            {
                MessageBox.Show("✅ Login correcto. Bienvenido " + usuarioIngresado, "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                // Aquí podrías abrir otra ventana y cerrar esta
                Menues menu = new Menues();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
