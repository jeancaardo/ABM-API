using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABM_API.Models;
using System.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Web;

namespace ABM_API.Controllers
{
    public class ContactoController : Controller
    { 

        public Contacto[] getAllContactos(Contacto[] contactos)
        {

            if (contactos != null)
            {

                return contactos;
            }
            else
            {
                return null;
            }
        }

        public Contacto[] eliminarContacto(Contacto c, Contacto[] contactos)
        {
            var listContactos = contactos.ToList();

            var index = listContactos.FindIndex(x => x.idContacto == c.idContacto);
            listContactos.Remove(listContactos[index]);

            return listContactos.ToArray();
        }

        public Contacto[] agregarContacto(Contacto c, Contacto[] contactos)
        {
            List<Contacto> listContactos = new List<Contacto>();

            if (contactos != null)
            {
                listContactos = contactos.ToList();
            }
            if(c.idContacto == 0)
            {
                if(listContactos.Count == 0)
                {
                    c.idContacto = 1;
                }
                else
                {
                    var aux = listContactos.Last();
                    c.idContacto = aux.idContacto + 1;
                }
                
                
                listContactos.Add(c);
            }
            else
            {
                var index = listContactos.FindIndex(x => x.idContacto == c.idContacto);
                listContactos[index] = c;
            }
            

            return listContactos.ToArray();
        }

        public Contacto[] modificarContacto(Contacto c, Contacto[] contactos)
        {
            var listContactos = contactos.ToList();

            

            return contactos;
        }
    }
}
