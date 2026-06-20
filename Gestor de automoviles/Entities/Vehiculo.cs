public abstract class Vehiculo{

    private string tipoDeVehiculo;

    private string modelo;

    private double velocidad;

    public string TipoDeVehiculo {get {return this.tipoDeVehiculo;} set{value=this.tipoDeVehiculo;}}
    public string Modelo {get {return this.modelo;} set{value=this.modelo;}}
    public double Velocidad {get {return this.velocidad;} set{value=this.velocidad;}}

    public Vehiculo (string tipoDeVehiculo, string modelo){
        TipoDeVehiculo=this.tipoDeVehiculo;
        Modelo=this.modelo;
    }



    public double CalcularVelocidad(){
        
        Console.WriteLine("Ingrese tiempo en Horas");
        double tiempo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese distancia en Kilométros");
        double distancia = double.Parse(Console.ReadLine());
        double veloParcial = distancia/tiempo;

        if (tiempo <= 0){
            veloParcial=0;
        }

        this.velocidad=veloParcial;
        return veloParcial;
    }

    public abstract void AccionEspecial();

    public virtual void MostrarInformacion(){
        Console.WriteLine($"El siguiente vehiculo es: {tipoDeVehiculo}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Velocidad registrada es: {velocidad} km/h");

    }
}