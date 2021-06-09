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
    public class ItemsController : ControllerBase
    {
        private readonly IListRepository listRepository;
        private readonly IItemRepository itemRepository;
        private readonly IMemberRepository memberRepository;

        public ItemsController(IMemberRepository memberRepository, IListRepository listRepository, IItemRepository itemRepository)
        {
            this.listRepository = listRepository;
            this.itemRepository = itemRepository;
            this.memberRepository = memberRepository;
        }

        [Route("[action]/{id:int}")]
        [HttpGet]
        public async Task<ActionResult<Item>> GetListItems(int id)
        {
            // api/items/GetListItems/1
            try
            {
                return Ok(await itemRepository.GetListItems(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            try
            {
                var result = await itemRepository.GetItem(id);

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
        public async Task<ActionResult<Item>> CreateItem(Item item)
        {
            try
            {
                // Check item
                if (item == null)
                {
                    return BadRequest("Empty Item");
                }

                // Check list
                var list = await listRepository.GetList(item.ListId);

                if (list == null)
                {
                    return BadRequest("Invalid list");
                }

                // Check member
                var member = await memberRepository.GetMember(item.MemberId);

                if (member == null)
                {
                    return BadRequest("Invalid member");
                }
                
                // Check item name, makes sure it is unique within the current list
                var itm = await itemRepository.GetItemByName(item.ListId, item.Label);

                if (itm != null)
                {
                    ModelState.AddModelError("Item Name", "Item name already in use for this list");
                }

                // create item
                var createdItem = await itemRepository.AddItem(item);

                return CreatedAtAction(nameof(GetItem), new { id = createdItem.ListId }, createdItem);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Item>> UpdateItem(int id, Item item)
        {
            try
            {
                if (id != item.ItemId)
                {
                    return BadRequest("Item ID mismatch");
                }

                var itemToUpdate = await itemRepository.GetItem(id);

                if (itemToUpdate == null)
                {
                    return NotFound($"Item with Id = {id} not found");
                }

                return await itemRepository.UpdateItem(item);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Item>> DeleteItem(int id)
        {
            try
            {
                var itemToDelete = await itemRepository.GetItem(id);

                if (itemToDelete == null)
                {
                    return NotFound($"Item with Id = {id} not found");
                }

                return await itemRepository.DeleteItem(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}
