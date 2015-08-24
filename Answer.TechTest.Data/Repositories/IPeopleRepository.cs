namespace Answer.TechTest.Data.Repositories
{
    using System.Collections.Generic;

    using Entities;

    public interface IPeopleRepository
    {
        ICollection<Person> GetAll();
        Person Get(int id);
        int Save();
    }
}
