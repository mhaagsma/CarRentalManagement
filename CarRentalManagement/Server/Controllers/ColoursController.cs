﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        // GET: api/Colours
        [HttpGet]
        public async Task<IActionResult> GetColours()
        {
            var colours = await _unitOfWork.Colours.GetAll();
            return Ok(colours);
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColour(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);

            if (colour == null)
            {
                return NotFound();
            }

            return Ok(colour);
        }

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour colour)
        {
            await _unitOfWork.Colours.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("PostColour", new { id = colour.Id }, colour);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {
            if (id != colour.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colours.Update(colour);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            if (colour == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colours.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> ColourExists(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            return colour != null;
        }
    }
}
