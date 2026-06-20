
// CLASE DESARROLLADOR
public class Desarrollador : Empleado
{
    private int proyectosCompletados;

    public int ProyectosCompletados { get { return this.proyectosCompletados; } set { this.proyectosCompletados = value; } }

    public Desarrollador(string nombre, double salarioBase, int proyectosCompletados) : base(nombre, salarioBase)
    {
        this.proyectosCompletados = proyectosCompletados;
    }

    public override double CalcularSalario()
    {
        double salarioBase = base.CalcularSalario();
        double bonoProyectos = proyectosCompletados * 100;
        return salarioBase + bonoProyectos;
    }

    public override void MostrarTareas()
    {
        Console.WriteLine("Tareas de un Desarrollador:");
        Console.WriteLine("- Escribir código");
        Console.WriteLine("- Debuggear aplicaciones");
        Console.WriteLine("- Revisar pull requests");
        Console.WriteLine("- Documentar proyectos");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Proyectos completados: {proyectosCompletados}");
        Console.WriteLine($"Bono por proyectos: ${proyectosCompletados * 100}");
    }
}
