using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostGetModel.Models;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaID = 1,
                Nome = "Cleyton Ferrari",
                Twitter = "@cleytonferrari"
            };
            
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            
            return View(pessoa);
        }
    }
}