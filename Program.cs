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
            Console.WriteLine($"Venta Finalizada. Se cargaron {cantidadProductos} productos.");
            const decimal descuentoDiez = 0.10m;
            const decimal descuentoCinco = 0.05m;
            decimal descuento = 0;
            if (totalVenta > 50000)
            {
                descuento = totalVenta * descuentoDiez;
            }
            else if (totalVenta > 20000)
            {
                descuento = totalVenta * descuentoCinco;
            }
            
            string? metodoPago = "";
            const decimal descuentoEfectivo = 0.10m;
            const decimal recargoCredito = 0.15m;
            decimal descuentoE = 0;
            decimal recargoC = 0;
            do
            {
                Console.WriteLine($"Elija un modo de pago:");
                Console.WriteLine($"1 - Efectivo");
                Console.WriteLine($"2 - Debito");
                Console.WriteLine($"3 - Credito");
                metodoPago = Console.ReadLine();
                switch (metodoPago)
                {
                    case "1":
                        descuentoE = totalVenta * descuentoEfectivo;
                        break;
                    case "2":
                        break;
                    case "3":
                        recargoC = totalVenta * recargoCredito;
                        break;
                    default:
                        Console.WriteLine($"Ingrese una opcion valida");
                        break;
                }
            } while (metodoPago != "1" && metodoPago != "2" && metodoPago != "3");
            decimal totalFinal = totalVenta - descuento - descuentoE + recargoC;

            decimal descuentoTotal = descuento + descuentoE;

            string guiones = "";
            for(int i = 0; i < 30; i++)
            {
                guiones += "-";
            }
            Console.WriteLine(guiones);
            Console.WriteLine($"     {nombre_kiosko}");
            Console.WriteLine(guiones);
            Console.WriteLine($"Cajero: {nombre_cajerx}");
            Console.WriteLine($"Productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: {totalVenta}");
            Console.WriteLine($"Descuento: {descuentoTotal}");
            Console.WriteLine($"Recargo pro Credito: {recargoC}");
            Console.WriteLine(guiones);
            Console.WriteLine($"Precio Final: {totalFinal}");
            Console.WriteLine(guiones);
            break;

        default:
            Console.WriteLine($"Opción no valida. Por favor eliga una opcion válida");
            break;
    }

} while (opciones != "2");

