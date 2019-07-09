/* C# Tutorial Video from training.
 * 7/9/19
 */

using System;

namespace Video
{
    class Program
    {

        static void getName()
        {
            Console.WriteLine("Enter first name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
        }


        static int getNumberInput()
        {
            var input = Console.ReadLine();
            int x = Int32.Parse(input);
            return x;
        }


        static void addThree()
        {
            Console.WriteLine("Solve for y = x + 3");
            Console.Write("Enter x : ");
            int x = getNumberInput();
            int y = x + 3;
            Console.WriteLine($"{x} + 3 = {y}");
        }


        static void giveaway()
        {
            Console.WriteLine("Choose a Door 1, 2, or 3 : ");
            int door = getNumberInput();

            if (door == 1) {
                openDoor(door);
            } else if (door == 2) {
                openDoor(door);
            } else if (door == 3) {
                openDoor(door);
            } else {
                Console.WriteLine("Invalid Door Option");
                giveaway();
            }           
        }


        static void openDoor(int door)
        {
            Console.WriteLine($"Welcome to door {door}!");
            string prize = (door == 1) ? "new car" : "poop";
            Console.WriteLine("CONGRATS! You won a " + prize);
        }

        static void temperatureConverter()
        {
            Console.WriteLine("Welcome to my Temperature Converter!");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            addThree();
            getName();
            giveaway();
        }
    }
}
