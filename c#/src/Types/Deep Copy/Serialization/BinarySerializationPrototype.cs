using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lncodes.Tutorial.Prototype
{
    /// <summary>
    /// Need Serializable attribute to serialize class into BinaryFormatter
    /// </summary>
    [Serializable]
    public sealed class BinarySerializationPrototype : DeepCharacter
    {
        /// <inheritdoc cref="DeepCharacter"/>
        public BinarySerializationPrototype(string name, int level, DeepInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone BinarySerializationPrototype object
        /// </summary>
        /// <returns cref="BinarySerializationPrototype"></returns>
        public BinarySerializationPrototype Clone()
        {
            using (var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, this);
                binaryFormatter.Binder = new SafeBinaryBinder();
                memoryStream.Position = default;
                return binaryFormatter.Deserialize(memoryStream) as BinarySerializationPrototype;
            }
        }
    }
}
