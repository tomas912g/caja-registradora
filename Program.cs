const string nombre_kiosko = "Kiosko Bernabeu";
Console.WriteLine($"=== {nombre_kiosko} ===");
Console.Write("Nombre del cajero: ");
string nombre_cajerx = Console.ReadLine();
Console.WriteLine($"Bienvenido, {nombre_cajerx}. Caja abierta.");

Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();
Console.Write("Precio del producto: ");
decimal precioProducto = decimal.Parse(Console.ReadLine());
Console.WriteLine($"El producto: {nombreProducto}, cuesta {precioProducto}");