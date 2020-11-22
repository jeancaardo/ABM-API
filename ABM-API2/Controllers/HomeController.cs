using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABM_API2.Controllers;
using ABM_API2.Models;

namespace ABM_API2.Controllers
{
    [Route("api/{controller}/{id}")]
    public class HomeController : Controller
    {
        // GET: api/<controller>
            [HttpGet]
            public Object GetAllContactos(Contacto[] contactos)
            {
            ContactoController c = new ContactoController();
            c.getAllContactos();
            return HttpContext.Application.Get("Hola");
        }

            // GET: api/<controller>
            /*[HttpPut]
            public Contacto[] putContactos(Contacto c, Contacto[] contactos)
            {
                ContactoController oContacto = new ContactoController();



                return oContacto.agregarContacto(c, contactos); ;
            }*/

            // GET: api/<controller>
            [HttpPut]
            public void UpdateContactos(int id, Contacto[] contactos)
            {
                ContactoController oContacto = new ContactoController();

                return;
            }

            // GET: api/<controller>
            [HttpDelete]
            public void DeleteContacto(int id, Contacto[] contactos)
            {
                ContactoController oContacto = new ContactoController();

                return;
            }
        }
    }