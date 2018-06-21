using System.Collections.Generic;

namespace PcPrice
{
    public class Pc
    {
        private double price=0;
        private Dictionary<string, double> options = new Dictionary<string, double>();


        public Pc(Dictionary<string,double> options, double price = 300)
        {

            this.price = price;
            this.options = options;
        }

        public double getPrice()
        {
             foreach (var key in options.Keys)
            {
                price +=options[key];
            }
            return price;

        }

    }
}