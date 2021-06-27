using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Lncodes.Tutorial.Prototype
{
    public sealed class SafeBinaryBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            if (typeName is "BinarySerializationPrototype")
            {
                throw new SerializationException("Only BinarySerializationPrototype type allowed");
            }
            return Assembly.Load(assemblyName).GetType(typeName);
        }
    }
}