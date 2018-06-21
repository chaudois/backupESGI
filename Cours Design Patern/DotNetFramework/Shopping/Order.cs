using System.Collections.Generic;

namespace Shopping
{
    public class Order: ICloanableOrder
    {
        private Status status = Status.InProgress;

        private List<Item> items = new List<Item>();

        public List<Item> Items { get => items; }

        public void AddItem(Item item)
        {
            if(status == Status.InProgress)
            {
                items.Add(item);
            }
            else
            {
                throw new System.NotSupportedException();
            }
        }

        public void RemoveItem(Item item)
        {
            switch (status)
            {
                case Status.InProgress:
                case Status.Validated:
                    items.Remove(item);
                    break;
                default:
                    throw new System.NotSupportedException();
            }
        }

        public void NextStatus()
        {
            status = status + 1;
        }

        public object Clone()
        {
            return (ICloanableOrder)MemberwiseClone();
        }
    }
}
