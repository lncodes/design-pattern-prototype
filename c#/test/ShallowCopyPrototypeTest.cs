using Xunit;

namespace Lncodes.Tutorial.Prototype.Test
{
    public sealed class ShallowCopyPrototypeTest
    {
        [Theory]
        [ClassData(typeof(ShallowCopyTheoryData))]
        public void Clone_NetInterfacePrototype_AreEqual(string name, int level, ShallowInventory inventory)
        {
            var expected = new CloneableInterfacePrototype(name, level, inventory);

            var actual = expected.Clone() as CloneableInterfacePrototype;
            actual.SetInventoryCapacity(default);

            Assert.Equal(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(ShallowCopyTheoryData))]
        public void Clone_ConstructorPrototype_AreEqual(string name, int level, ShallowInventory inventory)
        {
            var expected = new ConstructorPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.Equal(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(ShallowCopyTheoryData))]
        public void Clone_RegistryPrototype_AreEqual(string name, int level, ShallowInventory inventory)
        {
            var registryPrototype = new RegistryPrototype();
            var expected = new RegistryCharacter(name, level, inventory);

            registryPrototype.AddRegistryCharacter(default, expected);
            var actual = registryPrototype.CloneCharacter(default);
            actual.SetInventoryCapacity(default);

            Assert.Equal(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(ShallowCopyTheoryData))]
        public void Clone_SingeltonRegistryPrototype_AreEqual(string name, int level, ShallowInventory inventory)
        {
            var singeltonRegistryPrototype = SingeltonRegistryPrototype.GetInstance();
            var expected = new RegistryCharacter(name, level, inventory);

            singeltonRegistryPrototype.AddRegistryCharacter(default, expected);
            var actual = singeltonRegistryPrototype.CloneCharacter(default);
            actual.SetInventoryCapacity(default);

            Assert.Equal(expected.GetResult(), actual.GetResult());
        }
    }
}
