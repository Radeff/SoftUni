using System;
using System.Collections.Generic;
using _11.InfernoInfinity.Gems;

namespace _11.InfernoInfinity
{
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var weapons = new List<Weapon>();
            var weapon = new Weapon();

            while (inputLine != "END")
            {
                var command = inputLine.Split(';');

                if (command[0] == "Create")
                {
                    var weaponData = command[1].Split();

                    if (weaponData[1] == "Axe")
                    {
                        weapon = new Axe(command[2], weaponData[0]);
                    }
                    else if (weaponData[1] == "Sword")
                    {
                        weapon = new Sword(command[2], weaponData[0]);
                    }
                    else if (weaponData[1] == "Knife")
                    {
                        weapon = new Knife(command[2], weaponData[0]);
                    }

                    weapons.Add(weapon);
                }

                else if (command[0] == "Add")
                {
                    var gem = new Gem();
                    var target = weapons.Find(w => w.Name == command[1]);
                    var index = int.Parse(command[2]);
                    if (index >= 0 && index < weapon.Sockets.Length)
                    {
                        var gemData = command[3].Split();
                        switch (gemData[1])
                        {
                            case "Ruby":
                                gem = new Ruby(gemData[0]);
                                break;

                            case "Emerald":
                                gem = new Emerald(gemData[0]);
                                break;

                            case "Amethyst":
                                gem = new Amethyst(gemData[0]);
                                break;
                        }

                        target.Sockets[index] = gem;
                    }

                }
                else if (command[0] == "Remove")
                {
                    var target = weapons.Find(w => w.Name == command[1]);
                    var index = int.Parse(command[2]);
                    if (index >= 0 && index < weapon.Sockets.Length)
                    {
                        target.Sockets[index] = null;
                    }
                }
                else if (command[0] == "Print")
                {
                    var result = weapons.Find(w => w.Name == command[1]);

                    Console.WriteLine($"{result.Name}: {result.MinDamage}-{result.MaxDamage} Damage, +{result.Strength} Strength, +{result.Agility} Agility, +{result.Vitality} Vitality");

                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
