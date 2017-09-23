using System.Linq;
using sample1.Data;
using sample1.Entities;

namespace sample1
{
    public class DemoDataGenerator
    {
        private readonly DataContextFactory _factory;
        public DemoDataGenerator(DataContextFactory factory)
        {
            _factory = factory;
        }

        public void Generate()
        {
            using (var context = _factory.CreateContext())
            {
                using (var tx = context.Context.Database.BeginTransaction())
                {
                    if (!context.Context.Set<Author>().Any())
                    {
                        var entity = new Author("test_name");
                        context.Context.Set<Author>().Add(entity);
                        context.Context.SaveChanges();
                    }
                    tx.Commit();
                }
            }
        }
    }
}