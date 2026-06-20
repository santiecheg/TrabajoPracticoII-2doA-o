using System;
class Program
{
    static List<Empleado> listaEmpleados = new List<Empleado>();

    static void Main()
    {
        int opcion;
        
        do
        {
            Console.WriteLine("\n Gestor de empleados");
            Console.WriteLine("1. Agregar Administrativo");
            Console.WriteLine("2. Agregar Desarrollador");
            Console.WriteLine("3. Agregar Tecnico");
            Console.WriteLine("4. Mostrar Empleados");
            Console.WriteLine("5. Calcular Salarios");
            Console.WriteLine("6. Mostrar Tareas de un Empleado");
            Console.WriteLine("7. Generar Reporte General");
            Console.WriteLine("0. Salir");

            Console.Write("\nElija la opción para operar: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAdministrativo();
                    break;

                case 2:
                    AgregarDesarrollador();
                    break;

                case 3:
                    AgregarTecnico();
                    break;

                case 4:
                    MostrarEmpleados();
                    break;

                case 5:
                    CalcularSalarios();
                    break;

                case 6:
                    MostrarTareas();
                    break;

                case 7:
                    GenerarReporte();
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

    static public bool PreguntarHorasExtras()
    {
        bool variable = false;
        int opcion = 0;
        Console.WriteLine("¿Este empleado hizo horas extras?");
        Console.WriteLine("Ingrese el número 1 para confirmar, cualquier otro número para denegar");
        opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            Console.WriteLine("Se registrarán horas extras");
            variable = true;
            return variable;
        }
        else
        {
            Console.WriteLine("No se registrarán horas extras");
            return variable;
        }
    }

    static public void AgregarAdministrativo()
    {
        Console.Clear();
        Console.WriteLine("Agregando empleado de administración");

        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese salario base: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Administrativo administrativo1 = new Administrativo(nombre, salarioBase);
        
        if (PreguntarHorasExtras())
        {
            Console.Write("Ingrese cantidad de horas extras: ");
            int horasExtras = int.Parse(Console.ReadLine());
            administrativo1.AgregarHorasExtras(horasExtras);
        }

        listaEmpleados.Add(administrativo1);
        Console.WriteLine("Empleado administrativo agregado correctamente");
    }

    static public void AgregarDesarrollador()
    {
        Console.Clear();
        Console.WriteLine("Agregando Desarrollador..");

        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese salario base: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Ingrese cantidad de proyectos completados: ");
        int proyectos = int.Parse(Console.ReadLine());

        Desarrollador dev1 = new Desarrollador(nombre, salarioBase, proyectos);
        
        if (PreguntarHorasExtras())
        {
            Console.Write("Ingrese cantidad de horas extras: ");
            int horasExtras = int.Parse(Console.ReadLine());
            dev1.AgregarHorasExtras(horasExtras);
        }

        listaEmpleados.Add(dev1);
        Console.WriteLine("Desarrollador agregado correctamente");
    }

    static public void AgregarTecnico()
    {
        Console.Clear();
        Console.WriteLine("Agregando Técnico..");

        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese salario base: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Ingrese especialidad: ");
        string especialidad = Console.ReadLine();

        Tecnico tecnico1 = new Tecnico(nombre, salarioBase, especialidad);
        
        if (PreguntarHorasExtras())
        {
            Console.Write("Ingrese cantidad de horas extras: ");
            int horasExtras = int.Parse(Console.ReadLine());
            tecnico1.AgregarHorasExtras(horasExtras);
        }

        listaEmpleados.Add(tecnico1);
        Console.WriteLine("Técnico agregado correctamente");
    }

    static void MostrarEmpleados()
    {
        Console.Clear();
        if (listaEmpleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
        }
        else
        {
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                Console.WriteLine("\n * Empleado número " + (i + 1));
                listaEmpleados[i].MostrarInformacion();                
            }
        }
    }

    static void CalcularSalarios()
    {
        Console.Clear();
        if (listaEmpleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados");
            Console.WriteLine("Por ende tampoco hay salarios para calcular/mostrar");
            Console.WriteLine("Registre empleados para poder calcular");
        }
        else
        {
            Console.WriteLine("\n Calculando salarios \n");
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                Console.WriteLine($"Empleado {i + 1}:");
                double salarioFinal = listaEmpleados[i].CalcularSalario();
                Console.WriteLine($"Salario final: ${salarioFinal}\n");
            }
        }
    }

    static void MostrarTareas()
    {
        Console.Clear();
        if (listaEmpleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            Console.WriteLine("Registre empleados para poder mostrar sus tareas");
        }
        else
        {
            Console.Write("Ingrese el número del empleado: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= listaEmpleados.Count)
            {
                Console.WriteLine($"\n A continuación las tareas del empleado: {listaEmpleados[opcion - 1].Nombre}");
                listaEmpleados[opcion - 1].MostrarTareas();
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }

    static void GenerarReporte()
    {
        Console.Clear();
        if (listaEmpleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            Console.WriteLine("Registre por lo menos 1 empleado para poder generar el reporte");
        }
        else
        {
            Console.WriteLine("\n Iiniciando reporte \n");
            double salariosTotalesAPagar = 0;
            
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                Console.WriteLine($"Empleado {i + 1}");
                listaEmpleados[i].MostrarInformacion();
                double salario = listaEmpleados[i].CalcularSalario();
                salariosTotalesAPagar += salario;
                Console.WriteLine($"Salario: ${salario}");
                Console.WriteLine();
            }
            
            Console.WriteLine($"Cantidad total de empleados: {listaEmpleados.Count}");
            Console.WriteLine($" El total de todos los salarios a pagar: ${salariosTotalesAPagar}");
        }
    }
}
