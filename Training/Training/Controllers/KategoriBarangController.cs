using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Training.Data;
using Training.Dto;
using Training.Model;

namespace Training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriBarangController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public KategoriBarangController(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<KategoriBarangDto>> Get()
        {
            var model = await _context.KategoriBarang.ToListAsync();
            return _mapper.Map<List<KategoriBarangDto>>(model);
        
        }

        [HttpGet("{id}")]
        public async Task<KategoriBarang> Get(int id)
        {
            var model = await _context.KategoriBarang.FirstOrDefaultAsync(x => x.IdKategori == id);
            if (model == null)
                return null;

            return model;

        }

        [HttpPost]
        public async Task<IActionResult> Post(InputKategoriBarang input)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = new KategoriBarang {
                NamaKategori = input.NamaKategori
            };

            await _context.KategoriBarang.AddAsync(model);
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateKategoriBarang updateKategori)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = await _context.KategoriBarang.FirstOrDefaultAsync(x => x.IdKategori == updateKategori.IdKategori );
            if (model == null)
                return StatusCode(204, "No Content");

            model.NamaKategori = updateKategori.NamaKategori;
            await _context.SaveChangesAsync();

            return StatusCode(200, "Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var model = await _context.KategoriBarang.FirstOrDefaultAsync(x => x.IdKategori == Id);
            if (model == null)
                return StatusCode(204, "No Content");


            _context.Remove(model);

            await _context.SaveChangesAsync();

            return StatusCode(200, "Deleted");
        }



    }
}