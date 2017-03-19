
namespace Entities
{
    public class Author
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public Author()
        {}

        public Author(string name, int yearofbirth)
        {
            Name = name;
            YearOfBirth = yearofbirth;
        }
    }
}
