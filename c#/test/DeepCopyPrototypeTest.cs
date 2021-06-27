using Xunit;

namespace Lncodes.Tutorial.Prototype.Test
{
    public sealed class DeepCopyPrototypeTest
    {
        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_ManualDeepCopyPrototype_AreNotEqual(string name, int level, DeepInventory inventory)
        {
            var expected = new ManualDeepCopyPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.NotEqual(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_BinarySerializationPrototype_AreNotEqual(string name, int level, DeepInventory inventory)
        {
            var expected = new BinarySerializationPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.NotEqual(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_XmlSerializationPrototype_AreNotEqual(string name, int level, DeepInventory inventory)
        {
            var expected = new XmlSerializationPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.NotEqual(expected.GetResult(), actual.GetResult());
        }
    }
}
