using homework19.Models;

namespace homework19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                Name = "someone",
                Surname = "someonov",
                Age = 18,
            };
            Person person2 = new Person
            {
                Name = "somebody",
                Surname = "somebodili",
                Age = 20,
            };
            Person person3 = new Person 
            {
                Name = "SomeONe",
                Surname="notsomeonov",
                Age=19
            };
            Person person4 = new Person 
            { 
                Age = 21,
                Name = "test",
                Surname = "testova" };
            List<Person> personList = new();
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            List<Person> namesearch = personList.FindAll(p => p.Name.Equals("Someone"));
            namesearch.ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));

            Console.WriteLine("--------------------");
            
            List<Person> agesearch = personList.FindAll(p => p.Age > 20);
            agesearch.ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));

            Console.WriteLine("--------------------");

            //Console.WriteLine(person1.Surname.Substring(person1.Surname.Length-2));
            List<Person> surnamesearch = personList.FindAll(p => p.Surname.Substring(p.Surname.Length - 2) =="ov" || p.Surname.Substring(p.Surname.Length - 3) == "ova");
            surnamesearch.ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));

        }
    }
}
