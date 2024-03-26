namespace Project1;

using System;
using System.Collections.Generic;

public abstract class Container
{
    public int DepthContainer;
    public static HashSet<int> IDList = new HashSet<int>();
    public HashSet<Cargo> CargoList;
    public Menu Menu;
    public int ID;
    public string Type;
    public double MassContainer;
    public double MassCapacity;

    public Container(double massContainer, int depthContainer, double massCapacity, string type, int id)
    {
        MassContainer = massContainer;
        DepthContainer = depthContainer;
        MassCapacity = massCapacity;
        Type = type;
        ID = GenerateID();
        CargoList = new HashSet<Cargo>();
    }

    public double GetMassContainer()
    {
        return MassContainer;
    }

    public int GetDepthContainer()
    {
        return DepthContainer;
    }

    public string GetType()
    {
        return Type;
    }

    public double GetMassCapacity()
    {
        return MassCapacity;
    }

    public int GenerateID()
    {
        Random random = new Random();
        int newID;
        do
        {
            newID = random.Next(100, 1000);
        } while (!IDList.Add(newID));
        return newID;
    }

    public int GetID()
    {
        return ID;
    }

    public string DisplayID()
    {
        return "KON-" + GetType() + "-" + GetID();
    }

    public HashSet<Cargo> GetCargoList()
    {
        return CargoList;
    }

    public abstract void PutCargo(Cargo cargo, Container container);

    public Container ChooseContainer()
    {
        Console.Write("Choose a container: ");
        int contID;
        Container chosenContainer = null;
        foreach (Container container in Menu.Containers)
        {
            while (true)
            {
                contID = int.Parse(Console.ReadLine());
                if (!(container.GetID() == contID))
                {
                    Console.WriteLine("Invalid ID");
                    Console.Write("Choose a container: ");
                }
                else
                {
                    chosenContainer = container;
                    break;
                }
            }
        }
        return chosenContainer;
    }

    public abstract bool EmptyContainer(Container container);

    public bool IsContainerFull(Container container)
    {
        return container.GetCargoList().Count == 0;
    }

    public abstract void Warning(Container container);
}
