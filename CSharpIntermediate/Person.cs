using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;
        private DateTime _birthDate;

        public DateTime BirthDate { get; private set; }

        //Create a constructor to set a BirthDate since it has a private setter
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        //public static Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;

        //    return person;
        //}
    }
}