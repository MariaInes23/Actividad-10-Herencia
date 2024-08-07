using Actividad_10_Herencia;


    static void Main(string[] args)
    {
    List<Producto> productos = new List<Producto>();
    bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Agregar nuevos productos (Teléfono, Ordenador, Tablet).");
            Console.WriteLine("2. Listar todos los productos registrados.");
            Console.WriteLine("3. Buscar productos por nombre.");
            Console.WriteLine("4. Salir del programa.");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProducto();
                    break;
                case "2":
                    ListarProductos();
                    break;
                case "3":
                    BuscarProducto();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void AgregarProducto()
    {
        Console.WriteLine("Seleccione el tipo de producto a agregar:");
        Console.WriteLine("1. Teléfono");
        Console.WriteLine("2. Ordenador");
        Console.WriteLine("3. Tablet");
        Console.Write("Seleccione una opción: ");

        string tipo = Console.ReadLine();

        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        switch (tipo)
        {
            case "1":
                Console.Write("Ingrese el modelo del teléfono: ");
                string modelo = Console.ReadLine();
                productos.Add(new Telefono(nombre, precio, modelo));
                break;
            case "2":
                Console.Write("Ingrese el procesador del ordenador: ");
                string procesador = Console.ReadLine();
                productos.Add(new Ordenador(nombre, precio, procesador));
                break;
            case "3":
                Console.Write("Ingrese el tamaño de pantalla de la tablet: ");
                string tamanoPantalla = Console.ReadLine();
                productos.Add(new Tablet(nombre, precio, tamanoPantalla));
                break;
            default:
                Console.WriteLine("Tipo de producto no válido.");
                break;
        }
    }

    static void ListarProductos()
    {
        Console.WriteLine("Lista de productos registrados:");
        foreach (var producto in productos)
        {
            if (producto is Telefono telefono)
            {
                Console.WriteLine(telefono.ObtenerDescripcion());
            }
            else if (producto is Ordenador ordenador)
            {
                Console.WriteLine(ordenador.ObtenerDescripcion());
            }
            else if (producto is Tablet tablet)
            {
                Console.WriteLine(tablet.ObtenerDescripcion());
            }
            else
            {
                Console.WriteLine(producto.ObtenerDescripcion());
            }
        }
    }

    static void BuscarProducto()
    {
        Console.Write("Ingrese el nombre del producto a buscar: ");
        string nombre = Console.ReadLine();
        var productoEncontrado = productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (productoEncontrado != null)
        {
            if (productoEncontrado is Telefono telefono)
            {
                Console.WriteLine(telefono.ObtenerDescripcion());
            }
            else if (productoEncontrado is Ordenador ordenador)
            {
                Console.WriteLine(ordenador.ObtenerDescripcion());
            }
            else if (productoEncontrado is Tablet tablet)
            {
                Console.WriteLine(tablet.ObtenerDescripcion());
            }
            else
            {
                Console.WriteLine(productoEncontrado.ObtenerDescripcion());
            }
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

