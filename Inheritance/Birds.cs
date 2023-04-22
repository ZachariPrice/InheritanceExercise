using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{



    public class Bird : Animal
    {
        public Bird()
        { 
            isAlive = true;
            Legs = 2;
            Age = 2000;
            Name = "Moltres";
        }

        public int wings { get; set; }

        public string Type { get; set; }
     
        public bool HasFeathers { get; set; }

        public bool HasABeak { get; set; }

        
        

    }
} 