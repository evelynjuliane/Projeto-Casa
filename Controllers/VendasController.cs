using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CasaDeShow.Data;
using CasaDeShow.DTO;
using CasaDeShow.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CasaDeShow.Controllers {
    public class VendasController : Controller {

        private readonly ApplicationDbContext database;
         private readonly UserManager<IdentityUser> _userManager;
        public VendasController (ApplicationDbContext database, UserManager<IdentityUser> userManager) {
            this.database = database;
            _userManager = userManager;

        }

        [HttpPost]
          public async Task<IActionResult> Exibir(int id){
            var user = await _userManager.GetUserAsync(User);
            VendaDTO compra = new VendaDTO ();
                var evento = database.Eventos.Include (e => e.CasaShow).First (e => e.Id == id);
              
                compra.Nome = evento.Nome;
                compra.QuantidadeDeIngressos = evento.QuantDeIngressos;
                compra.Data = evento.Data;
                compra.Preco = evento.ValorDoIngresso;
                compra.CasaShowID = evento.CasaShow.Id;
                compra.CategoriaID = evento.Categoria.Id;
                compra.Img = evento.img;
                compra.QuantidadeComprada = compra.QuantidadeComprada;
                compra.User = user.NormalizedUserName;
                ViewBag.CasaDeShow = database.CasasShows.Where (p => p.Status == true).ToList ();
                ViewBag.Categorias = database.Categorias.Where (p => p.Status == true).ToList ();
                compra.Status = true;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Salvar (VendaDTO compra) {
            var user = await _userManager.GetUserAsync(User);
            

            if (ModelState.IsValid) {
                Venda venda = new Venda ();
                venda.Nome = compra.Nome;
                venda.QuantidadeDeIngressos = compra.QuantidadeDeIngressos;
                venda.Data = compra.Data;
                venda.ValorDeIngressos = compra.Preco;
                venda.CasaShow = database.CasasShows.First (casadeshow => casadeshow.Id == compra.CasaShowID);
                venda.Categoria = database.Categorias.First(cat => cat.Id == compra.CategoriaID);
                venda.User = user.NormalizedUserName;
                database.Vendas.Add (venda);
                database.SaveChanges ();
                ViewBag.CasasShow = database.CasasShows.ToList ();
                return RedirectToAction ("Admin", "Index");

            } else {
                ViewBag.CasasShow = database.CasasShows.Where (p => p.Status == true).ToList ();
                return View ("../Admin/Index");
            }

        }

    }
}