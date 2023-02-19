using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Flipcoin
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("pplease enter the value for number of flips");
            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double headprcentage;
            double tailprcentage;

            int flipcoin=Convert.ToInt32(Console.ReadLine());

            if(flipcoin>0)
            {
                for(int i=0;i<flipcoin; i++)
                {
                    Random random=new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The Random number generated is " + number);

                    if (number ==0)
                    {
                        tail++;

                    }
                    else
                    {
                        headcount++;
                    }
                }
                Console.WriteLine("The tail count is " + tailcount);
                Console.WriteLine("The head count is " + headcount);

                headpercentage = headcount * 100 / flipcoin;
                TailPercentage = tailcount * 100 / flipcoin;

                Console.WriteLine("HeadPercentage : " + headpercentage + "%");
                Console.WriteLine("Tail percentage : " + TailPercentage + "%");

            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

                
        
        }
        

    }
}
