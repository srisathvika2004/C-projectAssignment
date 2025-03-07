using System;

public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a car.");
}

public class Bike : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a bike.");
}

public class VehicleFactory
{
    public IVehicle GetVehicle(string vehicleType)
    {
        if (vehicleType == "Car")
        {
            return new Car();
        }
        else if (vehicleType == "Bike")
        {
            return new Bike();
        }
        else
        {
            throw new ArgumentException("Invalid vehicle type");
        }
    }
}


