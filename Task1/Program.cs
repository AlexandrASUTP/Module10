using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            try
            {
                Console.Write("Число а:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Число b:");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Сумма = {((IAdd)calc).Add(a, b)}"); ;
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат значения");
            }
            finally
            {
                Console.WriteLine("Калькуляция завершена");
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

        int IAdd.Add(int a, int b)
        {
            return a + b;
        }
    }
}
