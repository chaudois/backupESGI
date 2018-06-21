namespace PcPrice{
    
    public abstract class Component {

        public string desc {get;}
        public string type {get;}
        public double price {get;}
       
        public double getPrice(){
            return price;
        }

        public Component(string desc, string type, double price){
            this.desc  = desc;
            this.type  = type;
            this.price = price;
        }
    }
}