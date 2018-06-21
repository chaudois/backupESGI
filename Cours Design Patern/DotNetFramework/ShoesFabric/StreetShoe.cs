namespace ShoesFabric
{
    internal class StreetShoe : IShoe
    {
        private ShoeType type;

        public StreetShoe(ShoeType leather)
        {
            this.type = leather;
        }

        public IMateriel matos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}