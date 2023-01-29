using Microsoft.AspNetCore.Mvc;
using SampleProj.Models.Common;
using SampleProj.Models.Dtos;
using SampleProj.Models.Vms;
using SampleProj.ServicesContract;

namespace SampleProj.WebApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<ActionResult<ListResponse<PersonVm>>> Index()
        {
            var response = await _personService.GetAll();
            return View(response.Data);
        }

        public async Task<ActionResult<Response>> CreatePerson(PersonDto dto)
        {
            var response = await _personService.CreatePerson(dto);
            return Ok(response);
        }
    }
}
