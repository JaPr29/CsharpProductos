using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    public class Supermecado
    {
        public string Nombre { get; set; }
        public List<Producto> ListaProductos { get; set; }

        public Supermecado(string nombre, List<Producto> lista)
        {
            Nombre = nombre;
            ListaProductos = lista;
        }

        private Producto BuscarProducto(string nombreproducto)
        {
            foreach (var item in ListaProductos)
            {
                if (item.Nombre == nombreproducto)
                {
                    return item;
                }
            }
            return null;
        }

        public void AgregarProducto()
        {
            Console.WriteLine("Qué producto desea agregar?");
            string nombre = Console.ReadLine();
            Console.WriteLine("Cuanto es el precio?");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos hay en stock?");
            int cantidadStock = int.Parse(Console.ReadLine());
            Producto p = new Producto(nombre, precio,cantidadStock);
            ListaProductos.Add(p);
            
        }
        public void QuitarProducto()
        {
            Console.WriteLine("¿Qué producto desea eliminar?:");
            string producto = Console.ReadLine();
            Producto ProductoDisponible = BuscarProducto(producto);
            if (ProductoDisponible != null)
            {
                ListaProductos.Remove(ProductoDisponible);
                Console.WriteLine("Producto eliminado");
            }
            else 
            {
                Console.WriteLine("El producto no existe");
            }
        }
        public void MostrarProductos()
        {
            if (ListaProductos.Count == 0)
            {
                Console.WriteLine("No hay productos");
                return;
            }
            foreach (var item in ListaProductos)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ||| Precio: {item.Precio} ||| Cantidad en Stock: {item.CantidadStock}");
            }
        }

        public void CalcularStockTotal()
        {
            int stockTotal = 0;
            foreach (var item in ListaProductos)
            {
                stockTotal += item.CantidadStock;
            }
            Console.WriteLine("El stock total es: " + stockTotal);
        }

        
    }
}
