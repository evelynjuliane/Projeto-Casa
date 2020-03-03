using System;
using System.Linq;
using CasaDeShow.Data;
using CasaDeShow.DTO;
using CasaDeShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CasaDeShow.Controllers
{
    [Route("api/v1/eventos")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly ApplicationDbContext database;
        public EventoController(ApplicationDbContext database){
            this.database = database;
        }
        //LIST
        [HttpGet]
        public IActionResult Get() {
            var eventos = database.Eventos.Include (p => p.Categoria).Include (p => p.CasaShow).Where (e => e.Status == true).ToList ();
            return Ok(eventos);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id){
            try{
                var eventos = database.Eventos.Include (p => p.Categoria).Include (p => p.CasaShow).Where (e => e.Status == true).ToList ();
                return Ok(eventos); 
            }catch(Exception e){
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
            
        }
        [HttpPost]
        public IActionResult Post([FromBody] EventoDTO eventsTemporary) {
            if(eventsTemporary.Nome.Length <= 1){
                Response.StatusCode = 400;
                return new ObjectResult(new { msg = "O Nome deve ter mais de  1 caracter." });
            }
            Evento events = new Evento ();
            events.Nome = eventsTemporary.Nome;
            events.Categoria = database.Categorias.First (categoria => categoria.Id == eventsTemporary.CategoriaID);
            events.CasaShow = database.CasasShows.First (c => c.Id == eventsTemporary.CasaShowID);
            events.QuantDeIngressos = eventsTemporary.QuantDeIngressos;
            events.Data = eventsTemporary.Data;

            events.ValorDoIngresso = eventsTemporary.ValorDoIngresso;
            events.Status = true;

            database.Eventos.Add(events);
            database.SaveChanges ();
            
            Response.StatusCode = 201;
            return new ObjectResult("");
        }

        [HttpPatch]
        public IActionResult Patch ([FromBody] EventoDTO eventsTemporary) {
            if (eventsTemporary.Id > 0)
            {
                try
                {
                    var events = database.Eventos.First (e => e.Id == eventsTemporary.Id);
                    if(eventsTemporary != null){
                        events.Nome = eventsTemporary.Nome;
                        events.Categoria = database.Categorias.First (categoria => categoria.Id == eventsTemporary.CategoriaID);
                        events.CasaShow = database.CasasShows.First (casashow => casashow.Id == eventsTemporary.CasaShowID);
                        events.ValorDoIngresso = eventsTemporary.ValorDoIngresso;
                        events.Data = eventsTemporary.Data;
                        events.ValorDoIngresso = eventsTemporary.ValorDoIngresso;
                        
                        database.SaveChanges ();
                        return Ok();
                    }else
                    {
                        Response.StatusCode = 400;
                        return new ObjectResult(new { msg = "Evento não encontrado!" });
                    }
                }catch(Exception e){
                    Response.StatusCode = 400;
                    return new ObjectResult(new { msg = "Evento não encontrado!" });
                }
            }else{
                Response.StatusCode = 400;
                return new ObjectResult(new { msg = "Id da Casa De Show inválido!" });
            }

        }
        [HttpDelete("{id}")]
        public IActionResult Delete (int id) {
            if (id > 0) {
                try{
                    var events = database.Eventos.First (eve => eve.Id == id);
                    events.Status = false;
                    database.SaveChanges ();
                    return Ok();
                }catch(Exception e){
                    Response.StatusCode = 404;
                    return new ObjectResult(new { msg = "Evento não encontrado!" });
                }
            }else{
                Response.StatusCode = 400;
                return new ObjectResult(new { msg = "Id de Evento inválido!" });
            }   
            

        }
    }
} 
        

