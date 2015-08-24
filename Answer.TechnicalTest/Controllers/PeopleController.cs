namespace Answer.TechnicalTest.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    using TechTest.Data.Entities;
    using TechTest.Data.Repositories;

    using Models;

    public class PeopleController : ApiController
    {
        private readonly IPeopleRepository _personRepository;
        private readonly IColourRepository _colorRepository;

        public PeopleController(IPeopleRepository personRepository, IColourRepository colorRepository)
        {
            _personRepository = personRepository;
            _colorRepository = colorRepository;
        }

        public IHttpActionResult Get()
        {
            return
               Ok(
                   _personRepository.GetAll()
                       .Select(
                           p =>
                           new Models.Person
                           {
                               FirstName = p.FirstName,
                               Id = p.PersonId,
                               IsAuthorised = p.IsAuthorised,
                               IsEnabled = p.IsEnabled,
                               IsValid = p.IsValid,
                               LastName = p.LastName,
                               Colours =
                                   p.Colours.Select(
                                       c =>
                                       new Models.Colour
                                       {
                                           Id = c.ColourId,
                                           IsEnabled = c.IsEnabled,
                                           IsSelected = true,
                                           Name = c.Name
                                       }).ToList()
                           })
                       .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        public IHttpActionResult Put(Models.Person model)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
