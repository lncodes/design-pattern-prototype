namespace Lncodes.Tutorial.Prototype
{
    public abstract class ShallowCharacter
    {
        protected readonly int Level;
        protected readonly string Name;
        protected readonly ShallowInventory Inventory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="inventory"></param>
        protected ShallowCharacter(string name, int level, ShallowInventory inventory)
        {
            Name = name;
            Level = level;
            Inventory = inventory;
        }

        /// <summary>
        /// Method to set inventory capacity this for test shallow / deep copy
        /// </summary>
        /// <param name="capacity"></param>
        public void SetInventoryCapacity(int capacity) =>
            Inventory.Capacity = capacity;

        /// <summary>
        /// Method to get result of cloneable character
        /// </summary>
        /// <returns cref="object[]"></returns>
        public object[] GetResult() =>
            new object[] { Name, Level, Inventory.Capacity };
    }
}