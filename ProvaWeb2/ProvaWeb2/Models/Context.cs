using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaWeb2.Models
{
    public class Context: DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
    }
}