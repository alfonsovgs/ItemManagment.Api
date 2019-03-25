using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemManagment.Api.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItemManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemDbContext _dbContext;

        public ItemController(ItemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [EnableQuery()]
        public async Task<IActionResult> Get()
        {
            var items = await _dbContext.Items.ToListAsync();
            return Ok(items);
        }

        public async Task<IActionResult> Get(string name)
        {
            var items = await _dbContext.Items.Where(x => x.Name.Contains(name.ToLowerInvariant())).ToListAsync();
            return Ok(items);
        }
    }
}
