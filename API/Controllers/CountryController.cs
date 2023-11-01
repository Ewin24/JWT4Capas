using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Aplication.UnitOfWork;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class CountryController : BaseController
    {
        public readonly UnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public CountryController(UnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<Country>>> Get()
        {
            var items = await _UnitOfWork.countries.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<IEnumerable<Country>>> Get(int id)
        {
            var item = await _UnitOfWork.Country.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<Country>> Post(CountryDto itemDto)
        {
            var item = _mapper.Map<Country>(itemDto);
            this._UnitOfWork.Country.Add(item);
            await _UnitOfWork.SaveAsync();
            if (item == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<Country>> Put(int id, [FromBody] Country item)
        {
            if (item.Id == 0)
            {
                item.Id = id;
            }
            if (item.Id != id)
            {
                return BadRequest();
            }
            if (item == null)
            {
                return NotFound();
            }
            _UnitOfWork.Country.Update(item);
            await _UnitOfWork.SaveAsync();
            return item;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
        {
            var item = await _UnitOfWork.Country.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            _UnitOfWork.Country.Delete(item);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }
    }
}
