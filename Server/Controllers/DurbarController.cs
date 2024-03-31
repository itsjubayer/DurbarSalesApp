using Azure.Core;
using DurbarSalesApp.Server.Data;
using DurbarSalesApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DurbarSalesApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DurbarController : ControllerBase
    {
        private readonly DataContext _context;
        public DurbarController(DataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        [Route("GetList")]
        public async Task<ActionResult<List<GenerateList>>> GetList()
        {
            var list = await _context.GenerateListData
                .Include(e => e.RegionalOffice)
                .Include(e => e.RegionalStore)
                .Include(e => e.UpazillaSalesCentreList)
                .Include(e => e.DistrictSalesCentreList)
                //.Include(e => e.CtgType)
                //.OrderByDescending(e => e.Id)
                .ToListAsync();
            return Ok(list);
        }


    }
}
