using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sample1.Container;
using sample1.Data;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new CustomContainer();
            var app = container.Resolve<App>();
            app.Run();
        }
    }
}
