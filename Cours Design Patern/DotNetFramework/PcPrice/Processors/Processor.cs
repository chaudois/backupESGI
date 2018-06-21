namespace PcPrice
{
    public abstract class Processor: Component{
        public Processor(string description, double price) : base (description, "Processor", price){
        }
    }
}