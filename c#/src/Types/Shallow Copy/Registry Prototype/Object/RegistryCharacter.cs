namespace Lncodes.Tutorial.Prototype
{
    public sealed class RegistryCharacter : ShallowCharacter
    {
        /// <inheritdoc cref="ShallowCharacter"/>
        public RegistryCharacter(string name, int level, ShallowInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone RegistryCharacter object
        /// </summary>
        /// <returns cref="RegistryCharacter"></returns>
        public RegistryCharacter Clone() =>
            this.MemberwiseClone() as RegistryCharacter;
    }
}