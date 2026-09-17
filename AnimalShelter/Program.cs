using System; 

namespace AnimalShelter;

public class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Animal("Sky", "Hond", 11));
        animals.Add(new Animal("Oreo", "Kat", 9));
        animals.Add(new Animal("Lily", "Kat", 1));
        animals.Add(new Animal("Bobby", "Konijn", 2));
        animals.Add(new Animal("Luna", "Hond", 3));

        foreach (var Animal in animals)
        {
            if (Animal.getAge() > 3)
            {
                Animal.printInfo();
            }
        }
        
        Queue<Adoptant> waitingList = new Queue<Adoptant>();
        waitingList.Enqueue(new Adoptant("A", "A@gmail.com", "0483529036"));
        waitingList.Enqueue(new Adoptant("B", "B@gmail.com", "0930849870"));
        waitingList.Enqueue(new Adoptant("C", "C@gmail.com", "0467034859"));
        waitingList.Enqueue(new Adoptant("D", "D@gmail.com", "0930961749"));
        
        Adoptant firstAdoptant = waitingList.Dequeue();
        Console.WriteLine(firstAdoptant.getName()+" krijgt een dier om te adopteren.");
        Console.WriteLine("----------------------");
        
        Stack<string> lostAndFound = new Stack<string>();
        lostAndFound.Push("sleutel");
        lostAndFound.Push("speeltje");
        lostAndFound.Push("jas");

        foreach (string item in lostAndFound)
        {
            Console.WriteLine(item);
        }
    }
}