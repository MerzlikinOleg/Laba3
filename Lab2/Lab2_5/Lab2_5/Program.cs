﻿class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите N>0: ");
        int N = int.Parse(Console.ReadLine());
        while (N <= 0)
        {
            Console.Write("Введите N>0: ");
            N = int.Parse(Console.ReadLine());
        }
        var a = new List<int>();
        var b = new List<int>();
        var c = new List<int>();
        double sum;
        bool Flag = false;
        for (int x = 0; x <= N; x++)
        {
            for (int y = 0; y <= N; y++)
            {
                for (int z = 0; z <= N; z++)
                {
                    sum = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                    if (sum == N)
                    {
                        Flag = true;
                        a.Add(x);
                        b.Add(y);
                        c.Add(z);
                    }
                }
            }
        }
        if (Flag)
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("N = {0}^3 + {1}^3 + {2}^3", a[i], b[i], c[i]);
            }
        else
        {
            Console.WriteLine("No such combinations!");
        }
    }
}
