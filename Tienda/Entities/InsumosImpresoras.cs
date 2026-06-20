using System;
public class InsumosImpresora : Producto
{

    private string color;

    private bool cartucho;

    public string Color {get{return this.color;} set{value = this.color;}}

    public bool Cartucho {get{return this.cartucho;} set{value = this.cartucho;}}

    public InsumosImpresora(string nombre, double precio, string color, bool cartucho) : base(nombre, precio)
    {
        this.color = color;
        this.cartucho = cartucho;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        if (cartucho)
        {
            Console.WriteLine($"Es un cartucho de impresora de color {this.color}");
        }

    }
}