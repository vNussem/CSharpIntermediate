namespace ClassesAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            // person._birthdate = new DateTime(1982, 1, 1);
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}