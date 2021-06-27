using System;

namespace Lncodes.Tutorial.Prototype
{
    public sealed class CloneableInterfacePrototype : ShallowCharacter, ICloneable
    {
        /// <inheritdoc cref="ShallowCharacter"/>
        public CloneableInterfacePrototype(string name, int level, ShallowInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone CloneableInterfacePrototype object
        /// </summary>
        /// <returns cref="object"></returns>
        public object Clone() =>
            this.MemberwiseClone();
    }
}