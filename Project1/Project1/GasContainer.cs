namespace Project1;

using System;
using System.Collections.Generic;

public class GasContainer : Container, IHazardNotifier
{
    public int Pressure { get; set; }

    public GasContainer(double massContainer, int depthContainer, double massCapacity, string type, int pressure, int ID)
        : base(massContainer, depthContainer, massCapacity, type, ID)
    {
        Pressure = pressure;
    }

    public int GetPressure()
    {
        return Pressure;
    }

    public override void PutCargo(Cargo cargo, Container container)
    {
        if (EmptyContainer(container))
        {
            double tmp = container.GetMassCapacity() * 0.95;
            if (cargo.GetMassCargo() > tmp)
            {
                throw new OverfillException();
            }
        }
        else
        {
            container.ChooseContainer().GetCargoList().Add(cargo.ChooseCargoG());
        }
    }

    public override bool EmptyContainer(Container container)
    {
        container.GetCargoList().Clear();
        return false;
    }

    public override void Warning(Container container)
    {
        Console.WriteLine("WARNING FOR " + container.DisplayID() + " explosive gas combo!");
    }

    public void Notifier()
    {
        Console.WriteLine("ERROR: DANGEROUS MOVE!");
    }
}
