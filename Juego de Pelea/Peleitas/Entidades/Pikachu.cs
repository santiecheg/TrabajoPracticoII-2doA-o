using System;


public class Pikachu : Personaje {

    // Formula de daño a la vida = ataque - defensa 
   // public Pikachu (string nombre, string habilidadEspecial, int vida, int ataque, int defensa) : base(nombre,habilidadEspecial,vida,ataque,defensa){
        
    public Pikachu () : base ("pikachu", "electrico", 100, 10, 20){
        
    }

    

    public override void UsarHabilidad()
    {
        Console.WriteLine("Pikachu impactrueno");
        Console.WriteLine("La habilidad de pikachu le sube el daño 4 puntos");
        this.Ataque=this.Ataque+4;
    }

}