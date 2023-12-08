using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    internal class Dogs
    {

          
        private string WhatColour;
        private int Legs;
        private bool Gender;

        public Dogs(string Whatcolour, int legs, bool gender) 
        {
            WhatColour = Whatcolour;
            Legs = legs;    
            Gender = gender;    
        
        }
        public string GetColour() 
        { 
         return WhatColour;
        }
        public int GetLegs() 
        {
            return Legs;
        }
        public bool GetGender() 
        {
          return Gender;
        }
           
        
    }
}