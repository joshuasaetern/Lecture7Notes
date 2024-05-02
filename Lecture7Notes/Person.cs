using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Notes
{
    internal class Person
    {
        String firstName;
        String lastName;
        List<String> personaList;

        public Person(String firstName, String lastName , List<string> personaList)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personaList = personaList;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<String> PersonaList { get => this.personaList; set => this.personaList = value; }

        public override String ToString()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
