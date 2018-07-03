using System;

namespace CreateClass
{
    public enum Genders { Male, Female };

    public class Person
    {
        public string name;
        public DateTime birthDate;
        public Genders gender;

        public Person(string name, DateTime birthDate, Genders gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"{name}"
                + $" {birthDate.Year}"
                + $" {birthDate.Month}"
                + $" {birthDate.Day}"
                + $" {gender}";
        }
    }

    public class Room
    {
        public int roomNumber;

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{roomNumber}";
        }
    }

    public class Employee : Person
    {
        int salary;
        string profession;
        Room room;

        public Employee(string name, DateTime birthDate, Genders gender, int salary, string profession, Room room)
            : base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
            this.room = room;
        }

        public override string ToString()
        {
            return base.ToString() + $" {salary}" + $" {profession}" + $" {room}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person Jack = new Person("Jack", new DateTime(1989, 12, 11), Genders.Male);
            Room room = new Room(12);
            Person Joe = new Employee("Joe", new DateTime(1977, 09, 01), Genders.Female, 50000, "assistant", room);
            Console.WriteLine(Jack.ToString());
            Console.WriteLine(Joe.ToString());
        }
    }
}