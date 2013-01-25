using StructureMap;

namespace StructureMapSpikeConsoleApplication
{
    public class Ioc
    {
        public static IContainer Initialize()
        {
            //example on how to register a concrete type with a constructor parameter
            ////x.ForConcreteType<CategoryPageQuery>().Configure
            //    .Ctor<string>("connectionString").Is(fragranceXConnection);

            ObjectFactory.Initialize(x =>
                {
                    x.Scan(scan =>
                        {
                            scan.TheCallingAssembly();
                            scan.AssemblyContainingType<INinja>();
                            scan.WithDefaultConventions();
                            scan.Convention<CustomConvention>();
                        });

                    //x.For<IFlexMembershipProvider>().HttpContextScoped().Use<FlexMembershipProvider>(); 

                });
            return ObjectFactory.Container;
        }
    }
}