using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EpamLabRab.Models
{
    public class DataEntityBase:DbContext
    {
        public DbSet<PersonDatabase> Persons
        {
            get;
            set;
        }
    }
}