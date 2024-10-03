namespace Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string playerName = "adventurer";
            string userChoice = "NONE";

            //Writing using Write instead of WriteLine
            Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");
            
            //Use User Input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the Jungle " + playerName + "!");

            //Continuing the story
            Console.WriteLine("" +
                "We approach a clearing in the jungle\n" +
                "There seems to a Dragon on your left...\n" +
                "And a Giant to your right.\n");

            //Narrator
            Console.WriteLine("Which beast do you choose?");
            Console.WriteLine("Type 'left' to choose the FireBreather and go left or type 'right' to choose the Savage Behemoth and go right.");
            
            //Grab some user input
            while (userChoice != "left" && userChoice != "right" && userChoice != "up")
            {
                Console.WriteLine("Please enter either 'left', 'right', or our now super    secret answer of 'up'.");
                userChoice = Console.ReadLine();
                Console.WriteLine("\nYou chose: " + userChoice + "\n");
            }

            //Select our path
            if (userChoice == "left")
            {
                //Go to the left
                Console.WriteLine("You go left and find the dragon is actually looking for a rider, you bond and become besties!!");
            }
            else if (userChoice == "right")
            {
                //Go to the right
                Console.WriteLine("You go the right and are immediately felled by the giant's hands, :'( he has an intense fear of small creatures");
            }
            else if (userChoice == "up")
            {
                //Oh no! the user typed in something else.
                Console.WriteLine("You're an imbecile... but you've gained the power of flight, the world is yours!");
            }
            else
            {
                Console.WriteLine("Something went VERY wrong...");
            }

        }
    }
}
