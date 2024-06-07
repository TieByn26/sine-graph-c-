using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // set kich thuoc do thi
        int width = 80;  
        int height = 20; 

        // tuy chinh cua so console
        if (Console.WindowWidth < width || Console.WindowHeight < height + 1)
        {
            Console.SetWindowSize(Math.Max(Console.WindowWidth, width), Math.Max(Console.WindowHeight, height + 1));
        }

        // Thiet lap pham vi x
        double xMin = -2 * Math.PI; 
        double xMax = 2 * Math.PI;  

        // Thiet lap pham vi y
        double yMin = -1; 
        double yMax = 1;  

        // thiet lap mang chua gia tri y
        double[] yValues = new double[width];

        // tinh y theo ham sin
        for (int i = 0; i < width; i++)
        {
            double x = xMin + (xMax - xMin) * i / (width - 1);
            yValues[i] = Math.Sin(x);
        }

       //chay truc x
        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(i, height / 2);
            Console.Write('-');
        }

        // chay truc y
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(width / 2, i);
            Console.Write('|');
        }

        // dua ham sin len do thi
        for (int i = 0; i < width; i++)
        {
            int y = (int)((yValues[i] - yMin) / (yMax - yMin) * (height - 1));
            int yPos = height - 1 - y;
            if (yPos >= 0 && yPos < height)
            {
                Console.SetCursorPosition(i, yPos);
                Console.Write('*');
            }
        }
        //dua tro ve cuoi console
        //done
        Console.SetCursorPosition(0, height);
    }
}