namespace Project1;

using System;
using System.Collections.Generic;

public class Menu
{
    public HashSet<Ship> Ships;
    public HashSet<Container> Containers;
    public HashSet<Cargo> Cargos;
    LiquidContainer LiquidContainer;
    GasContainer GasContainer;
    RefContainer RefContainer;
    Cargo Cargo;
    Container Container = null;

    public Menu()
    {
        Ships = new HashSet<Ship>();
        Containers = new HashSet<Container>();
        Cargos = new HashSet<Cargo>();
    }

    public void StartMenu()
    {
        int choice;
        do
        {
            DisplayShips(Ships);
            Console.WriteLine();
            Console.Write("CONTAINERS: ");
            DisplayContainers(Containers);
            Console.Write("CARGOS: ");
            DisplayCargos(Cargos);

            Console.WriteLine("List of actions: \n1. Add a ship \n2. Remove a ship \n3. Add a container" +
                    " \n4. Load cargo into container \n5. Load container onto a ship " +
                    "\n6. Load containers onto a ship" +
                    " \n7. Remove container from the ship \n8. Unload a container" +
                    " \n9. Replace a container with another container " +
                    "\n10. Transfer a container between two ships " +
                    "\n11. Print info about container" +
                    " \n12. Print info about ship and its cargo " +
                    "\n13. Exit");

            Console.Write("Enter your choice: ");
            Console.WriteLine();
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddShip();
                    break;
                case 2:
                    RemoveShip(Ships);
                    break;
                case 3:
                    AddContainer(Containers);
                    DisplayContainers(Containers);
                    break;
                case 4:
                    Container = Container.ChooseContainer();
                    Container.ChooseContainer().PutCargo(Cargo, Container);
                    break;
                case 5:
                    // loadContainerOntoShip();
                    break;
                case 6:
                    // loadListOfContainersOntoShip();
                    break;
                case 7:
                    // removeContainerFromShip();
                    break;
                case 8:
                    Container.ChooseContainer().EmptyContainer(Container);
                    break;
                case 9:
                    // replaceContainer();
                    break;
                case 10:
                    // transferContainerBetweenShips();
                    break;
                case 11:
                    DisplayContainers(Containers);
                    DisplayCargos(Cargos);
                    break;
                case 12:
                    DisplayShips(Ships);
                    break;
                case 13:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 13.");
                    break;
            }
        } while (choice != 4);
    }

    public void DisplayContainers(HashSet<Container> containers)
    {
        if (containers == null || containers.Count == 0)
        {
            Console.WriteLine("None.");
        }
        else
        {
            foreach (Container container in containers)
            {
                Console.WriteLine(container.DisplayID());
            }
        }
    }

    public void DisplayShips(HashSet<Ship> ships)
    {
        foreach (Ship ship in ships)
        {
            Console.WriteLine(ship.DisplayShipDetails());
        }
    }

    public void DisplayCargos(HashSet<Cargo> cargos)
    {
        foreach (Cargo cargo in cargos)
        {
            Console.WriteLine(cargo.DisplayCargo());
        }
        Console.WriteLine();
    }

    public void AddShip()
    {
        Console.WriteLine("Enter ship name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter max speed(km/h): ");
        double maxSpeed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter max number of containers: ");
        int maxnContainers = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter max mass capacity(kg): ");
        double maxMassCapacity = Convert.ToDouble(Console.ReadLine());

        Ship newShip = new Ship(name, maxSpeed, maxnContainers, maxMassCapacity);
        Ships.Add(newShip);

        Console.WriteLine("\n \n");
        StartMenu();
    }

    public void RemoveShip(HashSet<Ship> ships)
    {
        Console.WriteLine("Removing a ship \nEnter the name of the ship: ");
        string shipname = Console.ReadLine();

        Ship shipToRemove = null;
        foreach (Ship ship in ships)
        {
            if (shipname.Equals(ship.GetName()))
            {
                shipToRemove = ship;
                break;
            }
        }

        if (shipToRemove != null)
        {
            ships.Remove(shipToRemove);
        }
    }

    public void AddContainer(HashSet<Container> containers)
    {
        if (containers == null)
        {
            Console.WriteLine();
        }
        Console.WriteLine("Adding a new container:");
        Console.Write("Enter mass of container(kg): ");
        double massContainer = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter depth of container(cm): ");
        int depthContainer = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter mass capacity of container(kg): ");
        double massCapacity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter type of container (G/L/Ref): ");
        string type = Console.ReadLine();

        Container container;
        if (type.Equals("G", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("Enter pressure(pa): ");
            int pressure = Convert.ToInt32(Console.ReadLine());
            container = new GasContainer(massContainer, depthContainer, massCapacity, type, pressure, 0);
        }
        else if (type.Equals("L", StringComparison.OrdinalIgnoreCase))
        {
            container = new LiquidContainer(massContainer, depthContainer, massCapacity, type, 0);
        }
        else if (type.Equals("Ref", StringComparison.OrdinalIgnoreCase))
        {
            container = new RefContainer(massContainer, depthContainer, massCapacity, type, 0);
        }
        else
        {
            Console.WriteLine("Invalid container type.");
            return;
        }

        if (containers == null)
        {
            Console.WriteLine("None. \n");
        }
        else
        {
            containers.Add(container);
        }
        Console.WriteLine("\n \n");
        StartMenu();
    }
}
