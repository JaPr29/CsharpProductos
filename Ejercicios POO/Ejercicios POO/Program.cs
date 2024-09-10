/*
4_Interfaz de usuario:

Implementar un menú en la consola que permita al usuario interactuar con el sistema, con las siguientes opciones:
-Agregar producto.
-Eliminar producto.
-Ver productos.
-Ver stock total.
-Salir del programa.

Ejemplo de ejecución:
markdown
Copiar código
Bienvenido al sistema de gestión del Supermercado "La Economía"

1. Agregar producto
2. Eliminar producto
3. Ver productos
4. Ver stock total
5. Salir
 */

using Ejercicios_POO;
using System;

List<Producto> productos = new List<Producto>();

Supermecado supermecado = new Supermecado(nombre: "La Chuuparativa", lista: productos);


while (true)
{
    Console.WriteLine($"Bienvenido a {supermecado.Nombre} ");
    Console.WriteLine("Seleccione una opción por favor:");

    Console.WriteLine(" 1. Agregar producto \n 2. Eliminar producto \n 3. Ver productos \n 4. Ver stock total \n 5. Salir");

    string opciónseleccionada = Console.ReadLine();

    switch (opciónseleccionada)
    {
        case "1":
            supermecado.AgregarProducto();
            break;
        case "2":
            supermecado.QuitarProducto();
            break;
        case "3":
            supermecado.MostrarProductos();
            break;
        case "4":
            supermecado.CalcularStockTotal();
            break;
        case "5":
            return;
        default:
            break;
    }
    Console.WriteLine("Presione enter para continuar...");
    Console.ReadLine();
    Console.Clear();

}