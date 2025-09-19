namespace DataEncapsulationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "bob";

            person.Age = 55;

            Console.WriteLine($"The name is {person.Name} and age is {person.Age}");

        }
    }
}