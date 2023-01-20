using System;
namespace Uppgift_5_2
{

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hur många heltal vill du skriva in?");
            string x = Console.ReadLine();
            int heltal = Convert.ToInt32(x);
            int[] y = new int[heltal];
            Console.WriteLine("Skrev in " +  heltal  + " Heltal");
            for (int i = 0; i < heltal; i++)
            {


                string a = Console.ReadLine();

                int w = int.Parse(a);

                y[i] = w;



            }

            Console.WriteLine("Här är talerna som du skrev in");

            for (int j = 0; j < heltal; j++)

            {

                Console.Write("Tal " + (j + 1) + ": ");

                Console.WriteLine(y[j]);

            }
        }


    }

}