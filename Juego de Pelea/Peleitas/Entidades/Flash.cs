using System;


public class Flash : Personaje {

    public Flash () : base ("Flash", "Superheroe",100,20,10){

    }

    public override void UsarHabilidad()
    {
        Console.WriteLine("Fium Fium..");
        Console.WriteLine($"La habilidad de {Nombre} le sube la vida 15 puntos");
        this.Vida=this.Vida+15;
    }

}