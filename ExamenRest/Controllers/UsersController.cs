using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenRest.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace ExamenRest.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly codigos_postalesContext _context;

        public UsersController(codigos_postalesContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public IActionResult GetUsers(string id)
        { return Ok(); }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users users)
        {
            if (id != users.IdUser)
            {
                return BadRequest();
            }

            _context.Entry(users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<IActionResult> PostUsers(RequestLogin users)
        {

            if (users.password == null && users.username == null)
            {
                return NotFound();
            }

            try
            {
                var usersSql = _context.Users.FromSqlRaw($"SELECT * FROM Users WHERE nombre_user='{users.username}' and pass_user='{users.password}'").ToList();

                if (users == null || usersSql.Count <= 0)
                {
                    return NotFound();
                }
                string json = JsonConvert.SerializeObject(usersSql);
                Users[] userLogin = JsonConvert.DeserializeObject<Users[]>(json);

                ResponseLogin jsonResponse = new ResponseLogin();
                jsonResponse.id = userLogin[0].IdUser.ToString();
                jsonResponse.role = userLogin[0].PrivilegioUser.ToString();
                jsonResponse.user = userLogin[0].NombreUser.ToString();
                return Ok(jsonResponse);
            }
            catch (Exception ez)
            {

                return NotFound();
            }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> DeleteUsers(int id)
        {
            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            _context.Users.Remove(users);
            await _context.SaveChangesAsync();

            return users;
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.IdUser == id);
        }
    }
}
