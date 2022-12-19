using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j ;

            
            Console.WriteLine("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());


            
            Console.WriteLine("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());



            Console.WriteLine("prime numbers betwen {0} and {1} is :", n1, n2);


            if (n1 <= 2)
            {
                n1 = 2;
                if (n2 >= 2)
                {
                    Console.WriteLine ( n1 );
                    n1++;
                }

            }

           
            if (n1 % 2 == 0)
                n1 ++;

        
            for (i = n1; i <= n2; i = i + 2)
            {

                bool flag = true ;

                for (j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }

               
                if (flag == true)
                {
                    if (i == 1)
                        continue;
                    else
                        Console.WriteLine(i);
                }
            }
            Console.ReadKey();

   
        }


    }
        

    
}
