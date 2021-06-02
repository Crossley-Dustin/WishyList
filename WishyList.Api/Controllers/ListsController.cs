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

        private readonly IMemberRepository memberRepository;

        public ListsController(IListRepository listRepository, IMemberRepository memberRepository)
        {
            this.listRepository = listRepository;
            this.memberRepository = memberRepository;
        }

        /*
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
        */

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

        [HttpPost]
        public async Task<ActionResult<List>> CreateList(int memberId, List list)
        {
            try
            {
                // Check list
                if (list == null)
                {
                    return BadRequest("Empty list");
                }

                // check member
                var member = await memberRepository.GetMember(memberId);

                if (member == null)
                {
                    return BadRequest("Invalid member");
                }

                // check list name
                var lst = await listRepository.GetListByName(list.Name);

                if (lst != null)
                {
                    ModelState.AddModelError("List Name", "List name already in use.");
                    return BadRequest(ModelState);
                }

                // create list
                var createdList = await listRepository.AddList(list);

                return CreatedAtAction(nameof(GetList), new { id = createdList.ListId }, createdList);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<List>> UpdateList(int id, List list)
        {
            try
            {
                if (id != list.ListId)
                {
                    return BadRequest("List ID mismatch");
                }

                var listToUpdate = await listRepository.GetList(id);

                if (listToUpdate == null)
                {
                    return NotFound($"List with Id = {id} not found");
                }

                return await listRepository.UpdateList(list);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<List>> DeleteList(int id)
        {
            try
            {
                var listToDelete = await listRepository.GetList(id);

                if (listToDelete == null)
                {
                    return NotFound($"List with Id = {id} not found");
                }

                return await listRepository.DeleteList(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}
