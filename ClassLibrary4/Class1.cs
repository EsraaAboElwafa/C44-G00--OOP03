namespace ClassLibrary4
{
    public class Class1
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Student("Ali", "Ahmed", 16, "10th Grade"));
            people.Add(new Student("Sara", "Mohamed", 17, "11th Grade"));
            people.Add(new Teacher("Hana", "Ibrahim", 35, "Mathematics"));
            people.Add(new Admin("Khaled", "Omar", 40, "Coordinator"));

            foreach (var person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}
