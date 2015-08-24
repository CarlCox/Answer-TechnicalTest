namespace Answer.TechTest.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Entities;

    public class PeopleRepository : IPeopleRepository
    {
        private readonly TechTestContext _context;

        public PeopleRepository(TechTestContext context)
        {
            _context = context;
        }

        public ICollection<Person> GetAll()
        {
            return People().OrderBy(x => x.FirstName).ToList();
        }

        public Person Get(int id)
        {
            return People().FirstOrDefault(p => p.PersonId == id);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        private IQueryable<Person> People()
        {
            return _context.Set<Person>();
        }
    }
}
