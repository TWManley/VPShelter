using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public class Animals : VirtualPet
    {
        internal int PetHunger;

        public string Cat { get; set; }
      public string Dog { get; set; }
      public string Gecko { get; set; }
      public string CatFood { get; set; }
      public string DogFood { get; set; }
      public string Crickets { get; set; }
        public int energy { get; internal set; }

        public Animals()
        {


        }
        public Animals(string cat, string dog, string gecko, string catfood, string dogfood, string crickets)
        {
            this.Cat = cat;
            this.Dog = dog;
            this.Gecko = gecko;
            this.DogFood = dogfood;
            this.CatFood = catfood;
            this.Crickets = crickets;
         

        

        }
        public void SeeAnimalInfo()
        {
            Cat = "Meet";
            Dog = "Od";
            Gecko = "Spot";
            CatFood = "friskie";
            DogFood = "bones";
            Crickets = "Crickets";

            Console.WriteLine("Animal Name        | Hunger       | thirst          ");
            Console.WriteLine(Dog + "              | " + PetHunger + "  " + Energy);
            Console.WriteLine(Gecko + "              | " + PetHunger + "  " + Energy);
            Console.WriteLine(Cat + "              | " + PetHunger + "  " + Energy  );
            Console.WriteLine();
            Console.WriteLine();

        }
        public void CatAdopted()
        {
            Console.WriteLine("meet the cat is happy you are taking her home please feed her {0}.",CatFood  );
            Console.WriteLine();
            Console.WriteLine();
            


        }
        public void DogAdopted()
        {
            Console.WriteLine("Od the dog is stinky but a great companion please feed him {0}.", DogFood);
            Console.WriteLine();
            Console.WriteLine();

        }
        public void GeckoAdopted()
        {
            Console.WriteLine("meet the cat is happy you are taking her home please feed her {0}.", Crickets);
            Console.WriteLine();
            Console.WriteLine();
        }
        public void CatEat()
        {
            Energy += 20;
        }
        public void DogEat()
        {
            Energy += 15;
        }
        public void Geckoeat()
        {
            Energy += 10;
        }
        public void Playing()
        {
            Energy -= 15;
            int Bordom = 0;
            Bordom -= 20;

        }

        internal void TickAttribute()
        {
            throw new NotImplementedException();
        }
    }









}
