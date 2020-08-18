using apptotal.Models;
using BASE.entity;
using DAL.Filtro;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace apptotal.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            UsuarioFiltro filtro = new UsuarioFiltro();
            List<Usuario> lista = new UsuarioDAL().listaUsuario(filtro);
            ViewBag.message = "";
            ViewBag.mostrafiltro = "block"; 
            ViewBag.Lista = lista.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioViewModels model)
        {

            UsuarioFiltro filtro = new UsuarioFiltro();
            filtro.codigo = model.codigo;
            filtro.descricao = model.descricao;
            filtro.dtini = model.dtini;
            filtro.dtfim = model.dtfim;
            filtro.ID = model.ID;
            filtro.Nome = model.Nome;
            filtro.Dtnasc = model.Dtnasc;
            ViewBag.message = "";
            List<Usuario> lista = new UsuarioDAL().listaUsuario(filtro);
            ViewBag.Lista = lista.ToList();
            if (lista.Count > 0)
            {
                ViewBag.mostrafiltro = "none";
            }
            else
            {
                ViewBag.mostrafiltro = "block";
            }
            
            return View();
        }
    }
}