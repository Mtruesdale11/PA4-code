namespace PA2
{
    public class Hamburgler: Fighter
    {
        public Hamburgler()
        {
                Name = "Hamburgler";
                Health =100;
                MaxThrowPower = 100;
                MaxBlockPower = 100;
           
            IThrowBehavior = new Hamburger();
        }
    }
}