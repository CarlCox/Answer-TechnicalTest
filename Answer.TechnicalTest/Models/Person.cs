namespace Answer.TechnicalTest.Models
{
    using System.Collections.Generic;

    public class Person
    {
        public Person()
        {
            Colours = new List<Colour>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsValid { get; set; }

        public bool IsAuthorised { get; set; }

        public bool IsEnabled { get; set; }

        public ICollection<Colour> Colours { get; set; }
    }
}