using sample1.Container;

namespace sample1.Data
{
    public class DataContextFactory
    {
        private readonly CustomContainer _container;

        public DataContextFactory(CustomContainer container)
        {
            _container = container;
        }

        public DataContext CreateContext()
        {
            return _container.Resolve<DataContext>();
        }
    }
}