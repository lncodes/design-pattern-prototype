using System.IO;
using System.Xml.Serialization;

namespace Lncodes.Tutorial.Prototype
{
    public sealed class XmlSerializationPrototype : DeepCharacter
    {
        /// <summary>
        /// Constructor for xml prototype cause it's must have paramterless constructor
        /// </summary>
        private XmlSerializationPrototype() { }

        /// <inheritdoc cref="DeepCharacter"/>
        public XmlSerializationPrototype(string name, int level, DeepInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone XmlSerializationPrototype object
        /// </summary>
        /// <returns cref="XmlSerializationPrototype"></returns>
        public XmlSerializationPrototype Clone()
        {
            using (var memoryStream = new MemoryStream())
            {
                var xmlSerialization = new XmlSerializer(typeof(XmlSerializationPrototype));
                xmlSerialization.Serialize(memoryStream, this);
                memoryStream.Position = default;
                return xmlSerialization.Deserialize(memoryStream) as XmlSerializationPrototype;
            }
        }
    }
}
