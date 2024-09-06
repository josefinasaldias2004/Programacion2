﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoUwu.Interface
{
    public interface IProducto
    {
       public string Nombre { get; set; }
        public decimal Precio { get; set; }

       public abstract void MostrarDetalles();
    }
}
