﻿using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeDrop.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuarios.ToListAsync();
            return View(dados);
        }

        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("HomePageDoador");
            }

            return View();
        }

        public IActionResult CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }

            return View();
        }

        /*
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Usuarios.FindAsync(id);

            if (id == null)
                return NotFound();
            
            return View(dados);
        }


        /*
        public IActionResult RecuperarSenha()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RecuperarSenha(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }*/
    }
}
