using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.API.Data
{
    public interface IDbSeeder
    {
        void Seed();
    }

    public class DbSeeder : IDbSeeder
    {
        public void Seed()
        {

        }
    }
}
