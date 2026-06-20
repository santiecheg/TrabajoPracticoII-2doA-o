using System;
public class Tecnico : Empleado
{
    private string especialidad;

    public string Especialidad { get { return this.especialidad; } set { this.especialidad = value; } }

    public Tecnico(string nombre, double salarioBase, string especialidad) : base(nombre, salarioBase)
    {
        this.especialidad=Especialidad;
    }

    
    public override void MostrarTareas()
    {
        Console.WriteLine("Tareas de Técnico:");
        Console.WriteLine(" Reparar equipos");
        Console.WriteLine(" Mantenimiento");
        Console.WriteLine(" Instalar Softwares");
        Console.WriteLine(" Diagnosticar fallas");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Área de Especialidad: {especialidad}");
        
    }

}