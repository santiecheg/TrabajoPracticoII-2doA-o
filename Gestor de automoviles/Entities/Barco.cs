using System;

public class Barco:Vehiculo{

    public int tripulacion;

    private int Tripulacion {get {return this.tripulacion;} set{value=this.tripulacion;}}

    public Barco (string tipoDeVehiculo, string modelo, int tripulacion) :base(tipoDeVehiculo,modelo){
        Tripulacion=this.tripulacion;
    }

    public override void AccionEspecial(){
        Console.WriteLine("El barco iza las velas.. iarrg marinero");
    }

    public void MostrarInformacion(){
        base.MostrarInformacion();
        Console.WriteLine($"Este barco tiene una tripulación total de {this.tripulacion}");
    }


}