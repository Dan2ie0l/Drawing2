using System;

namespace ConsoleApp26
{

    public enum StandardShapes
    {
        Rectangle,
        Circle,
        Triangle
    }


    class Program
    {
        static void Main(string[] args)
        {
            Line.Draw(StandardShapes.Circle, '*');
        }
    }

    class Line
    {



        public static void Draw(StandardShapes shape, char symbol, ConsoleColor color = ConsoleColor.White)
        {
            switch (shape)
            {
                case StandardShapes.Rectangle:
                    DrawRectangle(symbol);
                    break;
                case StandardShapes.Circle:

                    break;
                case StandardShapes.Triangle:

                    break;

            }
        }

        private static void DrawRectangle(char symbol)
        {

            uint width;
            uint lenght;

            Console.WriteLine("Input width");
            uint.TryParse(Console.ReadLine(), out width);
            Console.WriteLine("Input lenght");
            uint.TryParse(Console.ReadLine(), out lenght);

            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= lenght; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (Console.CursorLeft == lenght || Console.CursorLeft == 0 || Console.CursorTop == width || Console.CursorTop == 0)
                    {
                        Console.WriteLine(symbol);
                    }

                }

            }
        }

    }
}

