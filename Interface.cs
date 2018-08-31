using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }

    void Start();
    void Stop();


}
public interface IDrive
{
    void Drive();
    double MaxLandSpeed { get; set; }

}
public interface IWater
{

    void Drive();
    double MaxWaterSpeed { get; set; }
}
public interface IFly
{
    void Fly();

    bool Winged { get; set; }

    double MaxAirSpeed { get; set; }

    int Wheels { get; set; }
}

public class JetSki : IWater, IVehicle
{
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
   

    public void Drive()
    {
        
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        Console.WriteLine("The Jetski zips through the water and destroys everything in its path");
    }

    public void Stop()
    {
        Console.WriteLine("Aww, why'd you turn it off??");
    }
}

public class Motorcycle : IDrive, IVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }

    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;

    public double MaxLandSpeed { get; set; } = 160.4;


    public void Drive()
    {
        
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        Console.WriteLine("Vrooooom");
    }

    public void Stop()
    {
        Console.WriteLine("Awe..party pooper");
    }
}


public class Cessna : IVehicle, IFly
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "Auto";
    public double EngineVolume { get; set; } = 31.1;

    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly()
    {
        
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        Console.WriteLine("Yep the plane is on, don't die");
    }

    public void Stop()
    {
        Console.WriteLine(".......power failure");
    }
}


public class Program
{

    public static void Main()
    {

        // Build a collection of all vehicles that fly
        List<IFly> flyingThings = new List<IFly>();
        flyingThings.Add(new Cessna() { });

        // With a single `foreach`, have each vehicle Fly()
        foreach (Cessna flyThing in flyingThings)
        {
            flyThing.Fly();
        }



        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()
        List<IDrive> landThings = new List<IDrive>();
        landThings.Add(new Motorcycle());
        
        // With a single `foreach`, have each road vehicle Drive()
        foreach (Motorcycle landScooter in landThings)
        {
            landScooter.Drive();
            
        }


        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
        List<IWater> waterThings = new List<IWater>();
        waterThings.Add(new JetSki());
    
        // With a single `foreach`, have each water vehicle Drive()
        foreach (JetSki waterThing in waterThings)
        {
            waterThing.Drive();
        
        }
    }

}