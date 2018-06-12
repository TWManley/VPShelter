using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public class Volunteer : Employee


    {
        public Volunteer()
        {
            //default construct
        }
        public override void Feed()
        {
            Console.WriteLine("you fed an animal good job check for fingers!");
        }
        public override void Play()
        {
            Console.WriteLine("you played with an animal the animal appreciates that");
        }
        public override void Water()
        {
            Console.WriteLine("That was a refreshing drink for the animal");
        }
        public override void Quit()
        {
            Console.WriteLine("Thanks for pliying");
        }





    }








}
