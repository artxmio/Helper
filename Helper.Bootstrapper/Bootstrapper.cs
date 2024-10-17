using Autofac;

namespace Helper.Bootstrapper
{
    public class Bootstrapper
    {
        private readonly IContainer _container;

        public Bootstrapper()
        {
            var container = new ContainerBuilder();




            _container = container.Build();
        }
    }
}
