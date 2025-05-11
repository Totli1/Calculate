using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>();
            string elemntsGap = null;
            Console.Write("Введите пример: ");
            string sample = Console.ReadLine();
            sample += " ";
            foreach (var item in sample)
            {
                if (item ==' ')
                {
                    
                    elements.Add(elemntsGap);
                    elemntsGap = null;
                    continue;
                }
                elemntsGap += item;
                
            }

            for (int i = 0; i < elements.Count-1; i++)
            {
                try
                {
                    switch (elements[i])
                    {

                        case "+":
                            Console.WriteLine($"Решение уровнения {elements[i - 1]}{elements[i]}{elements[i + 1]}: " +
                                $"{Plus(int.Parse(elements[i - 1]), int.Parse(elements[i + 1]))}");
                            break;
                        case "-":
                            Console.WriteLine($"Решение уровнения {elements[i - 1]}{elements[i]}{elements[i + 1]}: " +
                             $"{Minus(int.Parse(elements[i - 1]), int.Parse(elements[i + 1]))}");
                            break;
                        case "*":
                            Console.WriteLine($"Решение уровнения {elements[i - 1]}{elements[i]}{elements[i + 1]}: " +
                              $"{Multi(int.Parse(elements[i - 1]), int.Parse(elements[i + 1]))}");
                            break;
                        case "/":
                            Console.WriteLine($"Решение уровнения {elements[i - 1]}{elements[i]}{elements[i + 1]}: " +
                             $"{Division(int.Parse(elements[i - 1]), int.Parse(elements[i + 1]))}");
                            break;
                        default:
                            break;
                    }
                }
                catch 
                {
                    Console.WriteLine("Ваше уровнение было неправильного формата");
                }
              
            }
            Console.ReadLine();   
        }


        static int Plus(int a,int b) =>  a + b;
        
        static  int Minus(int a, int b) => a - b;

        static double Multi(double a, double b) => Math.Round(a * b, 2);
   
        static  double Division(double a, double b) => Math.Round(a / b, 2);


    }
}
