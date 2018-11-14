using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Адещенко Кирилл lab_4 3ПКС - 316";

            Console.Write("Введите количество строк массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int m = int.Parse(Console.ReadLine());

            char[][] ch = new char[n][];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                ch[i] = new char[m];
                for (int j = 0; j < m; j++)
                    ch[i][j] = Convert.ToChar(rnd.Next(65, 90));
            }

            Console.Write("\nИсходный массив:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(ch[i][j] + " ");
                Console.Write("\n");
            }

            Console.Write("\nСтолбцы:\n");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(ch[i][j] + " ");
                Console.Write("\n");
            }

            Console.Write("\nСтроки:\n");
            for (int i = 0; i < n; i++)
                Console.WriteLine(string.Join(" ", ch[i]));

            Console.ReadLine();
        }
    }
}
