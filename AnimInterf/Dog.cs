namespace AnimInterf
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples {get => 9;} 
        public override string Sound()
        {
            return base.Sound() + "Woof";
        }
    }
}