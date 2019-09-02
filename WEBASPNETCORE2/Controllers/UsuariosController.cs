using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WEBASPNETCORE2.Models;
using WebPruebaEntities;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Reflection;

namespace WeWEBASPNETCORE2.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var list = new List<UsuariosViewModel>();
            UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();
            
           var usuarios = await client.ObtenerUsuariosAsync();

                list.AddRange(usuarios.Select(item => new UsuariosViewModel
                {
                    UsuId = item.UsuId,
                    UsuNombre = item.UsuNombre,
                    UsuPassword = item.UsuPassword
                }).ToList());
          
            return View(list);
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {   
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var UsuariosViewModel = new UsuariosViewModel();
            UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();


            List<Usuarios> objeto = await client.ObtenerUsuarioByIdAsync(id);

                if (objeto != null && objeto.Count>0)
                {
                    UsuariosViewModel.UsuId = objeto.First().UsuId;
                    UsuariosViewModel.UsuNombre = objeto.First().UsuNombre;
                    UsuariosViewModel.UsuPassword = objeto.First().UsuPassword;
                }

            return View(UsuariosViewModel);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuariosViewModel usuariosViewModel)
        {
            UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();
            
            
               await client.CrearUsuariosAsync(new Usuarios
                {
                    UsuId = usuariosViewModel.UsuId,
                    UsuNombre = usuariosViewModel.UsuNombre,
                    UsuPassword = usuariosViewModel.UsuPassword
                }
                );
            
            return RedirectToAction("Index");
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            var UsuariosViewModel = new UsuariosViewModel();

            UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();
  
             List<Usuarios> objeto = await client.ObtenerUsuarioByIdAsync(id);

                if (objeto != null)
                {
                    UsuariosViewModel.UsuId = objeto.First().UsuId;
                    UsuariosViewModel.UsuNombre = objeto.First().UsuNombre;
                    UsuariosViewModel.UsuPassword = objeto.First().UsuPassword;
                }
                else
                {
                    return StatusCode(StatusCodes.Status404NotFound);
                }

            return View(UsuariosViewModel);
        }

        // POST: Usuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit( UsuariosViewModel UsuariosViewModel)
        {
            if (ModelState.IsValid)
            {
                UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();
               
                  await client.ActualizarUsuariosAsync(new Usuarios
                  {
                      UsuId = UsuariosViewModel.UsuId,
                      UsuNombre = UsuariosViewModel.UsuNombre,
                      UsuPassword = UsuariosViewModel.UsuPassword
                  });
            }

            return RedirectToAction("Index");
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var UsuariosViewModel = new UsuariosViewModel();

            UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();
            List<Usuarios> objeto  = await client.ObtenerUsuarioByIdAsync(id);

                if (objeto != null)
                {
                    UsuariosViewModel.UsuId = objeto.First().UsuId;
                    UsuariosViewModel.UsuNombre = objeto.First().UsuNombre;
                    UsuariosViewModel.UsuPassword = objeto.First().UsuPassword;
                }
                else
                {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return View(UsuariosViewModel);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UsuariosService.UsuariosServiceClient client = new UsuariosService.UsuariosServiceClient();
            {
               await client.EliminarUsuariosAsync(id);
            }
            return RedirectToAction("Index");
        }

       
    }
}