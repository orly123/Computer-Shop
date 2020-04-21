using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> ComputerList = new List<Computer>();
            int id;
            int price = 0;
            string name;
            int counter = 0;
            int option1 = 1;
            int option2 = 2;
            int option3 = 3;
            int option4 = 4;
            int option5 = 5;
            int exit = 6;

            ComputerList.Add(new Computer(99, "Lenovo", "i7", "7", 89, 9000, 2));
            ComputerList.Add(new Computer(98, "Asus", "i5", "5", 22, 3000, 13));

            Console.WriteLine(
                "Please input your option -> \n\n" +
                "1->Add new computer \n" +
                "2->Remove computer \n" +
                "3->Print computer list by Company Name \n" +
                "4->Print list of the computers \n" +
                "5->Calculate the total price of the computers \n" +
                "6->Exit");

            int input = int.Parse(Console.ReadLine());

            while (input != exit)
            {
                if (input == option1)
                {
                    ComputerList.Add(new Computer(counter));

                    Console.WriteLine("input company name: ");
                    ComputerList[counter].Company = Console.ReadLine();
                    Console.WriteLine("Enter the processor type: ");
                    ComputerList[counter].Processor = Console.ReadLine();
                    Console.WriteLine("Enter the hard disk type: ");
                    ComputerList[counter].HardType = Console.ReadLine();
                    Console.WriteLine("Enter the  hard disk size: ");
                    ComputerList[counter].HardSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the price: ");
                    ComputerList[counter].Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity: ");
                    ComputerList[counter].Quantity = int.Parse(Console.ReadLine());

                    counter++;
                    Console.WriteLine("A new computer has been added");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (input == option2)
                {
                    if (ComputerList.Count > 0)
                    {
                        for (int i = 0; i < ComputerList.Count; i++) Console.WriteLine(ComputerList[i].ToString());

                        Console.Write("Input the id of the computer you want to remove -> ");
                        id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < ComputerList.Count; i++)
                        {
                            if (ComputerList[i].Id == id) ComputerList.Remove(ComputerList[i]);
                        }

                        if (ComputerList.Count == 0)
                        {
                            Console.WriteLine("There is nothing on the list");
                        }
                        else
                        {
                            Console.WriteLine("\nThe list after the change: ");
                            for (int i = 0; i < ComputerList.Count; i++) Console.WriteLine(ComputerList[i].ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is nothing on the list");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (input == option3)
                {
                    Console.WriteLine("Enter the company name: ");
                    name = Console.ReadLine();
                    for (int i = 0; i < ComputerList.Count; i++)
                    {
                        if (ComputerList[i].Company == name) Console.WriteLine(ComputerList[i].ToString());
                    }
                }
                if (input == option4)
                {
                    if (ComputerList.Count > 0)
                    {
                        for (int i = 0; i < ComputerList.Count; i++) Console.WriteLine(ComputerList[i].ToString());
                    }
                    else Console.WriteLine("There is nothing on the list");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == option5)
                {
                    for (int i = 0; i < ComputerList.Count; i++) price += ComputerList[i].Price;
                    Console.WriteLine("The price is: " + price);
                }
                Console.WriteLine(
                   "Please input your option -> \n\n" +
                   "1->Add new computer \n" +
                   "2->Remove computer \n" +
                   "3->Print computer list by Company Name \n" +
                   "4->Print list of the computers \n" +
                   "5->Calculate the total price of the computers \n" +
                   "6->Exit");

                input = int.Parse(Console.ReadLine());
            }
        }


    }

}
