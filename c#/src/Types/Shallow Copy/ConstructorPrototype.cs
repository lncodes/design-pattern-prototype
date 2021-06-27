namespace Lncodes.Tutorial.Prototype
{
    public sealed class ConstructorPrototype : ShallowCharacter
    {
        /// <inheritdoc cref="ShallowCharacter"/>
        public ConstructorPrototype(string name, int level, ShallowInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone ConstructorPrototype object
        /// </summary>
        /// <returns cref="ConstructorPrototype"></returns>
        public ConstructorPrototype Clone() =>
            new ConstructorPrototype(Name, Level, Inventory);
    }
}
