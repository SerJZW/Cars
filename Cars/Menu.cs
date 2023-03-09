using System.Runtime.InteropServices;
using System;

namespace Cars
{
    internal class Menu
    {
        public static void AddCar(ref CarClass[] array)
        {
            Console.WriteLine("Введите информацию о машине");
            Console.WriteLine("Марка:");
            string inMark = Console.ReadLine();
            Console.WriteLine("Модель:");
            string inModel = Console.ReadLine();
            Console.WriteLine("Цвет:");
            string inColor = Console.ReadLine();
            Console.WriteLine("Номер:");
            string inNumber = Console.ReadLine();

            CarClass car = new CarClass(inMark, inModel, inColor, inNumber);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = car;
            //return array;
        }
        public static void SearchCar(ref CarClass[] array)
        {
            Console.WriteLine("Введите информацию о машине которую хотите найти:");
            string findcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            foreach (var item in array)
            {
                if (item.Mark == findcar || item.Model == findcar || item.Color == findcar || item.Number == findcar)
                {

                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n Это та машина которую вы искали?\n Y - да, любая другая клавиша - нет");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        found = true;
                        break;
                    }

                    else
                    {
                        flag = true;
                        continue;
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("\n Такой машины не найдено");
            }
            if (flag == true)
            {
                Console.WriteLine("\n Больше машин с таким описанием не найдено");
            }
        }
        public static void PrintInfo(ref CarClass[] array)
        {
            int i = 1;
            foreach (CarClass item in array)
            {
                Console.WriteLine("Машина номер " + i);
                Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n");
                i++;
            }
        }
    }
}
