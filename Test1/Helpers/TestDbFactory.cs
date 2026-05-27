using Gaming_store.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Helpers
{
    public class TestDbFactory
    {
        public static GameContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<GameContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            GameContext context = new GameContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
