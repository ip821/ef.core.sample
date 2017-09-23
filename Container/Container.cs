using Unity;
using sample1.Data;

namespace sample1.Container
{
    public class CustomContainer
    {
        private readonly UnityContainer _container;

        public CustomContainer()
        {
            _container = new UnityContainer();
            Register<CustomDbContext>();
            Register<DemoDataGenerator>();
        }

        public void Register<TTo>()
        {
            _container.RegisterType(typeof(TTo), typeof(TTo));
        }

        public T Resolve<T>()
        {
            return (T)_container.Resolve(typeof(T));
        }
    }
}