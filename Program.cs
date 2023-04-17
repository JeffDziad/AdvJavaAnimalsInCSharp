using AdvJavaAnimalsInCSharp.entity;
using AdvJavaAnimalsInCSharp.interfaces;
using AdvJavaAnimalsInCSharp.io;

class MainClass
{
    private static FileOutput outFile = new FileOutput("animals.txt");

    private static FileInput inFile = new FileInput("animals.txt");

    static void Main(string[] args) 
    {
        //List<ITalkable> zoo = new List<ITalkable>
        //{
        //    new Dog(true, "Bean"),
        //    new Cat(9, "Charlie"),
        //    new Teacher(44, "Stacy Read")
        //};
        
        UserInput userInput = new UserInput();
        List<ITalkable> zoo = userInput.GetAnimalsList();

        foreach (ITalkable thing in zoo)
        {
            printOut(thing);
        }

        outFile.fileClose();
        inFile.fileRead();
        inFile.fileClose();

        FileInput indata = new FileInput("animals.txt");
        String line;
        while((line = indata.fileReadLine()) != null) 
        {
            Console.WriteLine(line);
        }

        Console.ReadLine();
        
    }
    public static void printOut(ITalkable p)
    {
        Console.WriteLine(p.getName() + " says=" + p.talk());
        outFile.fileWrite(p.getName() + " | " + p.talk());
    }
}

