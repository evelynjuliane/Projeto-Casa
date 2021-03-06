using System;
using System.Collections.Generic;
using System.Linq;
using CasaDeShow.Data;
using CasaDeShow.DTO;
using CasaDeShow.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaDeShow.Controllers
{
    [Route("api/v1/casas")]
    [ApiController]
    public class CasaShowsController : ControllerBase
    {
        private readonly ApplicationDbContext database;
        public CasaShowsController(ApplicationDbContext database){
            this.database = database;
        }
        //LIST
        [HttpGet]
        public IActionResult Get() {
            try{
                var casa = database.CasasShows.ToList ();
                return Ok(casa);
            }catch(Exception e){
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id){
            try{
               var casa = database.CasasShows.First(c => c.Id == id);
                return Ok(casa); 
            }catch(Exception e){
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
            
        }
        //Ordem Crescente PENDENTE
        [HttpGet("{action}")]
        public IActionResult asc(){
            List<String> list = new List<String>();
            List<CasaShow> list1 = new List<CasaShow>();

            var aux = database.CasasShows.ToList ();
            foreach(var item in aux){
               list.Add(item.Nome);
            }
            list.Sort();
           foreach(var item in list){
                var arm = database.CasasShows.First(c => c.Nome == item);
                list1.Add(arm);
            }
            return Ok(list1);
            
        }
        //Ordem Decrescente PENDENTE
        [HttpGet("{action}")]
        public IActionResult desc(){
            List<String> list = new List<String>();
            IList<CasaShow> list1 = new List<CasaShow>();

            var aux = database.CasasShows.ToList ();
            foreach(var item in aux){
               list.Add(item.Nome);
            }
            list.Sort();
           foreach(var item in list){
                var arm = database.CasasShows.First(c => c.Nome == item);
                //for (int i = 0 ; i =; i--){
                   // list1.Add(arm);
                //}
                    
            }
            return Ok(list1);
            
        }
            
        
        //Nome
        [HttpGet("{action}/{nome}")]
        public IActionResult nome(string nome){
            try
            {
                var casa = database.CasasShows.First(c => c.Nome == nome);
                return Ok(casa);
            }catch(Exception e){
                Response.StatusCode = 404;
                return new ObjectResult(new {msg = "O Nome não existe na lista."});
            }
            

        }
        //SAVE
        [HttpPost]
        public IActionResult Post([FromBody] CasaShowDTO clubTemporary){
            if(clubTemporary.Nome.Length <= 1){
                Response.StatusCode = 400;
                return new ObjectResult(new { msg = "O Nome deve ter mais de  1 caracter." });
            }
            if(clubTemporary.Local.Length <= 1){
                Response.StatusCode = 400;
                return new ObjectResult(new { msg = "O Local deve ter mais de  1 caracter." });
            }
                CasaShow club = new CasaShow();
                
                club.Nome = clubTemporary.Nome;
                club.Local = clubTemporary.Local;
                club.Status = true;
                
                database.CasasShows.Add(club);
                database.SaveChanges();
                
                Response.StatusCode = 201;
                return new ObjectResult("");
           
        }
        
        [HttpPatch]
        public IActionResult Patch ([FromBody] CasaShowDTO clubTemporary) {
           if(clubTemporary.Id > 0){
                try
                {
                    var club = database.CasasShows.First(cat => cat.Id == clubTemporary.Id);
                    if (clubTemporary != null){
                        club.Nome = clubTemporary.Nome;
                        club.Local = clubTemporary.Local;
                        database.SaveChanges ();
                        return Ok();
                    }else{
                        Response.StatusCode = 400;
                        return new ObjectResult(new { msg = "Casa De Show não encontrada!" });
                    }
                }catch (Exception e)
                {
                    Response.StatusCode = 400;
                    return new ObjectResult(new { msg = "Casa De Show não encontrada!" });
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
                    var club = database.CasasShows.First(cat => cat.Id == id);
                    club.Status = false;
                    database.SaveChanges();
                    return Ok();
                }catch(Exception e){
                    Response.StatusCode = 404;
                    return new ObjectResult(new { msg = "Casa De Show não encontrada!" });
                }
            }else{
                Response.StatusCode = 400;
                return new ObjectResult(new { msg = "Id de Casa De Show inválido!" });
            }   
        }
    }
}