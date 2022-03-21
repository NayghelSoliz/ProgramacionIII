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

namespace Ej_Grafos
{
    /// <summary>
    /// El grafo implementado registra nombres de ciudades y pesos númericos en cada arista.
    /// El usuario indica el número de vertices y el programa le solicita que ingrese conexiones sugeridas.
    /// El programa controla todas las posibles combinaciones entre vértices.
    /// </summary>
    public partial class MainWindow : Window
    {
        int tamaño;
        Grafo Grafito;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCrearGrafo_Click(object sender, RoutedEventArgs e)
        {
            tamaño = int.Parse(TamañoGrafo.Text);
            Grafito = new Grafo(tamaño);

            for (int i = 0; i < tamaño; i++)
            {
                string cadena = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de vertices: ");
                Grafito.AddVertice(cadena);
            }
        }

        private void btnCrearConexiones_Click(object sender, RoutedEventArgs e)
        {
            int peso; 
            for(int f = 0; f < Grafito.CountVertices(); f++)
            {
                for(int j = 0; j < Grafito.CountVertices(); j++)
                {
                    if (f != j)
                    {
                        int resp = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Existe conexión entre: " + Grafito.Vertice(f) + " - " +  Grafito.Vertice(j) + "1: Para SI   0: Para NO"));
                        if(resp == 1)
                        {
                            peso = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el peso: "));
                            Grafito.AddPeso(peso, f, j);
                        }
                    }
                }

            }

        }

        private void btnMostraGrafo_Click(object sender, RoutedEventArgs e)
        {
            lstCiudades.Items.Clear();
            lstCiudades.Items.Add("VERTICES: ");
            for(int i = 0; i < Grafito.CountVertices(); i++)
            {
                lstCiudades.Items.Add(Grafito.Vertice(i));
            }
            lstCiudades.Items.Add("CONEXIONES: ");
            for(int j = 0; j < Grafito.CountVertices(); j++)
            {
                for(int x = 0; x < Grafito.CountVertices(); x++)
                {
                    if (Grafito.PesoArista(j, x) != 0)
                    {
                        lstCiudades.Items.Add(Grafito.Vertice(j) + " - " + Grafito.Vertice(x));
                    }
                }
            }


        }
    }
}
