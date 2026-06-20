using System;

public class Moto:Vehiculo{

    public Moto (string tipoDeVehiculo, string modelo) :base(tipoDeVehiculo,modelo){

    }

    public override void AccionEspecial(){
        Console.WriteLine("La moto hace willy..\n waaa waaa watata ");
    }

}