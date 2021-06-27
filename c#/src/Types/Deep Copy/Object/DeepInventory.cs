using System;

namespace Lncodes.Tutorial.Prototype
{
    /// <summary>
    /// Serializable attribute is for BinarySerializationPrototype the xml type dosen't need it
    /// </summary>
    [Serializable]
    public sealed class DeepInventory
    {
        internal int Capacity;

        /// <summary>
        /// Constructor for xml prototype cause it's must have paramterless constructor
        /// </summary>
        private DeepInventory() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity"></param>
        public DeepInventory(int capacity) =>
            Capacity = capacity;
    }
}
