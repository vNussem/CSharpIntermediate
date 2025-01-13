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

            // var customer = new Customer() { Id = 1, Name = "Jhon" };

            // Console.WriteLine(customer.Id);
            // Console.WriteLine(customer.Name);

            try
            {
                var num = int.Parse("abc");
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            int number;
            if (int.TryParse("123a", out number))
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        public static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }
        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                point.Move(40, 60);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(new Point(100, 200));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(null);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}