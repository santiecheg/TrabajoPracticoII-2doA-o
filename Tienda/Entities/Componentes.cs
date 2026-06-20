using System;
public class Componentes : Producto
{

    private string amdOintel;

    public string AmdOintel { get { return this.AmdOintel; } set { value = this.AmdOintel; } }


    public Componentes(string nombre, double precio, string amdOintel) : base(nombre, precio)
    {
        this.amdOintel=amdOintel;
    }


    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Este componente es compatible para los modelos {amdOintel}");
    }
}