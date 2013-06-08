using Models;
using StructureMap;

namespace MultipleObjectDemo
{
    public class Ioc
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.AssemblyContainingType<IPerson>();
                    scan.WithDefaultConventions();
                });

                x.For<IPerson>().Use<Hero>().Named(PersonType.Hero.ToString()); 
                x.For<IPerson>().Use<Villan>().Named(PersonType.Villan.ToString()); 

            });
            
            return ObjectFactory.Container;
        }

        public static IPerson CreatePerson(IContainer container, string key)
        {
            try
            {
                return container.GetInstance<IPerson>(key.ToUpper());
            }
            catch 
            {
                return null;
            }
        }
    }
}