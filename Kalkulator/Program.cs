namespace Kalkulator
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Usable operators are: Sum (+), Substraction (-), Multiplication (*),Division (/),Modulo (%), Power (^), Root (#)");
            Console.WriteLine("How to:\n Firstly write the first number. \n Next, write the operator. \n Lastly write the second number.\n In case of power and Root the second number is the their level and it will be converted to an absolute number.\n After that the result will of the calculation will appear");
            double a, b, result = 0, modulo = 0;
            string oper;
            string Continue = "No";
            /* Infinite loop to not restart every time */
            while (true)
            {
                /* Carrying on the number from the previous calculation if needed */
                if (Continue == "YES")
                {
                    a = result;
                }
                else
                {
                    Console.WriteLine("First Number:");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Operator:");
                oper = Console.ReadLine();
                Console.WriteLine("Second number:");
                b = Convert.ToDouble(Console.ReadLine());
                /* switch checks for operator and does the calculation */
                switch (oper)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        if (a == 0)
                        {
                            result = 0;
                        }
                        if (b == 0)
                        {
                            result = 0;
                        }
                        break;
                    case "/":
                        
                        result = a / b;
                        
                        if (a == 0)
                        {
                            result = 0;
                        }
                        if (b == 0)
                        {
                            result = 0;
                        }
                        break;
                    case "%":
                        result = a % b;
                        if (a == 0)
                        {
                            result = 0;
                        }
                        if (b == 0)
                        {
                            result = 0;
                        }
                        break;
                    case "^":
                        b = Convert.ToInt32(b);
                        result = Math.Pow(a, b);
                        break;
                    case "#":
                        b = Convert.ToInt32(b);
                        result = Math.Pow(a, 1 / b);
                        break;
                    default:
                        Console.WriteLine("Wrong operator, restart.");
                        break;
                }
                /* The result */
                Console.WriteLine("Result: " + result);
                /* Asking if the user wants to continue with the result further */
                Console.WriteLine("If you want to continue with this number write (Yes), if not type in (No) to start with a new input ");
                /* Capitalizing the letters to be sure.*/
                Continue = Console.ReadLine();
                Continue = Continue.ToUpper();
            }
        }
    }
}