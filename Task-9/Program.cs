using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList LList = new LinkedList();
            int menu = 0;
            while (menu < 10)
            {
                Console.WriteLine("1:Add");
                Console.WriteLine("2:Delete");
                Console.WriteLine("3:Print info");
                Console.WriteLine("4:Allprint");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Tariff tariff;
                        Console.WriteLine("Bezlimith/PominuteTariff");
                        menu = int.Parse(Console.ReadLine());
                        if(menu == 1)
                        {
                            Console.WriteLine("Input info(name, money/Minute)");
                            tariff = new bezlemith(Console.ReadLine(), int.Parse(Console.ReadLine()));
                            LList.Add(tariff);
                        }
                        else
                        {
                            tariff = new MinuteTariff(Console.ReadLine(), int.Parse(Console.ReadLine()));
                            LList.Add(tariff);
                        }
                        break;
                    case 2:
                        Console.WriteLine("input info for delete");
                        if (LList.Remove(Console.ReadLine()))
                        {
                            Console.WriteLine("Успешно");
                        }
                        else Console.WriteLine("не успешно");
                        break;
                    case 3:
                        Console.WriteLine("input info for delete");
                        Console.WriteLine(LList.SearchToPrint(Console.ReadLine()));
                        break;
                    case 4:
                        foreach(var i in LList)
                        {
                            Console.WriteLine(i.Data.PrintInfo() + "\n");
                        }
                        break;
                }
            }
        }
    }
}
