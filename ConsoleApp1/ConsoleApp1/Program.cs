using System;

namespace LoopsAndDecisions
{
    // A simple application demonstrating how loops works in c#

    class Loops
    {

        //main function
        public static void Main(String [] args)
        {
            int i = 1;
            int j = 1;
            int k = 1;
            int l = 3;

            //while loop will execute code until the condition is met
            while( i <= 5)
            {
                Console.WriteLine("The value is: " + i);
                i++;
            }
            Console.WriteLine();

            // do-while loop will perform the do segment at least once before moving on to the while loop
            do
            {
                Console.WriteLine("The value is: " + j);
                j++;
            }
            while (j <= 5);

            Console.WriteLine();

            //for loop will loop through until the middle condition is met
            for(i=0; i<5; i++)
            {
                Console.WriteLine("The value is: " + k);
                k++;
            }
            Console.WriteLine();

            //if statements are used to test if the condition is a certain value. If it matches
            //then enter the statment, otherwise move to the else statement

            if(i == 5)
            {
                Console.WriteLine("The value of i is: " + i);
            }
            else
            {
                Console.WriteLine("The value does not equal 5");
            }
            Console.WriteLine();


            // we are defining the switch statement to the value of l
            // pass through each case statement until the correct value matches l
            // break form the swith statment once found
            switch (l)
            {
                case 1: Console.WriteLine("The value of l is 1");
                    break;
                case 2: Console.WriteLine("The value of l is 2");
                    break;
                case 3: Console.WriteLine("The value of l is 3");
                    break;
                default: Console.WriteLine("The value of l is unknown");
                    break;
            }


            Console.Read();
          
        }
    }
}

/*************************************************************************************
Output:
The value is: 1
The value is: 2
The value is: 3
The value is: 4
The value is: 5

The value is: 1
The value is: 2
The value is: 3
The value is: 4
The value is: 5

The value is: 1
The value is: 2
The value is: 3
The value is: 4
The value is: 5

The value of i is: 5

The value of l is 3
*************************************************************************************/
