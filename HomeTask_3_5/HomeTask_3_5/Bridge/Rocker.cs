namespace HomeTask_3_5.Bridge
{
    public class Rocker : Listener
    {
        public Rocker()
            : base(new RockMusic())
        {
        }
    }
}
