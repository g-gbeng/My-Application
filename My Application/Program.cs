
class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Kindly Choose Yor Preferred Program:");
            Console.WriteLine("1. Print Hello and your name.");
            Console.WriteLine("2. Print the sum of two numbers.");
            Console.WriteLine("3. Print the result of dividing two numbers.");
            Console.WriteLine("4. Swap two numbers.");
            Console.WriteLine("5. Print the output of the multiplication of three numbers.");
            Console.WriteLine("6. Perform basic arithmetic operations on two numbers.");
            Console.WriteLine("7. Print the multiplication table of a number.");
            Console.WriteLine("8. Calculate and print the average of four numbers.");
            Console.WriteLine("9. Check if the sum of two integers is 20 or if one of them is 20.");
            Console.WriteLine("10. Convert a string to lowercase.");
            Console.WriteLine("11. Print odd numbers from 1 to 99.");
            Console.WriteLine("12. Compute the sum of the first 500 prime numbers.");
            Console.WriteLine("13. Compute the sum of an integer's digits.");
            Console.WriteLine("14. Reverse the words of a sentence.");
            Console.WriteLine("15. Convert a hexadecimal number to a decimal number.");
            Console.WriteLine("0. Exit.");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintHelloAndName();
                    break;
                case 2:
                    PrintSumOfTwoNumbers();
                    break;
                case 3:
                    PrintDivisionOfTwoNumbers();
                    break;
                case 4:
                    SwapTwoNumbers();
                    break;
                case 5:
                    MultiplyThreeNumbers();
                    break;
                case 6:
                    BasicArithmeticOperations();
                    break;
                case 7:
                    PrintMultiplicationTable();
                    break;
                case 8:
                    CalculateAverageOfFourNumbers();
                    break;
                case 9:
                    CheckSumOfIntegers();
                    break;
                case 10:
                    ConvertStringToLowercase();
                    break;
                case 11:
                    PrintOddNumbers();
                    break;
                case 12:
                    ComputeSumOfPrimes();
                    break;
                case 13:
                    SumOfDigits();
                    break;
                case 14:
                    ReverseSentenceWords();
                    break;
                case 15:
                    HexToDecimal();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            if (!exit)
            {
                Console.WriteLine("Do you want to run another program? Please enter yes or no");
                string
                    anotherOperation = Console.ReadLine();
                if
                    (anotherOperation.ToLower() != "yes")
                {
                    exit = true;
                }
            }
                
        }
    }

    static void PrintHelloAndName()
    {
        
        Console.Write("Please enter Your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello " +  userName);
       
    }

    static void PrintSumOfTwoNumbers()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of your inputed numbers is: " + (num1 + num2));
    }

    static void PrintDivisionOfTwoNumbers()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        if (num2 != 0)
        {
            Console.WriteLine("Your result is: " + (double)num1 / num2);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    static void SwapTwoNumbers()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After swapping: Your First number is " + num1 + ", and your Second number is " + num2);
    }

    static void MultiplyThreeNumbers()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.WriteLine("The result of the multiplication is: " + (num1 * num2 * num3));
    }

    static void BasicArithmeticOperations()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the inputed numbers is: " + (num1 + num2));
        Console.WriteLine("The difference of the inputed numbers is: " + (num1 - num2));
        Console.WriteLine("The product of the inputed numbers is: " + (num1 * num2));
        if (num2 != 0)
        {
            Console.WriteLine("The quotient of the inputed numbers is: " + (double)num1 / num2);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    static void PrintMultiplicationTable()
    {
        Console.Write("Enter the number: ");
        double num = double.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }

    static void CalculateAverageOfFourNumbers()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        double num4 = double.Parse(Console.ReadLine());
        double average = (num1 + num2 + num3 + num4) / 4.0;
        Console.WriteLine("The average of the inputed numbers is: " + average);
    }

    static void CheckSumOfIntegers()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine((num1 == 20 || num2 == 20 || (num1 + num2 == 20)).ToString());
    }
    static void ConvertStringToLowercase()
    {
        Console.Write("Enter your word ");
        string str = Console.ReadLine();
        Console.WriteLine(str.ToLower());
    }

    static void PrintOddNumbers()
    {
        for (int i = 1; i < 100; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void ComputeSumOfPrimes()
    {
        int count = 0, sum = 0, num = 2;
        while (count < 500)
        {
            if (IsPrime(num))
            {
                sum += num;
                count++;
            }
            num++;
        }
        Console.WriteLine("The sum of the first 500 prime numbers is " + sum);
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void SumOfDigits()
    {
        Console.Write("Enter the number: ");
        double num = double.Parse(Console.ReadLine());
        double sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("The Sum of your inputed digit is " + sum);
    }

    static void ReverseSentenceWords()
    {
        Console.Write("Enter your sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }

    static void HexToDecimal()
    {
        Console.Write("Enter the hexadecimal number: ");
        string hex = Console.ReadLine();
        int dec = Convert.ToInt32(hex, 16);
        Console.WriteLine("The decimal form of the inputed hexadecimal number is: " + dec);
    }
}