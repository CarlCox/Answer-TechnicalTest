﻿namespace Answer.TechnicalTest.Controllers
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
            var entityPerson = _personRepository.Get(id);
            if (entityPerson == null)
            {
                return NotFound();
            }

            var entityColours = _colorRepository.GetAll();
            var person = new Models.Person
            {
                FirstName = entityPerson.FirstName,
                Id = entityPerson.PersonId,
                IsAuthorised = entityPerson.IsAuthorised,
                IsEnabled = entityPerson.IsEnabled,
                IsValid = entityPerson.IsValid,
                LastName = entityPerson.LastName,
                Colours = entityColours
                      .Select(c => new Models.Colour
                      {
                          Id = c.ColourId,
                          IsEnabled = c.IsEnabled,
                          Name = c.Name,
                          IsSelected = entityPerson.Colours.Any(x => x.ColourId == c.ColourId)
                      }).OrderByDescending(x => x.Id).ToList()
            };

            return Ok(person);
        }

        public IHttpActionResult Put(Models.Person model)
        {
            var person = _personRepository.Get(model.Id);
            if (person == null)
            {
                return NotFound();
            }

            person.IsAuthorised = model.IsAuthorised;
            person.IsEnabled = model.IsEnabled;
            person.Colours.Clear();
            person.Colours = _colorRepository.GetAll().Where(x => model.Colours.Any(y => y.Id == x.ColourId && y.IsSelected)).ToList();
            _personRepository.Save();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
