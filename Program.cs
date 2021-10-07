using System;

namespace GitPracticeMergingBranches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method1(3, 5));
        }

        static int Method1 (int num1, int num2)
        {
            if ( num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        static int Method2 (int num1, int num2)
        {
            
        }
    }
}
