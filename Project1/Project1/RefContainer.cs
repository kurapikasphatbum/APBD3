namespace Project1;

public class RefContainer : Container
{
    public RefContainer(double massContainer, int depthContainer, double massCapacity, string type, int ID)
        : base(massContainer, depthContainer, massCapacity, type, ID)
    {
    }

    public override void PutCargo(Cargo cargo, Container container)
    {
        if (cargo.MassCargo > container.MassCapacity)
        {
            throw new OverfillException();
        }
        else if (container.Type.Equals("Ref"))
        {
            container.ChooseContainer().CargoList.Add(cargo.ChooseCargoRef());
        }
        else
        {
            container.ChooseContainer().CargoList.Add(cargo.ChooseCargoF());
        }
    }

    public override bool EmptyContainer(Container container)
    {
        container.CargoList.Clear();
        return false;
    }

    public override void Warning(Container container)
    {
        throw new NotImplementedException();
    }
}
