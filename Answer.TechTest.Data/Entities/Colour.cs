namespace Answer.TechTest.Data.Entities
{
    using System.Collections.Generic;

    public partial class Colour
    {
        public Colour()
        {
            People = new List<Person>();
        }

        public int ColourId { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
