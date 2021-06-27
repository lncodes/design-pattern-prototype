using System;

namespace Lncodes.Tutorial.Prototype
{
    public sealed class SingeltonRegistryPrototype : RegistryPrototype
    {
        #region Singelton
        /// <summary>
        /// Class instance
        /// </summary>
        private static readonly Lazy<SingeltonRegistryPrototype> _instance = new Lazy<SingeltonRegistryPrototype>(CreateInstance);

        /// <summary>
        /// Constructor
        /// </summary>
        private SingeltonRegistryPrototype() { }

        /// <summary>
        /// Method to create class instance
        /// </summary>
        /// <returns cref="SingeltonBuilder"></returns>
        private static SingeltonRegistryPrototype CreateInstance() =>
            new SingeltonRegistryPrototype();

        /// <summary>
        /// Method to get class instance
        /// </summary>
        /// <returns cref="SingeltonBuilder"></returns>
        public static SingeltonRegistryPrototype GetInstance() =>
            _instance.Value;
        #endregion
    }
}
