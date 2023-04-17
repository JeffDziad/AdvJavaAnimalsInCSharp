using AdvJavaAnimalsInCSharp.entity;
using AdvJavaAnimalsInCSharp.interfaces;

namespace AdvJavaAnimalsInCSharp.io
{
    public class UserInput
    {
        private List<string> animals = new List<string>()
        {
            "Cat", "Dog", "Teacher"
        };
        public List<ITalkable> GetAnimalsList()
        {
            List<ITalkable> newAnimals = new List<ITalkable>();
            bool finished = false;
            while(!finished)
            {
                int choice = -1;
                bool validChoice = false;
                Console.WriteLine("Choose a number to create an animal...");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine($"{i}: {animals[i]}");
                }
                while (!validChoice)
                {      
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        validChoice = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please choose a valid number!");
                        validChoice = false;
                        break;
                    }
                }
                switch(choice)
                {
                    case 0:
                        newAnimals.Add(CreateCat());
                        break;
                    case 1:
                        newAnimals.Add(CreateDog());
                        break;
                    case 2:
                        newAnimals.Add(CreateTeacher());
                        break;  
                }
                string cont = "Y";
                Console.Write("Add More? (Y/n): ");
                cont = Console.ReadLine();
                if(cont.ToUpper().Equals("N"))
                {
                    finished = true;
                }
            }
            return newAnimals;
        }

        private Cat CreateCat()
        {
            string name = PromptForString("Enter a name: ", "name");
            int mousesKilled = PromptForInt("Enter how many mice it's killed: ", "Mice Killed");
            return new Cat(mousesKilled, name);
        }

        private Dog CreateDog()
        {
            bool friendlynessFound = false;
            bool isFriendly = false;
            while(!friendlynessFound)
            {
                string isFriendlyStr = PromptForString("Is the dog friendly? (Y/n): ", "Dog Friendlyness");
                if (bool.TryParse(isFriendlyStr, out isFriendly))
                {
                    Console.WriteLine("Please only answer with 'y' or 'n'!");
                }
                else friendlynessFound = true;
            }
            string name = PromptForString("Enter a name: ", "Name");
            return new Dog(isFriendly, name);
        }

        private Teacher CreateTeacher()
        {
            int age = PromptForInt("Enter an age: ", "Age");
            string name = PromptForString("Enter a name: ", "Name");
            return new Teacher(age, name);
        }

        private string PromptForString(string message, string subject)
        {
            bool valid = false;
            string input = "";
            while (!valid)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"Please enter a valid {subject}!");
                } else
                {
                    valid = true;
                }
            }
            return input;
        }

        private int PromptForInt(string message, string subject)
        {
            bool valid = false;
            int input = -1;
            while (!valid)
            {   
                Console.Write(message);
                string str = Console.ReadLine();
                if (!int.TryParse(str, out input))
                {
                    Console.WriteLine($"Please enter a valid {subject}!");
                    break;
                }
                else valid = true;
            }
            return input;
        }

    }
}
