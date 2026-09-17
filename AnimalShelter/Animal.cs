using System;

namespace AnimalShelter
{
    class Animal
    {
        private string name;
        private string type;
        private int age;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }

        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age; 
        }

        public Animal(string name, string type, int age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }

        public void printInfo()
        {
            Console.WriteLine("Naam: " + name);
            Console.WriteLine("Soort: " + type);
            Console.WriteLine("Leeftijd: " + age);
            Console.WriteLine("----------------------");
        }
    }
}