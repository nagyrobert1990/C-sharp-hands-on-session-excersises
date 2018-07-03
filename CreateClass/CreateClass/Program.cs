using System;

namespace CreateClass
{
    public enum Genders { Male, Female };

    class Person
    {
        public string Name;
        public DateTime BirthDate;
        public Genders Gender;

        public Person(string name, DateTime birthDate, Genders gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
        }

        public override string ToString()
        {
            string Result = "";
            return Result
                + Name + " "
                + BirthDate.Year + ". "
                + BirthDate.Month + ". "
                + BirthDate.Day + ". "
                + Gender;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Jack = new Person("Jack", new DateTime(1989, 12, 11), Genders.Male);
            Console.WriteLine(Jack.ToString());
        }
    }
}