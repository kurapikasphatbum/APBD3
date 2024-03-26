namespace Project1;

using System;
using System.Collections.Generic;

public class LiquidContainer : Container, IHazardNotifier
{
    Menu menu;

    public LiquidContainer(double massContainer, int depthContainer, double massCapacity, string type, int ID) 
        : base(massContainer, depthContainer, massCapacity, type, ID)
    {
    }

    public void ChooseCargo()
    {
        Console.Write("Choose a cargo name to add into your container: ");
        string cargoName;
        Cargo chosenCargo = null;
        foreach (Cargo cargo in menu.Cargos)
        {
            while (true)
            {
                cargoName = Console.ReadLine();
                if (!(cargo.Name != cargoName && cargo.Type != "L"))
                {
                    Console.WriteLine("Invalid cargo choice or cargo type is not 'L'. Please choose again.");
                    Console.Write("Choose a cargo name to add into your container: ");
                }
                else
                {
                    chosenCargo = cargo;
                    break;
                }
            }
        }
    }

    public override void PutCargo(Cargo cargo, Container container)
    {
        if (cargo.IsHazardous)
        {
            double tmp;
            tmp = (int)(container.MassCapacity / 2);
            Warning(container);
            if (cargo.MassCargo > tmp)
            {
                Notifier();
            }
            else if (!cargo.IsHazardous)
            {
                tmp = (int)(container.MassCapacity * 0.9);
                if (cargo.MassCargo > tmp)
                {
                    Notifier();
                }
            }
            if (cargo.MassCargo > container.MassCapacity)
            {
                throw new OverfillException();
            }
        }
        else
        {
            container.ChooseContainer().CargoList.Add(cargo.ChooseCargoL());
        }
    }

    public override bool EmptyContainer(Container container)
    {
        container.CargoList.Clear();
        return false;
    }

    public override void Warning(Container container)
    {
        Console.WriteLine("You are trying to put a hazardous cargo, " +
                "the maximum capacity of container " + container.DisplayID() +
                " will be halved!");
    }

    public void Notifier()
    {
        Console.WriteLine("DANGEROUS MOVE!");
    }
}
