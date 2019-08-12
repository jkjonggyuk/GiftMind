using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GiftMind.Models
{
    public class GiftMindContext : DbContext
    {
        public GiftMindContext (DbContextOptions<GiftMindContext> options)
            : base(options)
        {
        }

        public DbSet<GiftMind.Models.GiftCard> GiftCard { get; set; }
    }
}
