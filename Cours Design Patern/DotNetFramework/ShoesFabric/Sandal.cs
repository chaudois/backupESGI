namespace ShoesFabric
{
    internal class Sandal : IShoe
    {
        private ShoeType type;

        public Sandal(ShoeType leather)
        {
            this.type = leather;
        }

        public IMateriel matos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}