using System;
namespace PA2
{
    public class FryKids: Fighter
    { 
        public FryKids()
        {   
                Name = "FryKids";
                Health = 100;
                MaxThrowPower = 100;
                MaxBlockPower = 100;
           
            IThrowBehavior = new Fries();
        }
    }
}