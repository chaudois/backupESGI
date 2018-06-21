namespace PcPrice
{
    public abstract class Bag: Component{
        public Bag(string description, double price) : base(description, "Bag", price){
        }
    }
}