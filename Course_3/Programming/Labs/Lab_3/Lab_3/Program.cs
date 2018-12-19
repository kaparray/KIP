using System;

namespace Lab_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd1 = new Random();
            int[,] array = new int[10,10];
            Console.SetWindowSize(100, 60);

            for (int i = 0; i < 10; i++){
                Console.CursorLeft = 20;

                for (int j = 0; j < 10; j++){
                    array[i,j] = rnd1.Next(10, 99);
                    if (j == i){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i,j] + "  ");
                    }
                    else if(j+i == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j] + "  ");
                    }
                    else{
                        // Ограничивает матрицу выше диагонали,а потом ограничивает часть где i + j < 9 => это верхний теругольник
                        if (j > i && i + j < 9) 
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        // Ограничивает матрицу выше диагонали,а потом ограничивает часть где i + j > 9 => это правый теругольник
                        else if (j > i && i + j > 9)
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        // Ограничивает матрицу ниже диагонали,а потом ограничивает часть где i + j > 9 => это нижний теругольник
                        else if (j < i && i + j > 9)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        // Ограничивает матрицу ниже диагонали,а потом ограничивает часть где i + j > 9 => это левый теругольник
                        else if (j < i && i + j < 9)
                            Console.ForegroundColor = ConsoleColor.Blue;
                        else
                            Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(array[i, j] + "  ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
