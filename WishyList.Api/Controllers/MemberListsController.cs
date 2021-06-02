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
    public class MemberListsController : ControllerBase
    {
        private readonly IListRepository listRepository;

        public MemberListsController(IListRepository listRepository)
        {
            this.listRepository = listRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List>> GetMemberLists(int Id)
        {
            try
            {
                return Ok( await listRepository.GetMemberLists(Id));

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
    }
}
