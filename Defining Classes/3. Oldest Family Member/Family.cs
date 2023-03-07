﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        List<Person> people;
        public Family()
        {
            people = new List<Person>();
        }
        public void AddMember(Person person)
        {
            people.Add(person);
        }
        public Person GetOldestMember()
        {

            return people.MaxBy(x => x.Age);
        }
    }
}
