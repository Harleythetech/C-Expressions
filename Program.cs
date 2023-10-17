using System;
using System.Diagnostics;

class Program
{
    static void Main (string[] args)
    {

        //Welcome Message
        Console.WriteLine("Created by: Vincent Harley R. Jovellano");
        Console.WriteLine("Loading..");
        Thread.Sleep(1000);
        Console.Clear();

        string intro = " ________                                                             __                               \r\n/        |                                                           /  |                              \r\n$$$$$$$$/  __    __   ______    ______    ______    _______  _______ $$/   ______   _______    _______ \r\n$$ |__    /  \\  /  | /      \\  /      \\  /      \\  /       |/       |/  | /      \\ /       \\  /       |\r\n$$    |   $$  \\/$$/ /$$$$$$  |/$$$$$$  |/$$$$$$  |/$$$$$$$//$$$$$$$/ $$ |/$$$$$$  |$$$$$$$  |/$$$$$$$/ \r\n$$$$$/     $$  $$<  $$ |  $$ |$$ |  $$/ $$    $$ |$$      \\$$      \\ $$ |$$ |  $$ |$$ |  $$ |$$      \\ \r\n$$ |_____  /$$$$  \\ $$ |__$$ |$$ |      $$$$$$$$/  $$$$$$  |$$$$$$  |$$ |$$ \\__$$ |$$ |  $$ | $$$$$$  |\r\n$$       |/$$/ $$  |$$    $$/ $$ |      $$       |/     $$//     $$/ $$ |$$    $$/ $$ |  $$ |/     $$/ \r\n$$$$$$$$/ $$/   $$/ $$$$$$$/  $$/        $$$$$$$/ $$$$$$$/ $$$$$$$/  $$/  $$$$$$/  $$/   $$/ $$$$$$$/  \r\n                    $$ |                                                                               \r\n                    $$ |                                                                               \r\n                    $$/                                                                                ";
        Console.WriteLine(intro);
        Console.WriteLine("Note: the following has an explanation included.\n");
        Console.WriteLine("1. Primary Expression \n2. Unary Expressions \n3. Arithmetic Expressions \n4. Relational Expressions" +
            "\n5. Logical Expressions \n6. Conditional Expressions \n7. Bitwise Expressions \n8. Assignment Expressions");

        //User Input
        Console.Write("\nSelect a Number: ");
        int test = Convert.ToInt32(Console.ReadLine());

        //Where the magic happens
        switch (test)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("// Primary Expression");
                Console.WriteLine("\nCode: \n{\n int c1 = 10;  //This Represent Numerical Value" +
                " \n string ct1 = \"Hello\";  //While this represent a sequence of characters enclosed in a double qoutation (Output: 10 Hello) \n}");

                int c1 = 10; //This Represent Numerical Value
                string ct1 = " Hello"; //While this represent a sequence of characters enclosed in a double qoutation (Output: 10 Hello)

                Console.WriteLine("\nOutput: " + c1 + ct1);

                break;

            case 2:
                Console.Clear();
                Console.WriteLine("// Unary Expressions");
                Console.WriteLine("\nCode: \n{\nint unv = 100; //Initial Value \nint uev = -unv; //Calls unv and converts a positve value into a negative value (Output: -100)\n}");

                int unv = 100;  //Initial Value
                int uev = -unv; //Calls unv and converts a positve value into a negative value (Output: -100)

                Console.WriteLine("\nOutput: " +uev);
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("// Arithmetic Expressions");
                Console.WriteLine("\nCode: \n{\nint a = 10; // First Value \nint b = 100; // Second Value \nint c = a + b; // Performs Addition by adding A and B and getting the result of 110 \n}");

                int a = 10; // First value
                int b = 100; // Second Value
                int c = a + b; // Performs Addition by adding A and B and getting the result of 110

                Console.WriteLine("\nOutput: "+c);
                break;

            case 4:
                Console.Clear();
                Console.WriteLine("// Relational Expressions");
                Console.WriteLine("\nCode: \n{\nint ra = 10; // First Value \nint rb = 35; // Second Value \nbool isEqual = ra == rb; //Bool (Boolean) checks if ra is equal to rb, since it's not it should return false \n}");

                int ra = 10; // First Value
                int rb = 35; // Second Value
                bool isEqual = ra == rb; //Bool (Boolean) checks if ra is equal to rb, since it's not it should return false
                
                Console.WriteLine("\nOutput: " + isEqual);
                break;

            case 5:
                Console.Clear();
                Console.WriteLine("// Logical Expressions");
                Console.WriteLine("\nCode: \n{ \nbool truth = true; \nbool lie = false; \nbool and = truth && lie;  //Checks if both value are the same, if not the output is false but if it is then it's true. \n}");

                bool truth = true;
                bool lie = false;

                bool and = truth && lie;  //Checks if both value are the same, if not the output is false but if it is then it's true.

                Console.WriteLine("\nOutput: "+and);
                break;

            case 6:
                //Ignore this part
                Console.Clear();
                Console.WriteLine("// Conditional Expressions");

                Console.WriteLine("\nCode: \n{ \nint adult = 18; //initial value \n\nConsole.Write(\"Enter your age: \"); " +
                    "//Ask the user what his/her age is"
                    + "\n\nint user = Convert.ToInt32(Console.ReadLine()); //Reads the value the user give and stores it during runtime" +
                    "\n\nif (user >= adult) //if the user is greater than or equal to adult it should return adult, else it's a minor \n{" +
                    "\n Console.WriteLine(\"\\nOutput: Adult\"); \n} \nelse \n{\nConsole.WriteLine(\"\\nOutput: Minor\"); \n}}");

                //Main Operation
                int adult = 18; //Initial value
                Console.Write("\n\nEnter your age: "); //Ask the user what his/her age is
                int user = Convert.ToInt32(Console.ReadLine()); //Reads the value the user give and stores it during runtime

                if (user >= adult) //if the user is greater than or equal to adult it should return adult, else it's a minor
                {
                    Console.WriteLine("\nOutput: Adult");
                }
                else
                {
                    Console.WriteLine("\nOutput: Minor");
                }

                break;

            case 7:
                Console.Clear();
                Console.WriteLine("// Bitwise Expressions");
                Console.WriteLine("\nCode: \n{\nint ba = 50;  // Initialize value 50. \nint bb = 60;  // Initialize value 60. \n// Perform a bitwise AND operation between 'ba' and 'bb' and store the result in 'bc'.\r\n\nint bc = ba & bb; // Binary: 110010 & 111100 = 110000 (in binary) = 48 (in decimal). \n}");


                int ba = 50;  // Initialize value 50.
                int bb = 60;  // Initialize value 60.

                // Perform a bitwise AND operation between 'ba' and 'bb' and store the result in 'bc'.
                int bc = ba & bb; // Binary: 110010 & 111100 = 110000 (in binary) = 48 (in decimal).

                // Print the value of 'bc' to the console.
                Console.WriteLine("\nOutput: " + bc); // Output: 48
                break;

            case 8:
                Console.Clear();
                Console.WriteLine("// Assignment Expressions");
                Console.WriteLine("\nCode: \n{\nint x = 69; // Initial value 69 \nx += 9; // Calls on x then adds 9 on 69 so the output is 78 \n}");

                int x = 69; // Initial value 69
                x += 9; // Calls on x then adds 9 on 69 so the output is 78

                Console.WriteLine("\nOutput: "+ x);
                break;

            default:
                Console.Clear();
                Console.WriteLine(intro);
                Console.WriteLine("Error: Can't Find the operation you want to perform.");
                Thread.Sleep(1000);
                Process.GetCurrentProcess().Kill();
                break;
        }
    }
}