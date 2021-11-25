using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    //Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой клетки в правую нижнюю.
    //Известно что ходить можно только на одну клетку вправо или вниз.

    class Program
    {

        public class GetAllWays
        {
            int N = 3;
            int M = 3;
            int[,] A;

            public GetAllWays(int n, int m)
            {
                if (n > 0) N = n;
                if (m > 0) M = m;
                A = new int[N, M];
            }

            public void Do()
            {
                int i, j;
                for (j = 0; j < M; j++)
                    A[0, j] = 1; // Первая строка заполнена единицами
                for (i = 1; i < N; i++)
                {
                    A[i, 0] = 1;
                    for (j = 1; j < M; j++)
                        A[i, j] = A[i, j - 1] + A[i - 1, j];
                }
            }

            public void PrintResult()
            {
                int i, j;
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                        Console.Write("{0,6}", A[i, j]);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            GetAllWays GetWays = new GetAllWays(5,5);

            GetWays.Do();
            GetWays.PrintResult();

            Console.ReadKey();
        }
    }
}
