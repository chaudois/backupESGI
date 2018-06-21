namespace PcPrice
{
    public abstract class VideoCard: Component{
        public VideoCard(string description, double price) : base(description, "VideoCard", price){
        }
    }
}