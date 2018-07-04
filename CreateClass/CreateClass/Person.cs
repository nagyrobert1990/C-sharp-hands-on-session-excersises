using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
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
            return $"Name: {name} BirthDate: {birthDate.Year} {birthDate.Month} {birthDate.Day} Sex: {gender}";
        }
    }
}
