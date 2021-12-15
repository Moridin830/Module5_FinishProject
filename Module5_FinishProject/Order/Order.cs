using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    abstract public class Order
    {

        public static int CurrentMaxId 
        { 
        
            get 
            {
                CurrentMaxId++;
                return CurrentMaxId - 1; 
            }
            private set 
            { 
                CurrentMaxId = value; 
            }
        
        }
        
    }
}
