using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository : DbContext
    {
        public DbSet<Guestresponse> Responses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opts)
        {
            opts.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=RSVPdata;trusted_Connection=true;");
        }
    }
}
