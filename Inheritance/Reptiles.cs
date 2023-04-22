using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptiles : Animal
    {
        public Reptiles()
        {
            isAlive = true;
            Legs = 4;
            Age = 500;
            Name = "Dragonite";
        }

        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }

        public string Habitat { get; set; }

        public bool CanGrowTail { get; set; }

    }

}   