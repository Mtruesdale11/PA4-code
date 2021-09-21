using System;
namespace PA2
{
    public class Hamburger : IThrow
    {
        public void Throw()
        {
            Console.WriteLine("You threw a burger");
        }
    }
}