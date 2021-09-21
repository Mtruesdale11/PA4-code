using System;
using System.Collections.Generic;
namespace PA2
{
    public class Fighter
    {
        public IThrow IThrowBehavior {get;set;}
        public IBlock IBlockBehavior {get;set;}
        public string Name {get;set;} 
        public double Health {get;set;}= 100;
        public int MaxThrowPower {get;set;}=110;
        public int MaxBlockPower {get;set;}=100;

        Random rnd = new Random();

        public double Attack()
        {
            return rnd.Next(1,(int)MaxThrowPower);
        }
        public double Block()
        {
            return rnd.Next(1,(int)MaxBlockPower);
        }


    }
}