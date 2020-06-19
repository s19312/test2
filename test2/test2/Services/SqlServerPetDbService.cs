using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.DTOs.Response;
using test2.Models;

namespace test2.Services
{
    public class SqlServerPetDbService : PetDbService
    {
        List<GetPetsListResponse> result = new List<GetPetsListResponse>();
        private int idCustomer = 0;
        private readonly PetContext _context;
        public SqlServerPetDbService(PetContext context ) {
            _context = context;
        }
        public List<GetPetsListResponse> GetPets(int id, int year )
        {
            if (_context.Volunteer.Where(v => v.IdVolunteer == id).Select(v => v.IdVolunteer).FirstOrDefault() == 0) {
                throw new Exception();
            }
            if (year == null)
            {
                result = _context.Volunteer_Pet.Join(_context.Pet, v => v.IdPet, p => p.IdPet, (v, p) => new { v_pet = v, pet = p })
                    .Where(v => v.v_pet.IdVolunteer == id && v.pet.IdPet == v.v_pet.IdPet).Select(v => new GetPetsListResponse()
                    {
                        IdPet = v.pet.IdPet,
                        IdBreedType = v.pet.IdBreedType,
                        Name = v.pet.Name,
                        IsMale = v.pet.IsMale,
                        DateRegistered = v.pet.DateRegistered,
                        DateAdopted = v.pet.DateAdopted,
                        //ApprocimateDateOfBirth = v.pet.DateAdopted - v.pet.DateRegistered


                    }).OrderByDescending(v => v.DateAdopted).ToList();
            }
            else {
                result = _context.Volunteer_Pet.Join(_context.Pet, v => v.IdPet, p => p.IdPet, (v, p) => new { v_pet = v, pet = p })
                    .Where(v => v.v_pet.IdVolunteer == _context.Volunteer.Where(v => v.StartingDate.Year == year).Select(v => v.IdVolunteer)  && v.pet.IdPet == v.v_pet.IdPet).Select(v => new GetPetsListResponse()
                    {
                        IdPet = v.pet.IdPet,
                        IdBreedType = v.pet.IdBreedType,
                        Name = v.pet.Name,
                        IsMale = v.pet.IsMale,
                        DateRegistered = v.pet.DateRegistered,
                        DateAdopted = v.pet.DateAdopted,
                        //ApprocimateDateOfBirth = v.pet.DateAdopted - v.pet.DateRegistered
                    }).OrderByDescending(v => v.DateAdopted).ToList();
            }
            
            return result;
        }
    }
}
