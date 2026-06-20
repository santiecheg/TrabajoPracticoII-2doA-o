using System;

public class Program
{

    static List<Producto> listaProductos = new List<Producto>();
    static List<Producto> carritoDeCompras = new List<Producto>();
    static void Main()
    {

        MostrarMenu();

    }

    static public void MostrarMenu()
    {

        int opcion;

        do
        {
            Console.WriteLine("\n Bienvenido a tiendas Gatito:");
            Console.WriteLine("1. Agregar Componente");
            Console.WriteLine("2. Agregar Insumo para Impresora");
            Console.WriteLine("3. Agregar Accesorio");
            Console.WriteLine("4. Mostrar Productos Disponibles");
            Console.WriteLine("5. Realizar Compra");
            Console.WriteLine("6. Ver Carrito");
            Console.WriteLine("7. Finalizar Compra (Pagar)");
            Console.WriteLine("0. Salir");


            Console.Write("Elija una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarComponente();
                    break;

                case 2:
                    AgregarInsumoImpresora();
                    break;

                case 3:
                    AgregarAccesorio();
                    break;

                case 4:
                    MostrarProductos();
                    break;

                case 5:
                    RealizarCompra();
                    break;

                case 6:
                    VerCarrito();
                    break;

                case 7:
                    FinalizarCompra();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }

        } while (opcion != 0);
    }

    static public void AgregarComponente()
    {

        Console.WriteLine("Ingrese el nombre del componente: ");
        string nombreComponente = Console.ReadLine();
        
        Console.WriteLine("Ingrese el precio: ");
        double precio = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Es AMD o Intel? ");
        string amdOintel = Console.ReadLine();
        
        Componentes componente = new Componentes(nombreComponente, precio, amdOintel);
        listaProductos.Add(componente);
        Console.WriteLine($"Componente {nombreComponente} agregado correctamente.");
    

    }

    static public void AgregarInsumoImpresora()
    {
        Console.WriteLine("Agregando insumos de impresora");
        Console.WriteLine("Es un cartucho?");
        Console.WriteLine("Ingrese 'True' en caso de serlo para confirmar");
        bool cartucho = bool.Parse(Console.ReadLine());

        string color = "";
        if (cartucho){
            Console.Write("Ingrese el color: ");
            color = Console.ReadLine();
        } 

        Console.Write("Ingrese el nombre del insumo: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Ingrese el precio: ");
        double precio = double.Parse(Console.ReadLine());

        InsumosImpresora insumo = new InsumosImpresora(nombre, precio, color, cartucho);
        listaProductos.Add(insumo);
        Console.WriteLine($"Insumo {nombre} agregado correctamente.");
    }
    

    static public void AgregarAccesorio()
    {   
        Console.Write("Ingrese el nombre del accesorio: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Ingrese el precio: ");
        double precio = double.Parse(Console.ReadLine());
        
        Console.Write("Ingrese una descripción: ");
        string descripcion = Console.ReadLine();
        
        Accesorios accesorio = new Accesorios(nombre, precio, descripcion);
        listaProductos.Add(accesorio);
        Console.WriteLine($"Accesorio {nombre} agregado correctamente.");

    }
    static public void MostrarProductos()
    {   
        Console.WriteLine("Mostrando productos disponibles");

        Console.WriteLine("Los productos disponibles son:");

        foreach (Producto c in listaProductos){
            int contador =1;
            Console.WriteLine("Producto número:" + contador);
            c.MostrarInfo();
            contador++;
        }

    }
    static public void RealizarCompra()
    {
        Console.WriteLine("Ingrese el número de producto que desea comprar");
        int indiceDeProductoParaBuscar = int.Parse(Console.ReadLine())-1;
        Producto productoElegido = listaProductos[indiceDeProductoParaBuscar];
        carritoDeCompras.Add(productoElegido);
        Console.WriteLine($"Producto '{productoElegido.Nombre}' agregado al carrito.");        
    }

    static public void VerCarrito()
    {
        double totalCarritoParcial =0;
        Console.WriteLine("Mostrando carrito");

        foreach (Producto c in carritoDeCompras){
            int contador=0;
            Console.WriteLine("Producto número: "+contador);
            c.MostrarInfo();
            totalCarritoParcial += c.Precio;

            
        }

        Console.WriteLine($"\n El total final es de: {totalCarritoParcial}");

    }
    static public void FinalizarCompra()
    {
        double totalAPagarParcial=0;
        foreach (Producto c in carritoDeCompras){
            totalAPagarParcial += c.Precio;
        }


        Console.WriteLine("Como desea pagar?");
        Console.WriteLine("QR, Débito o Efectivo Opción 1");
        Console.WriteLine("Tarjeta de crédito 10% de recargo Opción 2");

        int metodoDePago=int.Parse(Console.ReadLine());
        double totalFinal =totalAPagarParcial;
        if (metodoDePago==2){
            totalFinal += totalAPagarParcial*0.1;
        } 


        Console.WriteLine($"El total a pagar es: {totalFinal}");
    }



}