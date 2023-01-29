using AutoMapper;
using SampleProj.DataAccessContract;
using SampleProj.DataAccessContract.Common;
using SampleProj.Models.Common;
using SampleProj.Models.DomainModels;
using SampleProj.Models.Dtos;
using SampleProj.Models.Vms;
using SampleProj.ServicesContract;

namespace SampleProj.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPersonRepository _personRepository;

        public PersonService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _personRepository = unitOfWork.PersonRepository;
        }

        public async Task<Response> CreatePerson(PersonDto dto)
        {
            var person = _mapper.Map<Person>(dto);
            _personRepository.Create(person);
            await _unitOfWork.SaveChanges();
            return new Response();
        }

        public async Task<ListResponse<PersonVm>> GetAll()
        {
            var list = await _personRepository.Get();
            var result = _mapper.Map<List<PersonVm>>(list);
            return new ListResponse<PersonVm>(result);
        }
    }
}
