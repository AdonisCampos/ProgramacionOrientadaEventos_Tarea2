using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTarjetas
{
    public class Producto
    {
        // Propiedades de la clase Producto
        public string Nombre { get; set; }
        public double Precio { get; set; }
        // Constructor de la clase Producto
        public Producto()
        {
        // Inicializar con un valor por defecto
            Nombre = string.Empty; 
        }
    }
}
