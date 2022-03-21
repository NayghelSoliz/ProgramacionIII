using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Grafos
{
    class Grafo
    {
        string[] arreglo;
        int cont; // Cuenta los elementos ingresados al arreglo
        int[,] matriz;

        public Grafo(int cantidadVertices)
        {
            arreglo = new string[cantidadVertices];
            matriz = new int[cantidadVertices, cantidadVertices];
        }

        public void AddVertice(string cadena)
        {
            arreglo[cont] = cadena;
            cont++;
        }

        public void AddPeso(int peso, int fila, int columna)
        {
            matriz[fila, columna] = peso;
        }

        public int CountVertices()
        {
            return arreglo.Length;
        }

        public string Vertice(int indice)
        {
            if (indice < arreglo.Length)
            {
                return arreglo[indice];
            }
            else
            {
                return "Posición no encontrada";
            }
        }

        public int PesoArista(int fila, int columna)
        {
            return matriz[fila, columna];
        }

        public int BuscarIndice(string vertice)
        {
            int posicion = -1;
            for(int i = 0; i < arreglo.Length ;i++)
            {
                if (arreglo[i] == vertice)
                {
                    posicion = i;
                }
            }
            return posicion;
        }


    }
}
