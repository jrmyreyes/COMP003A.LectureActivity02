/*
 * Author: Ron Jeremy Reyes
 * Course: COMP003A
 * Purpose: Assignment for week 2
 */

namespace COMP003A.LectureActivity02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Hello World!";

            string username;
            Console.Write("What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("Hi " + username);
            Console.WriteLine("");

            int score;
            score = 0;
            score = 4;
            score = 11;
            score = -1564;

            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine("The current value of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("the new value of b: " + b);
            Console.WriteLine("");

            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            Console.WriteLine("");

            short aNumber = 5309;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber: " + aNumber);
            Console.WriteLine("");

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            Console.WriteLine("");

            char aLetter = 'A';
            string message = "Hello World!";

            Console.WriteLine("Concatenation using + : " + aLetter + " " + message);
            Console.WriteLine($"Concatenation using string interpolation: {aLetter} {message} ");
            Console.WriteLine("");

            /* floating-point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");
            Console.WriteLine("");

            /* scientific notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");
            Console.WriteLine("");

            /* bool type */
            bool itWorked = true;
            Console.WriteLine($"value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"New value of itWorked: {itWorked}");
            Console.WriteLine("");

            /* convert */
            string inputAgeString;
            int inputAge;
            int currentYear = 2023;
            Console.WriteLine($"Enter Age in {currentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge}");

            Console.WriteLine("**************************");
            /*
             * math operations
             * addition: + 
             * substraction: - 
             * multiplication: *
             * division: / 
             * modulo: % (remainder)
             */
            int addition = 2 + 3;
            int substraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addtion: {addition}");
            Console.WriteLine($"Value of substraction: {substraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"Value of modulo: {modulo}");
            Console.WriteLine("");

            int arithmetic1;
            arithmetic1 = 9 - 2;
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3;
            Console.WriteLine($"New Value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1;
            Console.WriteLine($"value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2;
            Console.WriteLine($"New Value of arithmetic2: {arithmetic2}");
            Console.WriteLine("");

            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");

            /* compound assignment operator */
            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5;
            compoundAssignmentOperator -= 2;
            compoundAssignmentOperator *= 4;
            compoundAssignmentOperator /= 2;
            compoundAssignmentOperator %= 2;

            int incrementDecrementOperators = 0;
            incrementDecrementOperators++;
            incrementDecrementOperators--;

            Console.WriteLine("**************************************************");
            /* console 2.0 */
            Console.Write("What is your name, human?");
            string userName = Console.ReadLine();

            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey();

            

            Console.Beep(440, 1000);
        }
    }
}