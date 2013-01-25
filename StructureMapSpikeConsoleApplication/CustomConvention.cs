using System;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace StructureMapSpikeConsoleApplication
{
    public class CustomConvention : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            var attributes = type.GetCustomAttributes(false);
            if (attributes.Length > 0)
            {
                if (attributes[0] is SingletonAttribute)
                {
                    registry.For(type).Singleton();
                }
                else if (attributes[0] is HttpContextAttribute)
                {
                    registry.For(type).HttpContextScoped();
                }
                else if (attributes[0] is InstanceAttribute)
                {
                    registry.For(type).LifecycleIs(new InstanceScope());
                }
            }
        }
    }
}