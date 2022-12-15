namespace Lecture.Farming
{
    public class Cow : FarmAnimal, ISellable
    {
        public decimal Price { get; }
        public Cow() : base("Cow", "moo")
        {
            this.Price = 1500;
        }
    }
}
