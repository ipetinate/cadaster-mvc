using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CadasterMVC.Extensions;
using CadasterMVC.Models;
using CadasterMVC.DAO;
using System.Net;

namespace CadasterMVC.Controllers
{
    public class PessoaController : Controller
    {
        [HttpGet]
        public IActionResult PessoaView()
        {
            PessoaDb pessoaDb = new PessoaDb();

            ViewBag.Pessoas = pessoaDb.ObterTodos();

            return View();
        }

        [HttpGet]
        public JsonResult ObterPessoa(long id)
        {
            PessoaDb pessoaDb = new PessoaDb();

            var pessoa = pessoaDb.ObterPorId(id);

            return Json(pessoa);
        }

        [HttpPost]
        public IActionResult InserirPessoa(PessoaViewModel pessoaViewModel)
        {
            Pessoa pessoaModel = PopularPessoa(pessoaViewModel);

            if (pessoaModel.IsNull()) new StatusCodeResult(412);
            PessoaDb pessoaDb = new PessoaDb();

            return !pessoaDb.Cadastrar(pessoaModel) ? new StatusCodeResult(500) : (IActionResult)Redirect("PessoaView");
        }

        private static Pessoa PopularPessoa(PessoaViewModel pessoaViewModel)
        {
            var pessoaModel = new Pessoa();

            if (pessoaViewModel.IsNull())
            {
                return null;
            }

            pessoaModel.Id = pessoaViewModel.Id;
            pessoaModel.Nome = pessoaViewModel.Nome;
            pessoaModel.Empresa = pessoaViewModel.Empresa;
            pessoaModel.Contato = pessoaViewModel.Contato;
            pessoaModel.DataCriacao = DateTime.Now;
            pessoaModel.DataAlteracao = DateTime.Now;

            return pessoaModel;
        }

        [HttpPost]
        public IActionResult AtualizarPessoa(PessoaViewModel pessoa)
        {
            Pessoa pessoaModel = PopularPessoa(pessoa);

            if (pessoaModel.IsNull()) new StatusCodeResult(412);
            PessoaDb pessoaDb = new PessoaDb();

            return !pessoaDb.Atualizar(pessoaModel.Id, pessoaModel) ?  new StatusCodeResult(500) : (IActionResult) Redirect("PessoaView");
        }

        [HttpPost]
        public IActionResult ExcluirPessoa(int id)
        {
            PessoaDb pessoaDb = new PessoaDb();

            pessoaDb.Excluir(id);

            return Redirect("PessoaVIew");
        }
    }
}