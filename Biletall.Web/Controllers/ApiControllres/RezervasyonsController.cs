using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biletall.Web.Data;
using Biletall.Web.Data.Entity;
using Biletall.Web.BusinesLogic;
using Biletall.Web.Models;

namespace Biletall.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervasyonsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RezervasyonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rezervasyons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rezervasyon>>> GetRezervasyonlar()
        {
            return await _context.Rezervasyonlar.ToListAsync();
        }

        // GET: api/Rezervasyons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rezervasyon>> GetRezervasyon(int id)
        {
            var rezervasyon = await _context.Rezervasyonlar.FindAsync(id);

            if (rezervasyon == null)
            {
                return NotFound();
            }

            return rezervasyon;
        }
        

        // POST: api/Rezervasyons

        [HttpPost]
        public async Task<ActionResult<Rezervasyon>> PostRezervasyon(Rezervasyon rezervasyon,string islem)
        {
            _context.Rezervasyonlar.Add(rezervasyon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRezervasyon", new { id = rezervasyon.Id }, rezervasyon);
        }

    }
}
