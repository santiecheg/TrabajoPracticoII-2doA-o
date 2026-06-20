
public class Auto:Vehiculo{

    public Auto (string tipoDeVehiculo, string modelo) :base(tipoDeVehiculo,modelo){

    }

    public override void AccionEspecial(){
        
        Console.WriteLine("Activando el modo descapotable \n ulala señor francés.. ");
      
    }

}