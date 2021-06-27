namespace Lncodes.Tutorial.Prototype
{
    public sealed class ManualDeepCopyPrototype : DeepCharacter
    {
        /// <inheritdoc cref="DeepCharacter"/>
        public ManualDeepCopyPrototype(string name, int level, DeepInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone ManualDeepCopyPrototype object
        /// </summary>
        /// <returns cref="ManualDeepCopyPrototype"></returns>
        public ManualDeepCopyPrototype Clone()
        {
            var deepClonePrototype = this.MemberwiseClone() as ManualDeepCopyPrototype;
            deepClonePrototype.Name = new string(Name);
            deepClonePrototype.Inventory = new DeepInventory(Inventory.Capacity);
            return deepClonePrototype;
        }
    }
}