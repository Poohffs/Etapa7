using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using etapa3.Models;


namespace etapa3.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Contato novoContato)
        {
        
            ContatoBD.Incluir(novoContato);
            
            ViewBag.nome = novoContato.nome;
            ViewBag.email = novoContato.email;
            ViewBag.mensagem = novoContato.mensagem;



            return View("Confirmacao");
        }
        
         public IActionResult QuemSomos()
        {
            return View();
        }
         public IActionResult Servicos()
        {
            return View();
        }
        
        public IActionResult Enviar()
        {
           
            if(HttpContext.Session.GetInt32("Contato") != 1) 
            {
                return RedirectToAction("Confimacao", "Home");
            }

            return View();
        }

        
        [HttpPost]
        public IActionResult Enviar(Contato contato)
        {
            ContatoBD.Incluir(contato);
            //ViewBag.contato = "Cadastro concluído com sucesso!";
            ViewBag.nome = contato.nome;
            ViewBag.email = contato.email;
            ViewBag.mensagem = contato.mensagem;
            
            return View("Confirmacao");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
