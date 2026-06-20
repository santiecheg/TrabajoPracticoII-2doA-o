using System;
class Program
{
   static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

   static void Main()
    {
        
        int opcion;
        
        do
        {
            Console.WriteLine("\n MENU ");
            Console.WriteLine("1. Agregar Auto");
            Console.WriteLine("2. Agregar Moto");
            Console.WriteLine("3. Agregar Barco");
            Console.WriteLine("4. Mostrar Vehiculos");
            Console.WriteLine("5. Realizar Accion Especial");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAuto();
                    break;

                case 2:
                    AgregarMoto();
                    break;

                case 3:
                    AgregarBarco();
                    break;
                case 4:
                    MostrarVehiculos();
                    break;

                case 5:
                    RealizarAccion();
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

    static public bool PreguntaCálculoVelocidad()
    {
        bool variable=false;
        int opcion = 0;
        Console.WriteLine("Desea calcular la velocidad de este vehículo?");
        Console.WriteLine("Ingrese el número 1 para confirmar, cualquier otro número para denegar");
        opcion = int.Parse(Console.ReadLine());
        if (opcion==1){
            Console.WriteLine("Aceptaste la opción para calculo de velocidad");
            variable = true;
            return variable;
        } else {
            Console.WriteLine("Cancelaste la opción para calcular velocidad");
            return variable;
        }
    }


    static public void AgregarAuto(){
         
                    Console.Clear();
                    Console.WriteLine("Agregando Auto..");
                    string tipoDeVehiculo = "Automovil";

                    Console.Write("Ingrese modelo: ");

                    string modelo = Console.ReadLine();


                    Auto auto1 = new Auto(tipoDeVehiculo, modelo);
                    if (PreguntaCálculoVelocidad()){
                        auto1.CalcularVelocidad();
                    }

                    listaVehiculos.Add(auto1);

                    Console.WriteLine("Auto agregado correctamente!!");

    }

    static public void AgregarMoto(){

        Console.Clear();
                    Console.WriteLine("Agregando moto..");
                    string tipoDeVehiculo = "Motocicleta";

                    Console.Write("Ingrese modelo: ");

                    string modelo = Console.ReadLine();


                    Moto moto1 = new Moto(tipoDeVehiculo, modelo);
                    if (PreguntaCálculoVelocidad()){
                        moto1.CalcularVelocidad();
                    }

                    listaVehiculos.Add(moto1);

                    Console.WriteLine("Motocicleta agregada correctamente!!");

    }

    static public void AgregarBarco(){
        Console.Clear();
                    Console.WriteLine("Agregando Barco..");
                    string tipoDeVehiculo = "Embarcación";

                    Console.Write("Ingrese tipo de barco: ");

                    string modelo = Console.ReadLine();

                    Console.WriteLine("Ingrese cantidad de triupalación minima");
                    int tripulacion = int.Parse(Console.ReadLine());

                    Barco barco1 = new Barco(tipoDeVehiculo, modelo,tripulacion);
                    
                    if (PreguntaCálculoVelocidad()){
                        barco1.CalcularVelocidad();
                    }

                    

                    listaVehiculos.Add(barco1);

                    Console.WriteLine("Embarcación agregada correctamente!!");
    }

    static void MostrarVehiculos(){
        Console.Clear();
        if (listaVehiculos.Count == 0)
                    {
                        Console.WriteLine("No hay vehiculos registrados.");
                    }
                    else
                    {
                        for (int i = 0; i < listaVehiculos.Count; i++)
                        {
                            Console.WriteLine("\nVehiculo " + (i + 1));
                            listaVehiculos[i].MostrarInformacion();
                        }
                    }
    }

    static void RealizarAccion(){
        if (listaVehiculos.Count == 0)
                    {
                        Console.WriteLine("No hay vehiculos registrados.");
                    }
                    else
                    {
                        Console.Write("Ingrese el numero del vehiculo: ");
                        int opcion = int.Parse(Console.ReadLine());

                        if (opcion >= 1 && opcion <= listaVehiculos.Count)
                        {
                            listaVehiculos[opcion - 1].AccionEspecial();
                        }
                        else
                        {
                            Console.WriteLine("Numero invalido.");
                        }
                    }
    }

}

