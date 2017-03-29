
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
    }
}
