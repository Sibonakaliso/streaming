using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Stream2nd.Models
{
    public class SongsDBContext : DbContext
    {
        public SongsDBContext() : base("SongsDBContext")
        {

        }
        public DbSet<Songs> Songs { get; set; }
    }
}