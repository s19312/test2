using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.DTOs.Response
{
    public class GetPetsListResponse
    {
        public int IdPet { get; set; }
        public int IdBreedType { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime DateAdopted { get; set; }
        public DateTime ApprocimateDateOfBirth { get; set; }
    }
}
