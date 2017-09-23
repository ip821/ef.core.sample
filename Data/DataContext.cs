using System;
using sample1.Container;

namespace sample1.Data
{
    public sealed class DataContext : IDisposable
    {
        private readonly CustomDbContext _context;

        public DataContext(CustomContainer container)
        {
            _context = container.Resolve<CustomDbContext>();
        }

        public CustomDbContext Context => _context;
        
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}