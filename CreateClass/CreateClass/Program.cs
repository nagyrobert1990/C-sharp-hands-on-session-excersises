using System;

namespace CreateClass
{
    public enum Genders { Male, Female };

    #region Person class

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

    #endregion

    #region Room class

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

    #endregion

    #region Employee class

    public class Employee : Person, ICloneable
    {
        public int salary;
        public string profession;
        public Room room;

        public Employee(string name, DateTime birthDate, Genders gender, int salary, string profession)
            : base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + $" {salary}" + $" {profession}" + $" {room}";
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.room = new Room(this.room.roomNumber);
            return newEmployee;
        }

    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, Genders.Male, 1000, "léhűtő");
            Kovacs.room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.room.roomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}