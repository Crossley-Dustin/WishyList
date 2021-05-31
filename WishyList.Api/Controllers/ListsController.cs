using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Api.Models;
using WishyList.Models;

namespace WishyList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListsController : ControllerBase
    {
        private readonly IListRepository listRepository;

        public ListsController(IListRepository listRepository)
        {
            this.listRepository = listRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetLists()
        {
            try
            {
                return Ok(await listRepository.GetLists());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List>> GetList(int id)
        {
            try
            {
                var result = await listRepository.GetList(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
    }
}
