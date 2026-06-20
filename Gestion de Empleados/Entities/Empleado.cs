
// CLASE PADRE
public abstract class Empleado
{
    private string nombre;
    private double salarioBase;
    private int horasExtras;

    public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
    public double SalarioBase { get { return this.salarioBase; } set { this.salarioBase = value; } }
    public int HorasExtras { get { return this.horasExtras; } set { this.horasExtras = value; } }

    public Empleado(string nombre, double salarioBase)
    {
        this.nombre = nombre;
        this.salarioBase = salarioBase;
        this.horasExtras = 0;
    }

    public void AgregarHorasExtras(int horas)
    {
        this.horasExtras = horas;
    }

    public virtual double CalcularSalario()
    {
        double pagoHorasExtras = horasExtras * 12;
        return salarioBase + pagoHorasExtras;
    }

    public abstract void MostrarTareas();

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Salario Base: ${salarioBase:F2}");
        Console.WriteLine($"Horas Extras: {horasExtras}");
    }
}
