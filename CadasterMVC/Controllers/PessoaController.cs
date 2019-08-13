using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CadasterMVC.Models;
using CadasterMVC.DAO;

namespace CadasterMVC.Controllers
{
    public class PessoaController : Controller
    {
        [HttpGet]
        public IActionResult PessoaView()
        {
            var conn = new Connection();
            var pessoas = conn.ConnectionSql();

            return ViewBag(pessoas);
        }

        [HttpPost]
        public IActionResult InserirPessoa(PessoaViewModel pessoa)
        {
            return View();
        }

        [HttpPut]
        public IActionResult AtualizarPessoa(PessoaViewModel pessoa)
        {
            return View();
        }

        [HttpDelete]
        public IActionResult ExcluirPessoa(int id)
        {
            return View();
        }
    }
}