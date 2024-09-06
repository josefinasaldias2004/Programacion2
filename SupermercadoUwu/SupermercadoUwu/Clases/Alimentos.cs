using SupermercadoUwu.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoUwu.Clases
{
    internal class Alimentos : IProducto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Alimentos(string nombre , decimal precio)
        {
        
            Nombre = nombre;
            Precio = precio;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"El precio del alimento es de {Precio}" +
                $"\n El nombre del alimento es de {Nombre}");    
        }
    }
}
