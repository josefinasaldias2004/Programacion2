using SupermercadoUwu.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoUwu.Clases
{
    internal class ArticulosElectronicos :  IProducto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public ArticulosElectronicos (string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"El nombre del articulo electronico es de {Nombre}" +
                $"\n El precio del articulo es de {Precio}");

        }

    }
}
