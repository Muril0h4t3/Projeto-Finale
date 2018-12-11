using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Senai.Projeto.Final.Final.web.Mvc.Models;
using Senai.Projeto.Final.Final.web.Mvc.Repositorios;

namespace Senai.Projeto.Final.Final.web.Mvc.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                                            nome: form["nome"],
                                            email: form["email"],
                                            senha: form["senha"],
                                            dataNascimento: DateTime.Parse(form["dataNascimento"])
                                            );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);


            return View();
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.Login(form["email"], form["senha"]);

            if(usuario != null){
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                return RedirectToAction ("Cadastrar", "Transacao");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View ();
        }
    }
}