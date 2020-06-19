using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Pet
    {
        public int IdPet { get; set; }
        public int IdBreedType { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime DateAdopted { get; set; }
        public DateTime ApprocimateDateOfBirth { get; set; }


        public virtual BreedType BreedTypeNavigation { get; set; }

    }
}
