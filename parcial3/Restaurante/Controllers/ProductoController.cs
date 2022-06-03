using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;

        public ProductoController(ApplicationDbContext context,IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            _hostEnviroment = hostEnviroment;
        }

        // GET: Producto
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Productos.Include(p => p.Categoria);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Producto/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre");
            return View();
        }

        // POST: Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,IdCategoria,Cantidad,Descipcion,UrlImagen")] Producto producto)
        {
            /*
            if (ModelState.IsValid)
            {*/
                string rutaPrincipal =_hostEnviroment.WebRootPath;
                var archivos=HttpContext.Request.Form.Files;
                if(archivos.Count()>0){
                    string nombreArchivo = Guid.NewGuid().ToString();
                    var subidas= Path.Combine(rutaPrincipal,@"imagenes\productos\");
                    var extension=Path.GetExtension(archivos[0].FileName);
                    using(var fileStream = new FileStream(Path.Combine(subidas,nombreArchivo+extension), FileMode.Create)){
                            archivos[0].CopyTo(fileStream);

                    }
                    producto.UrlImagen=@"imagenes\productos\"+ nombreArchivo+extension;

                //}
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", producto.IdCategoria);
            return View(producto);
        }

        // GET: Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", producto.IdCategoria);
            return View(producto);
        }

        // POST: Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,IdCategoria,Cantidad,Descipcion,,UrlImagen")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            /*if (ModelState.IsValid){*/
                try
                {
                    string rutaPrincipal =_hostEnviroment.WebRootPath;
                    var archivos=HttpContext.Request.Form.Files;
                if(archivos.Count()>0){
                    Producto? productobd =await _context.Productos.FindAsync(id);
                    if(productobd!=null && productobd.UrlImagen!=null){
                        var rutaImagenActual =Path.Combine(rutaPrincipal,productobd.UrlImagen);
                        if(System.IO.File.Exists(rutaImagenActual)){
                            System.IO.File.Delete(rutaImagenActual);
                        }
                        _context.Entry(productobd).State=EntityState.Detached;


                    }
                    string nombreArchivo = Guid.NewGuid().ToString();
                    var subidas= Path.Combine(rutaPrincipal,@"imagenes\productos\");
                    var extension=Path.GetExtension(archivos[0].FileName);
                    using(var fileStream = new FileStream(Path.Combine(subidas,nombreArchivo+extension), FileMode.Create)){
                            archivos[0].CopyTo(fileStream);

                    }
                    producto.UrlImagen=@"imagenes\productos\"+ nombreArchivo+extension;
                    _context.Entry(producto).State =EntityState.Modified;
                }
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", producto.IdCategoria);
            return View(producto);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Productos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Productos'  is null.");
            }
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
          return (_context.Productos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
