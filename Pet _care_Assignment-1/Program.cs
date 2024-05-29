// See https://aka.ms/new-console-template for more information
namespace PetSimulator
{
    //Main program
    class Program
    {
        static void Main(string[] args)
        {
            //Choosing pet and give name
            Console.Write("Please choose the pet type \n 1. Cat \n 2.Dog \n 3.Rabbit \n");
            Console.Write("User input :");
            string type = Console.ReadLine();
            Console.WriteLine("You have choosen" + type + ".What would you like to name your pet\n");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome," + name + "Let's take a good care of you!!\n");

            //pet care action
            int Hunger = 5;
            int Happiness = 5;
            int Health = 5;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMain Menu: \n 1. Feed" + name + "\n 2.Play with" + name + "\n 3. Let" + name + "rest\n 4. Check" + name + "s status \n 5.Exit");
                Console.Write("\nUser input :");
                string action = Console.ReadLine();

                //User actions for pet
                if (action == "1")
                {
                    Hunger -= 2;
                    Health++;
                    Console.WriteLine("You fed" + name + ".Now" + name + "'s hunger decreased and health slightly increased.");
                }
                else if (action == "2")
                {
                    Happiness += 2;
                    Hunger++;
                    Console.WriteLine("You played with" + name + ".Now" + name + "'s happiness increased but hunger also slightly increased.");
                }
                else if (action == "3")
                {
                    Health += 2;
                    Happiness--;
                    Console.WriteLine("You let" + name + " rest.Now" + name + "'s health improved,however happiness slightly decreased.");
                }
                //Check the status of pet
                else if (action == "4")
                {
                    Console.WriteLine("\nStatus of" + name + ":");
                    Console.WriteLine("- Hunger:" + Hunger);
                    Console.WriteLine("- Happiness:" + Happiness);
                    Console.WriteLine("- Health:" + Health);

                }
                //Exit
                else if (action == "5")
                {
                    exit = true;
                    break;
                }
                //Handle invalid input
                else
                {
                    Console.WriteLine("\nInvalid input.Please enter a valid choice.");
                }
                //Enhance interaction logic
                if (action != "4")
                {
                    if (Hunger >= 8)
                    {
                        Health -= 2;
                        Console.WriteLine(name + " is very hungry!Health is deteriorated and cannot play.\n");
                    }
                    if (Happiness <= 2)
                    {
                        Health -= 2;
                        Console.WriteLine(name + " is very unhappy!Health is deteriorated.\n");
                    }

                }
            }
        }
    }
}

                
                    

                

                


   

        
    


