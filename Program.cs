using System;


namespace app
{
    class Demo
    {

        public static void Main(string[] args)
        {


            double com = 0;
            double totalcom;
            char ch;
            double fcom = 0;
            do
            {
                Console.WriteLine("Select item ");
                Console.WriteLine("1] CPU");
                Console.WriteLine("2] Monitor");
                int item = Convert.ToInt32(Console.ReadLine());

                if (item != 1 && item != 2)
                {
                    Console.WriteLine("Invalid Entry");
                    return;
                }


                Console.WriteLine("Enter Cost");
                int cost = Convert.ToInt32(Console.ReadLine());



                if (item == 1)
                {
                    if (cost < 1000 && cost > 0)
                        com = 0;
                    else if (cost < 25000 && cost >= 10000)
                    {
                        com = cost * 8 / 100;
                    }
                    else if (cost >= 25000)
                    {
                        com = cost * 10 / 100 + 2000;
                        int bonus = 2000;
                        Console.WriteLine("Your Additional Bonus is :" + bonus);
                    }


                }
                else
                {
                    if (cost <= 10000)
                    {
                        com = cost * 5 / 100;
                    }

                    else if (cost > 10000)
                    {
                        com = cost * 10 / 100;
                    }


                }

                fcom = fcom + com;
                Console.WriteLine("Do You Want to Continue : y/n");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();

            }
            while (ch == 'y' && ch == 'y');

            Console.WriteLine("Your total Comission is " + fcom);



        }


    }

}
