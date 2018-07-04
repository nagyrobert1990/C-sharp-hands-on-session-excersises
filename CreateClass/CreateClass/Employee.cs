using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
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
            return base.ToString() + $" Salary: {salary} Profession: {profession} Room: {room}";
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
}
