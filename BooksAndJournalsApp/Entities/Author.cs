using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public Author(int id, string name, int yearofbirth)
        {
            Id = id;
            Name = name;
            YearOfBirth = yearofbirth;
        }

        public override string ToString()
        {
            return Name + ", " + YearOfBirth;
        }
    }
}
