#nullable enable

namespace ClassesProject
{
    public class Person
    {
        public string? Name;

        public void Introduce(string to)
        {
            if (Name == null)
                throw new InvalidOperationException("Name is not set.");

            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var person = new Person();
            // person.Name = "Vlad";

            // var person = Person.Parse("Vlad");

            // person.Introduce("Mosh");

            // var customer = new Customer(1, "Jhon");
            // customer.Id = 1;
            // customer.Name = "Jhon";
            // customer.Orders.Add(new Order());

            var customer = new Customer() { Id = 1, Name = "Jhon" };

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}