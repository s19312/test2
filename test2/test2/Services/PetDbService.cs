using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.DTOs.Request;
using test2.DTOs.Response;

namespace test2.Services
{
    public interface PetDbService
    {
        public List<GetPetsListResponse> GetPets(int id,int year);
    }
}
