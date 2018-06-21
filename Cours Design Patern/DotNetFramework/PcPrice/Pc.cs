using System.Collections.Generic;

namespace PcPrice
{
    public class Pc
    {
        private double price = 300.00;
        private Dictionary<string, double> options = new Dictionary<string, double>();
        public Pc(Dictionary<string,double> options)
        {
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