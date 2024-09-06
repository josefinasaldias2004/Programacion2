using SupermercadoUwu.Clases;
using SupermercadoUwu.Interface;

namespace SupermercadoUwu
{
    class Program {
        static void Main()
        {


            List<IProducto> ListaProductos = new List<IProducto>
            {
                new Alimentos("Frutilla", 100),
                new ArticulosElectronicos("Laptop", 900000),
                new PrendasRopa("vestido", 10000)

            };
            foreach (IProducto producto in ListaProductos)
            {
                producto.MostrarDetalles();
            }
        }
    }
}