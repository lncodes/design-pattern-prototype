using System.Collections.Generic;

namespace Lncodes.Tutorial.Prototype
{
    public class RegistryPrototype
    {
        private readonly Dictionary<int, RegistryCharacter> _registryCharacterCollection = new Dictionary<int, RegistryCharacter>();

        /// <summary>
        /// Method to add registry character to registry prototype collection
        /// </summary>
        /// <param name="index"></param>
        /// <param name="registryCharacter"></param>
        public void AddRegistryCharacter(int index, RegistryCharacter registryCharacter) =>
            _registryCharacterCollection.Add(index, registryCharacter);

        /// <summary>
        /// Method to clone registry character at the spesific index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public RegistryCharacter CloneCharacter(int index) =>
            _registryCharacterCollection[index].Clone();
    }
}