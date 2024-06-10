using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("LCM: {0}", FindLCM(num1, num2));
            Console.WriteLine("GCD: {0}", FindGCD(num1, num2));
        }

        static int FindLCM(int n1, int n2)
        {
            int[] array = new int[100];
            int k = 0;

            for (int i = 2; n1 > 1 || n2 > 1;)
            {

                if (n1 % i == 0 && n2 % i == 0)
                {
                    array[k] = i;
                    k++;
                    n1 = n1 / i;
                    n2 = n2 / i;
                }
                else if (n1 % i == 0)
                {
                    array[k] = i;
                    k++;
                    n1 = n1 / i;
                }
                else if (n2 % i == 0)
                {
                    array[k] = i;
                    k++;
                    n2 = n2 / i;
                }
                else
                {
                    i++;
                }
            }

            int LCM = 1;

            for (int i = 0; i < k; i++)
            {
                LCM = LCM * array[i];
            }
            return LCM;

        }


        static int FindGCD(int n1, int n2)
        {
            int[] array = new int[100];
            int k = 0;
            for (int i = 2; n1 > 1 || n2 > 1;)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    n1 = n1 / i;
                    n2 = n2 / i;
                    array[k++] = i;
                }
                else if (n1 % i == 0)
                {
                    n1 = n1 / i;
                }
                else if (n2 % i == 0)
                {
                    n2 = n2 / i;
                }
                else
                {
                    i++;
                }
            }
            int gcd = 1;
            for (int i = 0;i < k; i++)
            {
                gcd = array[i]  *  gcd;
            }
            return gcd;
        }
    }
}
