namespace Answer.TechTest.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Entities;

    public class ColourRepository : IColourRepository
    {
        private readonly TechTestContext _context;

        public ColourRepository(TechTestContext context)
        {
            _context = context;
        }

        public ICollection<Colour> GetAll()
        {
            return _context.Set<Colour>().ToList();
        }
    }
}
