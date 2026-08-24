const string nombre_kiosko = "Kiosko Bernabeu";
Console.WriteLine($"=== {nombre_kiosko} ===");
Console.Write("Nombre del cajero: ");
string? nombre_cajerx = Console.ReadLine();
Console.WriteLine($"Bienvenido, {nombre_cajerx}. Caja abierta.");

int cantidadProductos = 0;
decimal totalVenta = 0;
string? opciones = "";
do
{
    Console.WriteLine("Que desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    opciones = Console.ReadLine();
    switch (opciones)
    {
        case "1":
            Console.Write("Nombre del producto que desea agregar: ");
            string? nombreProducto = Console.ReadLine();
            Console.Write("Precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine($"El producto: {nombreProducto}, cuesta {precioProducto}");

            cantidadProductos++;
            totalVenta += precioProducto;

            break;

        case "2":
            Console.WriteLine($"Venta Finalizada. Se cargaron {cantidadProductos} productos. Total: {totalVenta}");
            break;

        default:
            Console.WriteLine($"Opción no valida. Por favor eliga una opcion válida");
            break;
    }

} while (opciones != "2");

