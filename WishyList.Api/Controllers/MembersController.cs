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
    public class MembersController : ControllerBase
    {
        private readonly IMemberRepository memberRepository;

        public MembersController(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetMembers()
        {
            try
            {
                return Ok(await memberRepository.GetMembers());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Member>> GetMember(int id)
        {
            try
            {
                var result = await memberRepository.GetMember(id);

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

        [Route("[action]/{email}")]
        [HttpGet]
        public async Task<ActionResult<Member>> GetMemberByEmail(string email)
        {
            // api/members/getmemberbyemail/dustin@example.com
            try
            {
                var result = await memberRepository.GetMemberByEmail(email);

                if (result == null)
                {
                    // this sends a 404 to caller and blows up
                    //return NotFound();
                    //return NoContent();
                    return null;
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Member>> CreateMember(Member member)
        {
            try
            {
                if(member == null)
                {
                    return BadRequest();
                }

                var mem = await memberRepository.GetMemberByEmail(member.Email);

                if(mem != null)
                {
                    ModelState.AddModelError("email", "Member email already in use");
                    return BadRequest(ModelState);
                }

                var createdMember = await memberRepository.AddMember(member);

                return CreatedAtAction(nameof(GetMember), new { id = createdMember.MemberId }, createdMember);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Member>> UpdateMember(int id, Member member)
        {
            try
            {
                if(id != member.MemberId)
                {
                    return BadRequest("Member ID mismatch");
                }

                var memberToUpdate = await memberRepository.GetMember(id);

                if(memberToUpdate == null)
                {
                    return NotFound($"Member with Id = {id} not found");
                }

                return await memberRepository.UpdateMember(member);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Member>> DeleteMember(int id)
        {
            try
            {
                var memberToDelete = await memberRepository.GetMember(id);

                if(memberToDelete == null)
                {
                    return NotFound($"Member with Id = {id} not found");
                }

                return await memberRepository.DeleteMember(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}
