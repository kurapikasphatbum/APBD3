using System;
using System.Collections.Generic;
using Project1;

public class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        HashSet<Container> containers = new HashSet<Container>();
        // HashSet<Ship> ships = new HashSet<Ship>();

        Ship ship1 = new Ship("1", 202.0, 4, 1000000.0);
        Cargo bananas = new Cargo("Bananas", "Ref", 50.0, 30, false);
        Cargo chocolate = new Cargo("Chocolate", "Ref", 20.0, 10, false);
        Cargo fish = new Cargo("Fish", "F", 100.0, 40, false);
        Cargo cheese = new Cargo("Cheese", "Ref", 80.0, 25, false);
        Cargo sausages = new Cargo("Sausages", "Ref", 70.0, 35, false);
        Cargo butter = new Cargo("Butter", "Ref", 60.0, 15, false);
        Cargo eggs = new Cargo("Eggs", "Ref", 30.0, 5, false);

        Cargo meat = new Cargo("Meat", "F", 120.0, 45, true);
        Cargo iceCream = new Cargo("Ice Cream", "F", 90.0, 20, true);
        Cargo frozenPizza = new Cargo("Frozen Pizza", "F", 200.0, 30, true);

        Cargo heliumGas = new Cargo("Helium Gas", "G", 10.0, 5, true);
        Cargo carbonDioxideGas = new Cargo("Carbon Dioxide Gas", "G", 15.0, 8, true);
        Cargo nitrogenGas = new Cargo("Nitrogen Gas", "G", 20.0, 10, true);
        Cargo fluorineGas = new Cargo("Fluorine Gas", "G", 12.0, 7, true);

        Cargo milk = new Cargo("Milk", "L", 70.0, 25, false);
        Cargo oliveOil = new Cargo("Olive Oil", "L", 90.0, 15, false);
        Cargo juice = new Cargo("Juice", "L", 60.0, 20, false);

        menu.Ships.Add(ship1);
        menu.Cargos.Add(bananas);
        menu.Cargos.Add(chocolate);
        menu.Cargos.Add(fish);
        menu.Cargos.Add(cheese);
        menu.Cargos.Add(sausages);
        menu.Cargos.Add(butter);
        menu.Cargos.Add(eggs);
        menu.Cargos.Add(meat);
        menu.Cargos.Add(iceCream);
        menu.Cargos.Add(frozenPizza);
        menu.Cargos.Add(heliumGas);
        menu.Cargos.Add(carbonDioxideGas);
        menu.Cargos.Add(nitrogenGas);
        menu.Cargos.Add(fluorineGas);
        menu.Cargos.Add(milk);
        menu.Cargos.Add(oliveOil);
        menu.Cargos.Add(juice);

        string shipArt = "  .  o ..                  \n" +
            "     o . o o.o                \n" +
            "          ...oo               \n" +
            "            __[]__             SHIPS AND CONTAINERS   \n" +
            "         __|_o_o_o\\__         \n" +
            "         \\\"\"\"\"\"\"\"\"\"\"/         \n" +
            "          \\. ..  . /          \n" +
            "     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
        Console.WriteLine(shipArt);

        menu.StartMenu();
    }
}
