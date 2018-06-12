using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    public abstract class Employee
    {
        public int EmpID { get; set; }

        public Employee()
        {
            //default Const.

        }
        public Employee(int empID)
        {
            this.EmpID = empID;

        }
        public abstract void Quit();
        public abstract void Feed();
        public abstract void Play();
        public abstract void Water();






    }

}
