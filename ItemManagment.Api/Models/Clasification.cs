using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemManagment.Api.Models
{
    public class Clasification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
