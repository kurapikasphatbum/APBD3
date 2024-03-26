namespace Project1;

using System.Collections.Generic;

public class Ship
{
    public string Name;
    public static HashSet<string> ContainerList;
    public double MaxSpeed;
    public int MaxnContainers;
    public double MaxMassCapacity;

    public Ship(string name, double maxSpeed, int maxnContainers, double maxMassCapacity)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        MaxnContainers = maxnContainers;
        MaxMassCapacity = maxMassCapacity;
        ContainerList = new HashSet<string>();
    }

    public string GetName()
    {
        return Name;
    }

    public double GetMaxSpeed()
    {
        return MaxSpeed;
    }

    public int GetMaxnContainers()
    {
        return MaxnContainers;
    }

    public double GetMaxMassCapacity()
    {
        return MaxMassCapacity;
    }

    public HashSet<string> GetContainerList()
    {
        return ContainerList;
    }

    public string DisplayShipDetails()
    {
        return "SHIP(" + GetName() + ") INFO: " + GetMaxSpeed() + "km/h, " +
               GetMaxnContainers() + " containers(max), " + GetMaxMassCapacity() + "kg capacity(max)";
    }
}
