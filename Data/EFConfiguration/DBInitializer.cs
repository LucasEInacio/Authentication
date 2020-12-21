using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EFConfiguration
{
    public class DBInitializer
    {
        public static void Initialize(AuthenticationContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}