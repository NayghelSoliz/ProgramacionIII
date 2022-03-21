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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenUnidad1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            //txtJuegos.Text = ;

        }
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.txtJuegos.Text = null;
            this.txtParques.Text = null;
            this.txtCap.Text = null;
        }
    }
}
