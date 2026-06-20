using System;
public class Accesorios : Producto
{

    private string descripcion;

    public string Descripcion { get { return this.descripcion; } set { value = this.descripcion; } }


    public Accesorios(string nombre, double precio, string descripcion) : base(nombre, precio)
    {
        this.descripcion=descripcion;
    }

}