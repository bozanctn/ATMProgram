using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        int amount = 10000, deposit, withdraw;

        int choice, pin = 1234, x = 0;

        Console.WriteLine("Enter your pin");

        pin = int.Parse(Console.ReadLine());

        if (pin == 1234)
        {
            Console.WriteLine("Welcome!!");

            Console.WriteLine("1. Check Balance\n");

            Console.WriteLine("2. Withdraw Cash\n");

            Console.WriteLine("3. Deposit Cash\n");

            Console.WriteLine("4. Quit");

            Console.WriteLine("*******************\n\n");


            Console.WriteLine("Enter your choice");

            choice = int.Parse(Console.ReadLine());


            switch (choice)

            {
                case 1:
                    Console.WriteLine("Your Balance in $ : {0} ", amount);

                    break;

                case 2:
                    Console.WriteLine("Enter the amount to withdraw: ");
                    withdraw = int.Parse(Console.ReadLine());

                    if (withdraw % 100 != 0)
                    {
                        Console.WriteLine("\n Please enter the amount in multipels of 100");

                    }
                    else if (withdraw > amount - 500)
                    {
                        Console.WriteLine("\n Insufficent balance");
                    }
                    else
                    {
                        amount = amount - withdraw;

                        Console.WriteLine("\n\n Please collect cash");

                        Console.WriteLine("\n Your current balance is {0}", amount);
                    }
                    break;
                case 3:

                    Console.WriteLine("|n Enter the ampunt to deposit");

                    deposit = int.Parse(Console.ReadLine());

                    amount = amount + deposit;

                    Console.WriteLine("Your avilable balance is {0}", amount);

                    break;

                 case 4:
                    Console.WriteLine("Thanks have a nice day!!");
                    Environment.Exit(0);

                    break;
           }
           
        }
        else
        {
            Console.WriteLine("your pin is wrong try again");
        }
    }
}
