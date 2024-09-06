using SupermercadoUwu.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoUwu.Clases
{
    internal class PrendasRopa : IProducto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }


        public PrendasRopa ( string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"La prenda es {Nombre}" +
                $"\n El precio de {Nombre} es de : {Precio}");

        }
    }
}
