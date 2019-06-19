using System;

namespace LabSir1._5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Позиция по оси X =");
            string x = Console.ReadLine();
            int xf = Convert.ToInt32(x);
            if (xf > 8)
            {
                Console.WriteLine("Позиция по оси X не может быть больше 8");
            }
            else
                if (xf < 1)
            {
                Console.WriteLine("Позиция по оси X не может быть меньше 1");
            };
            Console.WriteLine("Позиция по оси Y =");
            string y = Console.ReadLine();
            int yf = Convert.ToInt32(y);
            if (yf > 8)
            {
                Console.WriteLine("Позиция по оси Y не может быть больше 8");
            }
            else
                if (yf < 1)
            {
                Console.WriteLine("Позиция по оси Y не может быть меньше 1");
            };
            for (int yb=1; yb<9; yb+=1)
            {
                for (int xb = 1; xb < 9; xb += 1)
                {
                    
                    int y1 = yf + 2;
                    int x1 = xf - 1;
                    if (y1 == yb && x1 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };
                    //
                    //Top
                    //
                    int y2 = yf + 2;
                    int x2 = xf + 1;
                    if (y2 == yb && x2 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };

                    int y3 = yf + 1;
                    int x3 = xf + 2;
                    if (y3 == yb && x3 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };
                    //
                    //Rigth
                    //
                    int y4 = yf - 1;
                    int x4 = xf + 2;
                    if (y4 == yb && x4 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };

                    int y5 = yf - 2;
                    int x5 = xf + 1;
                    if (y5 == yb && x5 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };
                    //
                    //Bot
                    //
                    int y6 = yf - 2;
                    int x6 = xf - 1;
                    if (y6 == yb && x6 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };

                    int y7 = yf - 1;
                    int x7 = xf - 2;
                    if (y7 == yb && x7 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };
                    //
                    //Left
                    //
                    int y8 = yf + 1;
                    int x8 = xf - 2;
                    if (y8 == yb && x8 == xb)
                    {
                        Console.WriteLine("Y"+yb + " " + "X" + xb);
                    };
                };
            };
        }
    }
}
