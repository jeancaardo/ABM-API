using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using System.Web.Mvc;
using ABM_API2.Models;

namespace ABM_API2.Controllers
{
    public class ContactoController : Controller
    {

        public void getAllContactos()
        {
            HttpContext.Session.Add("Hola", 2);
            
        }

        /* public Contacto[] eliminarContacto(int id, Contacto[] contactos)
        {
            foreach(Contacto c in contactos)
            {
                if (c.idContacto == id)
                {
                    contactos
                }
            }
            HttpContext.current.cache
            return crearArray(dt);
        }

        public Contacto[] agregarContacto(Contacto c, Contacto[] contactos)
        {
            if(dt.Rows.Count == 0)
            {
                inicializarDataTable(dt);
            }

            if (c != null)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = c.idContacto;
                dr["nombre"] = c.idContacto;
                dr["apellido"] = c.idContacto;
                dr["direccion"] = c.idContacto;
                dt.Rows.Add(dr);
            }

            return crearArray(dt);
        }

        public Contacto[] modificarContacto(Contacto c, DataTable dt)
        {
                foreach (DataRow row in dt.Rows)
                {
                    if (row.Field<int>("id") == c.idContacto)
                    {
                    
                        
                            dt.Rows.Remove(row);
                            dt.AcceptChanges();


                    DataRow dr = dt.NewRow();
                    dr["id"] = c.idContacto;
                    dr["nombre"] = c.idContacto;
                    dr["apellido"] = c.idContacto;
                    dr["direccion"] = c.idContacto;
                    dt.Rows.Add(dr);
                    }
                }

            return crearArray(dt);
        }*/
    }
}
