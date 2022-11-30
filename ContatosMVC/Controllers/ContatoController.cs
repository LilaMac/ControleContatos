using ContatosMVC.Data;
using ContatosMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContatosMVC.Controllers
{
    public class ContatoController : Controller
    {

        public IActionResult Index()
        {
            //return View();
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        //public IActionResult Criar()
        //{
        //    return View();
        //}
        public IActionResult Criar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }


        //[HttpPost]
        //public IActionResult Alterar(ContatoModel contato)
        //{

        //    _contatoRepositorio.Atualizar(contato);
        //    return RedirectToAction("Index");

        //}

        //[HttpPost]
        //public IActionResult Alterar(ContatoModel contato)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _contatoRepositorio.Atualizar(contato);
        //        return RedirectToAction("Index");
        //    }
        //    return View(contato);
        //}

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Atualizar(contato);
                return RedirectToAction("Index");
            }
            return View("Editar", contato);
        }

        public IActionResult Editar()
        {
            return View();
        }



        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        //public IActionResult ApagarConfirmacao()
        //{
        //    return View();
        //}

        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        //public IActionResult Apagar(int id)
        //{

        //    return RedirectToAction("Index");
        //}

        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

    }
}
