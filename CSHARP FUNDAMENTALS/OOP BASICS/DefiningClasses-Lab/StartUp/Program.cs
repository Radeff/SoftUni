using System;
using System.Collections.Generic;

namespace StartUp
{
    public class Program
    {
        public static void Main()
        {
            var bank = new Dictionary<int, BankAccount>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var command = input.Split();
                switch (command[0])
                {
                    case "Create":
                        Create(command, bank);
                        break;
                    case "Deposit":
                        Deposit(command, bank);
                        break;
                    case "Withdraw":
                        Withdraw(command, bank);
                        break;
                    case "Print":
                        Print(command, bank);
                        break;
                }
            }
        }

        private static void Withdraw(string[] command, Dictionary<int, BankAccount> bank)
        {
            var id = int.Parse(command[1]);
            var amount = double.Parse(command[2]);
            if (bank.ContainsKey(id))
            {
                if (bank[id].Balance >= amount)
                {
                    bank[id].Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] command, Dictionary<int, BankAccount> bank)
        {
            var id = int.Parse(command[1]);
            if (bank.ContainsKey(id))
            {
                bank[id].Deposit(double.Parse(command[2])); 
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Print(string[] command, Dictionary<int, BankAccount> bank)
        {
            var id = int.Parse(command[1]);
            if (bank.ContainsKey(id))
            {
                Console.WriteLine($"Account ID{id}, balance {bank[id].Balance:F2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] command, Dictionary<int, BankAccount> bank)
        {
            var id = int.Parse(command[1]);
            if (bank.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                bank.Add(id, acc);
            }
        }
    }
}
