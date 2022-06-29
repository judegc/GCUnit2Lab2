// Loop 1
//string inputA = "";
//do
//{
//    Console.WriteLine("Hello, World!");
//    Console.WriteLine("Would you like to continue? (y/n)?");
//    inputA = Console.ReadLine();
//} while (inputA == "y");
//Console.WriteLine("Goodbye!");

// Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!" ask the user whether they would like to continue.

// Loop 2
//string inputB = "";
//do
//{
//    Console.WriteLine("Please enter a number:");
//    int inputC = int.Parse(Console.ReadLine());
//    for (int i = inputC; i >= 0; i--)
//    {
//        Console.WriteLine(i);
//    }
//    for (int j = 0; j <= inputC; j++)
//    {
//        Console.WriteLine(j);
//    }
//    Console.WriteLine("Would you like to continue (y/n)?");
//    inputB = Console.ReadLine();
//} while (inputB == "y");
//Console.WriteLine("Goodbye!");

/* Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. After that loop finishes, use another loop 
   to output all the numbers from 0 to that number. */

// Loop 3
//Console.WriteLine("Please enter the combination into the keypad:");
//float inputD = float.Parse(Console.ReadLine());
//while (inputD != 13579)
//{
//    Console.WriteLine("That is incorrect, please enter the correct combination into the keypad:");
//    inputD = float.Parse(Console.ReadLine());
//}
//Console.WriteLine("Correct. Access Granted. Welcome!");

/* A door has a keypad entry. The combination to get in is 13579. Write a while loop (not a do while loop) that asks the user to enter a key code.
   The loop will repeat as long as the user enters the wrong code.
   After the user enters the correct code, the program will print out a welcome message. */
/* Hint: There are many ways to accomplish this, but one way is to create a boolean variable that represents if the door is locked or unlocked. 
   Then think about real life, when you approach a door with a keypad, what state is it initially in before you type anything into the keypad? */

// Loop 4
//Console.WriteLine("Please enter the combination into the keypad:");
//float inputD = float.Parse(Console.ReadLine());
//while (inputD != 13579)
//{   for (int k = 1; k <= 5; k++)
//        if (k <= 5)
//        {
//            if (k <= 4)
//            {
//                Console.WriteLine("That is incorrect, please enter the correct combination into the keypad:");
//                inputD = float.Parse(Console.ReadLine());
//                if (inputD == 13579)
//                {
//                    Console.WriteLine("Correct. Access Granted. Welcome!");
//                    Environment.Exit(0);
//                }
//            }
//            if (k >= 4)
//            {
//                Console.WriteLine("Too many attempts. Locking out now.");
//                Environment.Exit(0);
//            }
//        }
//}
//Console.WriteLine("Correct. Access Granted. Welcome!");

/* Continue the previous exercise, but now add a limited number of tries, say 5. After 5 unsuccessful attempts, 
   the loop ends, but instead of printing a welcome message, it prints a message warning that there were too many incorrect attempts. 
   (But if the user entered the correct number, it will still print the welcome message as before.) */

// Loop 5
//Console.WriteLine("Please enter the combination into the keypad:");
//float inputD = float.Parse(Console.ReadLine());
//do
//{
//    if (inputD == 13579)
//    {
//        Console.WriteLine("Correct. Access Granted. Welcome!");
//        Environment.Exit(0);
//    }
//    for (int k = 1; k <= 5; k++)
//        if (k <= 5)
//        {
//            if (k <= 4)
//            {
//                Console.WriteLine("That is incorrect, please enter the correct combination into the keypad:");
//                inputD = float.Parse(Console.ReadLine());
//                if (inputD == 13579)
//                {
//                    Console.WriteLine("Correct. Access Granted. Welcome!");
//                    Environment.Exit(0);
//                }
//            }
//            if (k >= 4)
//            {
//                Console.WriteLine("Too many attempts. Locking out now.");
//                Environment.Exit(0);
//            }
//        }
//} while (inputD != 13579);

/* Start a new console project, and repeat the same exercise as the previous, except this time implement it with a do while loop. */
/* Move the last while loop or the do-while loop into its own function. 
   The function should return a true if access is granted, or a false if the user didn’t enter the correct code within 5 tries. */