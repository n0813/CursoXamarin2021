using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiXamarin.Clases;
using WebApiXamarin.Models;

namespace WebApiXamarin.Controllers
{
    public class MarcaController : ApiController
    {

        // GET api/Marca
        public IEnumerable<MarcaCLS> Get()
        {
            using (DBPasajeContext db = new DBPasajeContext())
            {
                return db.Marca.Where(x => x.habilitado == true).Select(x => new MarcaCLS
                {
                    iidMarca = x.idMarca,
                    nombre = x.nombre,
                    descripcion = x.descripcion
                });
            }

        }


        // POST api/marca
        public int Post([FromBody] MarcaCLS oMarcaCLS)
        {
            int inResp = 0;
            try
            {
                using (DBPasajeContext db = new DBPasajeContext())
                {
                    if (oMarcaCLS.iidMarca == 0)
                    {
                        //insertar
                        Marca marca = new Marca();
                        marca.nombre = oMarcaCLS.nombre;
                        marca.descripcion = oMarcaCLS.descripcion;
                        marca.habilitado = true;
                        db.Marca.Add(marca);
                        inResp = db.SaveChanges(); //respuesta 1

                    }
                    else
                    {
                        //actualizar
                        Marca marca = db.Marca.Where(x => x.idMarca == oMarcaCLS.iidMarca).First();
                        marca.nombre = oMarcaCLS.nombre;
                        marca.descripcion = oMarcaCLS.descripcion;
                        inResp = db.SaveChanges();

                    }
                }
               
            }
            catch (Exception)
            {
                inResp = 0;
            }
            return 0;
        }


        // DELETE api/marca/5
        public int Delete(int id)
        {
            int inRes = 0;
            try
            {
                using (DBPasajeContext db = new DBPasajeContext())
                {

                    Marca marca = db.Marca.Where(x => x.idMarca == id).First();
                    marca.habilitado = false;
                    inRes = db.SaveChanges();
                }
            }
            catch (Exception)
            {

                inRes = 0;
            }
            return inRes;
        }



    }
}
