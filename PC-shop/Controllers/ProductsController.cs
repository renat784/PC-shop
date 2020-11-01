using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC_shop.Data;
using PC_shop.Models;



namespace PC_shop.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly PC_shopContext _context;

        public ProductsController(PC_shopContext context)
        {
            _context = context;
        }

        // GET: Products/GetList/1
        [HttpGet("{categoryId}")]
        public async Task<ActionResult<IEnumerable<IProduct>>> GetList(int categoryId)
        {
            switch (categoryId)
            {
                case (int) Category.Cpu:
                    return await _context.CpuList.ToListAsync();
                case (int) Category.Hdd:
                    return await _context.HddList.ToListAsync();
                case (int) Category.Keyboard:
                    return await _context.KeyboardList.ToListAsync();
                case (int) Category.Monitor:
                    return await _context.MonitorList.ToListAsync();
                case (int) Category.Motherboard:
                    return await _context.MotherBoardList.ToListAsync();
                case (int) Category.Mouse:
                    return await _context.MouseList.ToListAsync();
                case (int) Category.Ram:
                    return await _context.RamList.ToListAsync();
                case (int) Category.Ssd:
                    return await _context.SsdList.ToListAsync();
                case (int) Category.VideoCard:
                    return await _context.VideoCarsList.ToListAsync();
                default:
                    return NotFound();
            }
        }

       
        // GET: Products/GetProduct/1/1
        [HttpGet("{categoryId}/{id}")]
        public async Task<ActionResult<IProduct>> GetProduct(int categoryId, int id)
        {
            ActionResult<IProduct> product;

            switch (categoryId)
            {
                case (int) Category.Cpu:
                    product = await _context.CpuList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Hdd:
                    product = await _context.HddList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Keyboard:
                    product = await _context.KeyboardList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Monitor:
                    product = await _context.MonitorList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Motherboard:
                    product = await _context.MotherBoardList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Mouse:
                    product = await _context.MouseList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Ram:
                    product = await _context.RamList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.Ssd:
                    product = await _context.SsdList.FindAsync(id);
                    return product ?? NotFound();
                case (int) Category.VideoCard:
                    product = await _context.VideoCarsList.FindAsync(id);
                    return product ?? NotFound();
                default:
                    return NotFound();
            }
        }

        //// GET: Products/GetCpuList
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<IProduct>>> GetCpuList()
        //{

        //    return await _context.CpuList.ToListAsync();
        //}

        //// GET: Products/GetCpu/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IProduct>> GetCpu(int id)
        //{
        //    var cpu = await _context.CpuList.FindAsync(id);

        //    if (cpu == null)
        //    {
        //        return NotFound();
        //    }

        //    return cpu;
        //}

        //// GET: Products/getSsdList
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Ssd>>> GetSsdList()
        //{
        //    return await _context.SsdList.ToListAsync();
        //}

        //// GET: Products/getSsd/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Ssd>> GetSsd(int id)
        //{
        //    var ssd = await _context.SsdList.FindAsync(id);

        //    if (ssd == null)
        //    {
        //        return NotFound();
        //    }

        //    return ssd;
        //}


        //private bool CpuExists(int id)
        //{
        //    return _context.CpuList.Any(e => e.Id == id);
        //}
    }
}
