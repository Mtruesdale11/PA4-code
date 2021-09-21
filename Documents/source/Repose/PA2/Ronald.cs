using System;
using System.Collections.Generic;
namespace PA2
{
    public class Ronald : Fighter 
    {
        public Ronald()
        {
                Name = "Ronald";
                Health = 100;
                MaxThrowPower = 100;
                MaxBlockPower = 100;
                
            IThrowBehavior = new ChickenNuggets();
        }
    }
}