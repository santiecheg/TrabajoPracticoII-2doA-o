
using System;

public class Sonic : Personaje {
    
    public Sonic() : base ("Sonic","Erizo",100,15,15) {}
    

    public override void UsarHabilidad()
    {
        Console.WriteLine("Sonic saca un anillo de su bolsillo");
        Console.WriteLine("La habilidad de Sonic le sube la defensa 4 puntos");
        this.Defensa=this.Defensa+4;
    }
}