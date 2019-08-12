using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftMind.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GiftMindContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GiftMindContext>>()))
            {
                // Look for any giftcards.
                if (context.GiftCard.Any())
                {
                    return;   // DB has been seeded
                }

                context.GiftCard.AddRange(
                    new GiftCard
                    {
                        GiftCardNumber = System.Guid.NewGuid().ToString(),
                        Balance = 10.00M,
                        Created = DateTime.Parse("2019-1-13"),
                        LastEdited = DateTime.Parse("2019-3-13")
                    },

                    new GiftCard
                    {
                        GiftCardNumber = System.Guid.NewGuid().ToString(),
                        Balance = 12.25M,
                        Created = DateTime.Parse("2019-2-11"),
                        LastEdited = DateTime.Parse("2019-2-13")
                    },

                    new GiftCard
                    {
                        GiftCardNumber = System.Guid.NewGuid().ToString(),
                        Balance = 28.95M,
                        Created = DateTime.Parse("2018-7-12"),
                        LastEdited = DateTime.Parse("2018-8-19")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
