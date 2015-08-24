namespace Answer.TechTest.Data.Repositories
{
    using System.Collections.Generic;

    using Entities;

    public interface IColourRepository
    {
        ICollection<Colour> GetAll();
    }
}
