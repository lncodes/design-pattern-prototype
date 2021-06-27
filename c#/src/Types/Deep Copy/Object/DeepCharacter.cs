using System;

namespace Lncodes.Tutorial.Prototype
{
    /// <summary>
    /// Serializable attribute is for BinarySerializationPrototype the xml type dosen't need it
    /// </summary>
    [Serializable]
    public abstract class DeepCharacter
    {
        internal int Level;

        /// <summary>
        /// Reference field must have public access to serialize xml or you can use { DataContract (Not Tested Yet) }
        /// It will return null reference if you don't use publi access
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractattribute?view=net-5.0"/>
        /// <seealso cref="https://stackoverflow.com/questions/802711/serializing-private-member-data"/>
        /// </summary>
        public string Name { get; set; }
        public DeepInventory Inventory { get; set; }

        /// <summary>
        /// Constructor for xml prototype cause it's must have paramterless constructor
        /// </summary>
        protected DeepCharacter() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="inventory"></param>
        protected DeepCharacter(string name, int level, DeepInventory inventory)
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
        /// Method to get result of character
        /// </summary>
        /// <returns></returns>
        public object[] GetResult() =>
            new object[] { Name, Level, Inventory.Capacity };
    }
}
