using System.Linq;
using CasaDeShow.Data;
using Microsoft.AspNetCore.Mvc;

namespace CasaDeShow.Controllers {
    public class UserController : Controller {
        private readonly ApplicationDbContext database;
        public UserController (ApplicationDbContext database) {
            this.database = database;
        }
        public ActionResult Historico () {
            return View ();
        }
        public ActionResult NovaVenda () {

            return View ();
        }
    }
}