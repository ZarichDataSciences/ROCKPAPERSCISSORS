using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{


    public class Player
    {

        //public string player1;
        private string name1;
        public string PlayerName
        {
            get
            {
                return name1;
            }
            set
            {
                name1 = value;
            }
        }
        public string Name { get; set; }
        public bool RightHanded { get; set; }
        public int Age { get; set; }
        
    }
    


    
   }
