using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Database
{
   public static class DB
    {
        public static MyLibraryAppEntities DB_s { get; set; } = new MyLibraryAppEntities();
    }
}
