namespace CalProject
{

    public class Project
    {
        static string numinput1 = "";
        static string numinput2 = "";


        public static void Main()
        {
        Start:

            Console.WriteLine("Enter a number and then press Enter:");
            numinput1 = Console.ReadLine();

            double dnumber1 = 0;
            while (!double.TryParse(numinput1, out dnumber1))
            {
                Console.WriteLine("The input you entered is not an inter, Input integer");
                numinput1 = Console.ReadLine();
            }

            Console.WriteLine("Enter a number and then press Enter:");
            numinput2 = Console.ReadLine();

            double dnumber2 = 0;
            while (!double.TryParse(numinput1, out dnumber2))
            {
                Console.WriteLine("The input you entered is not an inter, Input integer");
                numinput1 = Console.ReadLine();
            }

            Console.WriteLine("ENTER AN OPTION");
            Console.WriteLine("+ , Addition");
            Console.WriteLine("- , Subtraction");
            Console.WriteLine("* ,Multiplication");
            Console.WriteLine("/ , Division");
            Console.Write("Enter an option :");

            switch (Console.ReadLine())
            {

                case "+":
                    double total = (dnumber1 + dnumber2);
                    Console.WriteLine("your Addition is {0}: ", total);
                    break;


                case "-":
                    total = (dnumber1 - dnumber2);
                    Console.WriteLine("your Subtraction is {0}: ", total);
                    break;


                case "*":
                    total = (dnumber1 * dnumber2);
                    Console.WriteLine("your Multiplication is {0}: ", total);
                    break;


                case "/":
                    total = (dnumber1 / dnumber2);
                    Console.WriteLine("your Division is {0}: ", total);
                    break;

                default:
                    Console.WriteLine("your input is invalid");
                    break;

            }

        Confirm:
            Console.WriteLine("Would you like to Calculate again -- Yes or No");
            string userdecision = Console.ReadLine();
            switch (userdecision)
            {
                case "yes":
                    goto Start;
                    break;
                case "no":
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("Your input is incorrect");
                    goto Confirm;


            }
        }
    }
}