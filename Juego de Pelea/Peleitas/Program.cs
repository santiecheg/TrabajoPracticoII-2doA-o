using System;

public class Program
{

        static List<Personaje> listaDeHeroes = new List<Personaje>();
        static Personaje heroeUsuario;
        static Personaje heroeRival;
        static void Main()
        {
                CrearHeroes();

                MostrarMenu();




        }

        static void MostrarMenu()
        {
                int opcion = 10;


                while (opcion != 0)
                {
                        Console.Write("\nBienvenido al jueguito de pelea \n");
                        Console.WriteLine("Por favor elija una de las siguientes opciones \n");

                        Console.WriteLine("Opción 1: Pelear");
                        Console.WriteLine("Opcion 2: Ver Héroes disponibles");
                        Console.WriteLine("Opcion 3: Salir\n");

                        opcion = int.Parse(Console.ReadLine());


                        switch (opcion)
                        {

                                case 1:
                                        heroeUsuario= ElegirHeroeUsuario();
                                        heroeUsuario.Vida=100;
                                        heroeRival = ElegirHeroeRival();
                                        heroeRival.Vida=100;
                                        MenuPelea();
                                        break;

                                case 2:
                                        MostrarHeroes();
                                        break;

                                case 3:
                                        opcion = 0;
                                        Console.WriteLine("Gracias por jugar a nuestro jueguito");
                                        break;

                        }


                }

        }

        static void CrearHeroes()
        {


                Pikachu pikachu = new Pikachu();
                Sonic sonic = new Sonic();
                Flash flash = new Flash();

                listaDeHeroes.Add(pikachu);

                listaDeHeroes.Add(sonic);

                listaDeHeroes.Add(flash);

        }

        static void MenuPelea()
        {

                bool peleaOn = true;
                int contadorRondas=0;

                Console.Write("La pelea comenzó \n");

                while (peleaOn)
                {
                        int opcion = 0;

                        
                        Console.WriteLine($"Ronda número {contadorRondas+1}");
                        Console.WriteLine("Por favor elija una de las siguientes opciones para hacer con su héroe \n");
                        
                        Console.WriteLine("1 Atacar");
                        Console.WriteLine("2 Defender");
                        Console.WriteLine("3 Habilidad");
                        Console.WriteLine("4 Cancelar pelea");

                        opcion=int.Parse(Console.ReadLine());

                        switch (opcion)
                        {

                                case 1:
                                        Pegar(heroeUsuario,heroeRival);
                                        break;

                                case 2:
                                        Defender(heroeUsuario);
                                        break;

                                case 3:
                                        heroeUsuario.UsarHabilidad();
                                        break;
                                case 4:
                                        Console.WriteLine("Cancelar pelea");
                                        peleaOn = false;
                                        break;

                        }

                        AccionesDelRival(heroeRival,heroeUsuario);
                        
                        contadorRondas++;

                        if (ComprobarEstadoDeLuchadores(heroeUsuario,heroeRival)==false){
                                peleaOn=false;
                        } else {
                                Console.WriteLine("La pelea continúa!!");
                                Console.WriteLine($"{heroeUsuario.Nombre} te quedan {heroeUsuario.Vida} puntos de vida");
                                 Console.WriteLine($"{heroeRival.Nombre} te quedan {heroeRival.Vida} puntos de vida");
                        }
                }


        }

        static void MostrarHeroes()
        {
                Console.WriteLine("\nTenemos los siguientes héroes");
                foreach (Personaje c in listaDeHeroes)
                {

                        Console.WriteLine($"El héroe {c.Nombre}");

                }
        }

        static void Pegar(Personaje personaje, Personaje rival)
        {
                int dañoParcial = personaje.Ataque - rival.Defensa/2;
                Console.WriteLine($"{personaje.Nombre} está atacando a {rival.Nombre} \n");
                rival.Vida = rival.Vida - dañoParcial;
                Console.WriteLine($"{rival.Nombre} sufre {dañoParcial} daño en sus puntos de vida \n");
        }


        static void Defender(Personaje personaje)
        {
                Console.WriteLine("No es un juego para defenderse");
        }

        static Personaje ElegirHeroeUsuario()
        {

                int opcionUsuario = 0;
                int contador = 1;
                Console.WriteLine("Elija el héroe que quiera usar \n");


                foreach (Personaje c in listaDeHeroes)
                {

                        Console.WriteLine($"El héroe número {contador} se llama {c.Nombre}");
                        contador++;
                }

                // Elegir héroe


                Console.WriteLine("\n Indique el número de su héroe");
                opcionUsuario = int.Parse(Console.ReadLine());

                Personaje heroeElegido = listaDeHeroes[opcionUsuario - 1];

                Console.WriteLine($"Perfecto, has elegido al héroe {heroeElegido.Nombre}");

                return heroeElegido;
        }

        static Personaje ElegirHeroeRival()
        {

                Console.WriteLine("\n Eligiendo un héroe rival (Puede ser el mismo que el tuyo)");
                Random random = new Random();

                int indiceAleatorio = random.Next(0, listaDeHeroes.Count); // Genera un índice aleatorio

                Personaje enemigoElegido = listaDeHeroes[indiceAleatorio];

                Console.WriteLine($"\n¡El enemigo será {enemigoElegido.Nombre}!");

                return enemigoElegido;
        }

        static void AccionesDelRival(Personaje rival, Personaje usuario){
                Console.WriteLine("\n Ahora es el turno de tu rival");
                Console.WriteLine("\n Como esto es un juego básico solo te va a pegar");

                Pegar(rival,usuario);
        }

        static bool ComprobarEstadoDeLuchadores(Personaje usuario, Personaje rival) {
                bool siguePelea = true;

                if (usuario.Vida <=0){
                        siguePelea= false;

                        Console.WriteLine($"{usuario.Nombre} ha quedado en cero puntos de vida");
                        Console.WriteLine($"{usuario.Nombre} ha perdido");                     
                }

                if (rival.Vida <=0){
                        siguePelea= false;

                        Console.WriteLine($"{rival.Nombre} ha quedado en cero puntos de vida");
                        Console.WriteLine($"{rival.Nombre} ha perdido");

                        Console.WriteLine("Felicitaciones has ganado!!");
                        

                }

                return siguePelea;
        }
}