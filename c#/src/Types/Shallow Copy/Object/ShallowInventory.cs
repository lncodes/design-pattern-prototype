namespace Lncodes.Tutorial.Prototype
{
    public sealed class ShallowInventory
    {
        internal int Capacity;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity"></param>
        public ShallowInventory(int capacity) =>
            Capacity = capacity;
    }
}
