using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var Logger = new Logger();
            var calc = new Calculate();

            
            try
            {
                Console.Write("Число а:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Число b:");
                int b = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Logger.Event("Вычисление началось");
                Console.WriteLine($"Сумма = {((IAdd)calc).Add(a, b)}");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Logger.Error("Не верный формат значения");
                
            }
            finally
            {
                Logger.Event("Калькуляция завершена");
                Console.ReadKey();
            }

        }
    }
    public interface IAdd
    {
        public int Add(int a, int b);
        
    }
    public class Calculate : IAdd
    {
       // ILogger Logger { get; }
      
        int IAdd.Add(int a, int b)
        {
            return a + b;
        }
    }
    public interface ILogger
    {
        void Event(string massege);
        void Error(string massege);
    }
    
    public class Logger : ILogger
    {
        public void Error(string massege)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(massege);
        }
        public void Event(string massege)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(massege);
        }
    }

}
