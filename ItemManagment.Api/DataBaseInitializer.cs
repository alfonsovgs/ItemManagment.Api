using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemManagment.Api.Models;

namespace ItemManagment.Api
{
    public static class DataBaseInitializer
    {
        public static void Initialize(ItemDbContext context)
        {
            if(context.Items.Any()) return;
            context.Database.EnsureCreated();
            
            for (var i = 1; i <= 20; i++)
            {
                var item = new Item
                {
                    Name = $"Item {i}",
                    Code = $"Code {i}",
                    Active = true,
                    Clasifications = new List<Clasification>
                    {
                        new Clasification {Name = $"Clasification {i}"}
                    },
                };

                context.Items.Add(item);
            }
            context.SaveChanges();
        }
    }
}
