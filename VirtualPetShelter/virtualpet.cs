using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public abstract class VirtualPet
    {
        private string name;
        private int energy;
        private int hunger;
        private int thirst = 40;


        public int Energy
        {
            get { return this.Energy; }
            set { this.Energy = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }




    }
}
