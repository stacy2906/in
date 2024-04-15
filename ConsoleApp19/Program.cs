using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> arrCars = new List<Cars>(); // создаем List
                                                   // заполняем Библиотеку книг
            arrCars.Add(new Cars() { Ident = 334232, Mark = "Lexsus", MaxSpeed = 200, Price = 9000, Sale = 2 });
            arrCars.Add(new Cars() { Ident = 336732, Mark = "BMV", MaxSpeed = 900, Price = 9800, Sale = 5 });
            arrCars.Add(new Cars() { Ident = 764232, Mark = "Mazda", MaxSpeed = 500, Price = 500, Sale = 7 });
            // сортируем по Названию книги
            arrCars.Sort();
            // показываем результат на экран
            for (int i = 0; i < arrCars.Count; i++)
            {
                Cars pr = arrCars[i];
                Console.WriteLine($"идентификатор: {pr.Ident}, марка: {pr.Mark}, максимальная скорость: {pr.MaxSpeed}, цена: {pr.Price}, скидкa:{pr.Sale} %");
            }
            Console.Read();
        }
    }
  }

