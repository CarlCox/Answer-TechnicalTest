namespace Answer.TechTest.Data.Entities
{
    using System.Collections.Generic;

    using Models;

    public partial class Person
    {
        public Person()
        {
            Colours = new List<Colour>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthorised { get; set; }
        public bool IsValid { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Colour> Colours { get; set; }
    }
}
