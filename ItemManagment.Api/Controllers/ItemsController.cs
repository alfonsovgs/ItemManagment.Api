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
    public class ItemsController : ControllerBase
    {
        private readonly ItemDbContext _dbContext;

        public ItemsController(ItemDbContext dbContext)
        {
            _dbContext = dbContext;
            DataBaseInitializer.Initialize(_dbContext);
        }

        [HttpGet]
        [EnableQuery()]
        public async Task<IActionResult> Get()
        {
            try
            {
                var items = await _dbContext.Items.ToListAsync();
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var items = await _dbContext.Items.Where(x => x.Name.Contains(name.ToLowerInvariant())).ToListAsync();
            return Ok(items);
        }
    }
}
