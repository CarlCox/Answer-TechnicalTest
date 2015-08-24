namespace Answer.TechnicalTest.Models
{
    using System.Collections.Generic;
    using System.Linq;

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

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public bool IsPalindrome
        {
            get
            {
                var name = FirstName.ToLower() + LastName.ToLower();
                return name == new string(name.Reverse().ToArray());
            }
        }

        public string ColourText
        {
            get
            {
                return string.Join(",", Colours.Where(c => c.IsSelected).Select(x => x.Name).ToList());
            }
        }

        public ICollection<Colour> Colours { get; set; }
    }
}