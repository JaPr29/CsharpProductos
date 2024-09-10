using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int CantidadStock { get; set; }

        public Producto(string nombre, double precio, int cantidadStock)
        {
            Nombre = nombre;
            Precio = precio;
            CantidadStock = cantidadStock;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($" Cantidad en Stock: {CantidadStock}");
        }
    }
}
