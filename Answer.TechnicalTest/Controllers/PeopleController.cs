namespace Answer.TechnicalTest.Controllers
{
    using System.Net;
    using System.Web.Http;

    using TechTest.Data.Entities;
    using TechTest.Data.Repositories;

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
            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        public IHttpActionResult Put(Person model)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
