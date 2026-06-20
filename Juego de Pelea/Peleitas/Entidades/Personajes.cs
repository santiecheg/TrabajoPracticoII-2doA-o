using System;


public abstract class Personaje {

    private int vida, ataque, defensa;
    private string nombre;

    private string habilidadEspecial;


    public int Vida {get {return this.vida;} set {this.vida=value;}}
    public int Ataque {get {return this.ataque;} set {this.ataque=value;}}
    public int Defensa {get {return this.defensa;} set {this.defensa=value;}}

    public string Nombre {get {return this.nombre;} set {this.nombre=value;}}

    public string HabilidadEspecial {get {return this.habilidadEspecial;} set {this.habilidadEspecial=value;}}


    public Personaje (string nombre, string habilidadEspecial, int vida, int ataque, int defensa)
    {
        this.nombre=nombre;
        this.ataque=ataque;
        this.vida=vida;
        this.defensa=defensa;
        this.habilidadEspecial=habilidadEspecial;
    }



    public virtual void UsarHabilidad(){
        Console.WriteLine($"Usando habilidad especial de {Nombre}");
    }



}