using System;

namespace LabSir1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int z = 0; z < 1000; z++)
                {
                    if (i == z)
                    {
                        Console.WriteLine(i+ "=" +z);
                    }
                    else
                    {
                        int c1 = i / 100;
                        int c2 = i / 10;
                         c2 = c2 % 10;
                        int c3 = i % 10;
                        int c4 = c1 + c2 + c3;
                        int f1 = z / 100;
                        int f2 = z / 10;
                        f2 = f2 % 10;
                        int f3 = z % 10;
                        int f4 = f1 + f2 + f3;
                        if (f4 == c4)
                        {
                            Console.WriteLine(i + "=" + z );
                        }
                    }
                }
            }

        }
    }
}
