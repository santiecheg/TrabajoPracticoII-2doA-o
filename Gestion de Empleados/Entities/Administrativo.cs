
// CLASE ADMINISTRATIVO
public class Administrativo : Empleado
{
    public Administrativo(string nombre, double salarioBase) : base(nombre, salarioBase)
    {
    }

    public override void MostrarTareas()
    {
        Console.WriteLine("Tareas de empleado Administrativo:");
        Console.WriteLine("- Gestionar documentos");
        Console.WriteLine("- Atender llamadas");
        Console.WriteLine("- Organizar reuniones");
        Console.WriteLine("- Manejar presupuestos");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Departamento: Administración");
    }
}
