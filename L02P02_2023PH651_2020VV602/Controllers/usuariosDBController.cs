using L02P02_2023PH651_2020VV602.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace L02P02_2023PH651_2020VV602.Controllers
{
    public class usuariosDBController : Controller
    {

        private readonly usuariosDB_DbContext _usuariosDB_DbContext;

        public usuariosDBController(usuariosDB_DbContext usuariosDB_DbContext)
        {
            _usuariosDB_DbContext = usuariosDB_DbContext;
        }


        public IActionResult Index()
        {

            var listaDeDepartamentos = (from d in _usuariosDB_DbContext.departamentos
                                     select d).ToList();
            ViewData["listadoDeDepartamentos"] = new SelectList(listaDeDepartamentos, "id", "departamento");

            var listaDePuestos = (from p in _usuariosDB_DbContext.puestos
                                        select p).ToList();
            ViewData["listadoDePuestos"] = new SelectList(listaDePuestos, "id", "puesto");

            var baseCompleta = (from cl in _usuariosDB_DbContext.clientes
                                  join dp in _usuariosDB_DbContext.departamentos on cl.id_departamento equals dp.id
                                  join p in _usuariosDB_DbContext.puestos on cl.id_puesto equals p.id
                                  select new
                                  {
                                      id_cliente = cl.id,
                                      nombre = cl.nombre,
                                      apellido = cl.apellido,
                                      email = cl.email,
                                      direccion = cl.direccion,
                                      genero = cl.genero,
                                      departamento = dp.departamento,
                                      puesto = p.puesto
                                  }).ToList();
            ViewData["base_Completa"] = baseCompleta;

            return View();
        }

        public IActionResult CrearCliente(clientes nuevoCliente)
        {
            nuevoCliente.url_imagen = "";
            _usuariosDB_DbContext.Add(nuevoCliente);
            _usuariosDB_DbContext.SaveChanges();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var clientes = await _usuariosDB_DbContext.clientes.FindAsync(id);
            if (clientes != null)
            {
                _usuariosDB_DbContext.clientes.Remove(clientes);
            }

            await _usuariosDB_DbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
