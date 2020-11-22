using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ABM_API.Models;
using ABM_API.Controllers;
using System.Data;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABM_API.Views
{   
    [Microsoft.AspNetCore.Authorization.AllowAnonymous]
    [Route("api/contacto")]
    public class ContactoView : Controller
    {
        // GET: api/<controller>
        [HttpGet("getAllContactos")]
        public Contacto[] GetAllContactos([FromBody]DataTypeContactos contactos)
        {
            ContactoController oContacto = new ContactoController();


            return oContacto.getAllContactos( contactos.contactoArray);
        }

        // GET: api/<controller>
        [HttpPut("putContacto/")]
        public Contacto[] putContactos([FromBody]DataTypeContactos contactos)
        {
            ContactoController oContacto = new ContactoController();

            

            return oContacto.agregarContacto(contactos.contacto, contactos.contactoArray); ;
        }

        // GET: api/<controller>
        [HttpPut("modifyContacto")]
        public void UpdateContactos([FromBody]DataTypeContactos contactos)
        {
            ContactoController oContacto = new ContactoController();

            return;
        }

        // GET: api/<controller>
        [HttpPut("deleteContacto")]
        public Contacto[] DeleteContacto([FromBody]DataTypeContactos contactos)
        {
            ContactoController oContacto = new ContactoController();

            return oContacto.eliminarContacto(contactos.contacto, contactos.contactoArray);
        }
    }
}
