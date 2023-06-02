using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new();
        }
        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }

        public Person GetOldestMember()
        {
            int maxAge = int.MinValue;
            Person oldestPerson = default;
            foreach (var item in members)
            {
                if (item.Age > maxAge)
                {
                    maxAge = item.Age;
                    oldestPerson = item;
                }
            }
            return oldestPerson;
        }


    }
}
