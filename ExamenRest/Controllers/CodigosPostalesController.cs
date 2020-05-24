using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenRest.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace ExamenRest.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class CodigosPostalesController : ControllerBase
    {
        private readonly codigos_postalesContext _context;

        public CodigosPostalesController(codigos_postalesContext context)
        {
            _context = context;
        }

        // GET: api/CodigosPostales
        [HttpGet]
        public IActionResult GetCodigos()
        {
            try
            {
                var codigosPostales = _context.CodigosPostales.FromSqlRaw($"SELECT * FROM Codigos_Postales").ToList();




                if (codigosPostales == null || codigosPostales.Count <= 0)
                {
                    return NotFound();
                }

                



                return Ok(codigosPostales);
            }
            catch (Exception)
            {

                return NotFound();
            }

            
        }



        // GET: api/CodigosPostales/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCodigosPostales(string id)
        {
            try
            {
                if (id == null && id.Length > 8)
                    return NoContent();
            }
            catch (Exception)
            {
                return NotFound();

            }
            

            try
            {
                var codigosPostales = _context.CodigosPostales.FromSqlRaw($"SELECT * FROM Codigos_Postales WHERE codigo_postal={id}").ToList();




                if (codigosPostales == null || codigosPostales.Count <= 0)
                {
                    return NotFound();
                }

                string json = JsonConvert.SerializeObject(codigosPostales);
                Resp[] codigos = JsonConvert.DeserializeObject<Resp[]>(json);
                List<asentamientos> listAsentamientos = new List<asentamientos>();
                for (int i = 0; i < codigos.Length; i++)
                {
                    var js = new asentamientos
                    {
                        id = codigos[i].IdPostal.ToString(),
                        Colonia = codigos[i].AsentamientoPostal,
                        TipoAsentamiento = codigos[i].TipoAsentamientoPostal,
                        Zona = codigos[i].ZonaPostal
                    };

                    listAsentamientos.Add(js);

                }
                ResponseCodigo resp = new ResponseCodigo();
                resp.CodigoPostal = codigos[0].CodigoPostal;
                resp.Estado = codigos[0].EstadoPostal;
                resp.Ciudad = codigos[0].CiudadPostal;
                resp.Municipio = codigos[0].MunicipioPostal;
                resp.asentamientos = listAsentamientos;





                return Ok(resp);
            }
            catch (Exception)
            {

                return NotFound();
            }

        }

     
        // PUT: api/CodigosPostales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodigosPostales(int id, CodigosPostales codigosPostales)
        {
            if (id != codigosPostales.IdPostal)
            {
                return BadRequest();
            }

            _context.Entry(codigosPostales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodigosPostalesExists(id))
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

        // POST: api/CodigosPostales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CodigosPostales>> PostCodigosPostales(CodigosPostales codigosPostales)
        {
            _context.CodigosPostales.Add(codigosPostales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCodigosPostales", new { id = codigosPostales.IdPostal }, codigosPostales);
        }

        // DELETE: api/CodigosPostales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CodigosPostales>> DeleteCodigosPostales(int id)
        {
            var codigosPostales = await _context.CodigosPostales.FindAsync(id);
            if (codigosPostales == null)
            {
                return NotFound();
            }

            _context.CodigosPostales.Remove(codigosPostales);
            await _context.SaveChangesAsync();

            return codigosPostales;
        }

        private bool CodigosPostalesExists(int id)
        {
            return _context.CodigosPostales.Any(e => e.IdPostal == id);
        }
    }
}
