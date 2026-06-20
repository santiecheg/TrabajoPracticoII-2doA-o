using System;
public abstract class Producto{

    private string nombre;
    private double precio;
    
    public string Nombre {get {return this.nombre;} set{value=this.nombre;}}
    public double Precio {get {return this.precio;} set{value=this.precio;}}
    
    public Producto(string nombre, double precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }
    
    public virtual void MostrarInfo(){
        Console.WriteLine($"El nombre del producto es: {this.nombre}");
        Console.WriteLine($"Valor monetario: {this.precio} peso");
    }
}
