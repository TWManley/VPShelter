using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public class VirtualpetShelter
    {
        public string PetEnclosure { get;  set; }
        public List<Animals> AnimalList { get; set; }

        public VirtualpetShelter()
        {
            //default construct 
        }
        public VirtualpetShelter (string AnimalEnclosure, List<Animals> AnimalList)
        {
            //loaded construct
        }
        public VirtualpetShelter(List<Animals> AnimalList, string cat, string dog, string gecko)
        {
            this.AnimalList = AnimalList;
            this.AnimalList = AnimalList;
        }
      
        
      


       
    }
}
