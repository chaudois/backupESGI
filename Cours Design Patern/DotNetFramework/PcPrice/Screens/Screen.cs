namespace PcPrice
{
    public abstract class Screen: Component{
        public Screen(string description, double price) : base(description, "Screen", price){
        }
    }
}