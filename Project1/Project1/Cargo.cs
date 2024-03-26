namespace Project1;
using System;
using System;

public class Cargo
{
    public string Name;
    public string Type;
    public double MassCargo;
    public int HeightCargo;
    public bool IsHazardous;
    public Menu Menu;

    public Cargo(string name, string type, double massCargo, int heightCargo, bool isHazardous)
    {
        Name = name;
        Type = type;
        MassCargo = massCargo;
        HeightCargo = heightCargo;
        IsHazardous = isHazardous;
    }

    public string GetName()
    {
        return Name;
    }

    public double GetMassCargo()
    {
        return MassCargo;
    }

    public int GetHeightCargo()
    {
        return HeightCargo;
    }

    public string GetType()
    {
        return Type;
    }

    public string DisplayCargo()
    {
        return $"{GetName()}({GetType()})";
    }

    public Cargo ChooseCargoL()
    {
        Console.Write("Choose a cargo name to add into your container: ");
        string cargoName;
        Cargo chosenCargo = null;
        foreach (Cargo cargo in Menu.Cargos)
        {
            while (true)
            {
                cargoName = Console.ReadLine();
                if (!(cargo.GetName().Equals(cargoName) && cargo.GetType().Equals("L")))
                {
                    Console.WriteLine("Invalid cargo choice or cargo type is not 'L'. Please choose again.");
                    Console.Write("Choose a cargo name to add into your container: ");
                }
                else
                {
                    chosenCargo = cargo;
                }
            }
        }
        return chosenCargo;
    }

    public Cargo ChooseCargoG()
    {
        Console.Write("Choose a cargo name to add into your container: ");
        string cargoName;
        Cargo chosenCargo = null;
        foreach (Cargo cargo in Menu.Cargos)
        {
            while (true)
            {
                cargoName = Console.ReadLine();
                if (!(cargo.GetName().Equals(cargoName) && cargo.GetType().Equals("G")))
                {
                    Console.WriteLine("Invalid cargo choice or cargo type is not 'G'. Please choose again.");
                    Console.Write("Choose a cargo name to add into your container: ");
                }
                else
                {
                    chosenCargo = cargo;
                }
            }
        }
        return chosenCargo;
    }

    public Cargo ChooseCargoRef()
    {
        Console.Write("Choose a cargo name to add into your container: ");
        string cargoName;
        Cargo chosenCargo = null;
        foreach (Cargo cargo in Menu.Cargos)
        {
            while (true)
            {
                cargoName = Console.ReadLine();
                if (!(cargo.GetName().Equals(cargoName) && cargo.GetType().Equals("Ref")))
                {
                    Console.WriteLine("Invalid cargo choice or cargo type is not 'Ref'. Please choose again.");
                    Console.Write("Choose a cargo name to add into your container: ");
                }
                else
                {
                    chosenCargo = cargo;
                }
            }
        }
        return chosenCargo;
    }

    public Cargo ChooseCargoF()
    {
        Console.Write("Choose a cargo name to add into your container: ");
        string cargoName;
        Cargo chosenCargo = null;
        foreach (Cargo cargo in Menu.Cargos)
        {
            while (true)
            {
                cargoName = Console.ReadLine();
                if (!(cargo.GetName().Equals(cargoName) && cargo.GetType().Equals("F")))
                {
                    Console.WriteLine("Invalid cargo choice or cargo type is not 'F'. Please choose again.");
                    Console.Write("Choose a cargo name to add into your container: ");
                }
                else
                {
                    chosenCargo = cargo;
                }
            }
        }
        return chosenCargo;
    }
}
