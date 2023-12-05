using APIDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace APIDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public List<PersonModel> Get()
        {
            List<PersonModel> response = new List<PersonModel>();

            for (int i = 0; i<20; i++)
                response.Add(new PersonModel { Id = i + 1, FullName = "Diego Mendez", Age = 35 });
            
            return response;
        }

        [HttpGet]
        public PersonModel GetById(int Id)
        {
            List<PersonModel> people = new List<PersonModel>();
            for (int i = 0; i < 20; i++)
                people.Add(new PersonModel { Id = i + 1, FullName = "Diego Mendez", Age = 35 });

            var response = people.Where(x => x.Id == Id).FirstOrDefault();

            return response;

        }

        [HttpPost]
        public PersonModel GetByFilter( PersonModel request)
        {
            List<PersonModel> people = new List<PersonModel>();
            for (int i = 0; i < 20; i++)
                people.Add(new PersonModel { Id = i + 1, FullName = "Diego Mendez", Age = 35 });

            PersonModel response = people.Where(x => x.Id == request.Id).FirstOrDefault();

            return response;
        }
    }
}
