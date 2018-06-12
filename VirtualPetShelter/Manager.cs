using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public class Manager : Employee
    {   
      public Manager()
        {


        }
        public override void Feed()
        {
            Console.WriteLine("thanks for feeding an animal");


        }
        public override void Play()
        {
            Console.WriteLine("how much fun was that to play with an animal");
        }
        public override void  Water()
        {
            Console.WriteLine("a refreshing drink was given to an animal");

        }
        public override void Quit()
        {

            Console.WriteLine("leaving so soon? see you later");
        }
        public static void Adopt()
        {
            Console.WriteLine("a pet has found a home how excitin!!");

        }
}       public class Quit
    {

    }
    


    }



