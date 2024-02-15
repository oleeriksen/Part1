using System;
namespace Modul5
{
	public class PersonApp
	{
		public void Run() {
          

            Person peter = new Person();

            peter.name = "Peter";
            peter.address = "byvej 123, 9876 Andeby";
            peter.birthday = new DateTime(1999, 7, 17);

            if (peter.IsTeenager())
            { }

            Person kurt = new Person("kurt", "lærkevej 12, 8000 aarhus C", 172, 69);
            kurt.birthday = DateTime.Now;

            PrintPerson(kurt);

            Person2 egon = new Person2
            {
                Name = "Egon",
                Address = "tremmely 1",
                Birthday = DateTime.Now
            };

        }

        private void PrintPerson(Person p) {
            Console.WriteLine($"{p.name}, {p.address}, Født: {p.birthday}, Højde: {p.height}");
        }
	}
}

