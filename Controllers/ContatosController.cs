using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2_Contatos.Models;

namespace WebApi2_Contatos.Controllers
{
    public class ContatosController : ApiController
    {
        static readonly IContatoRepositorio repositorio = new ContatoRepositorio();

        public IEnumerable<Contato> GetAllContatos()
        {
            return repositorio.GetAll();
        }

        public Contato GetContato(int id)
        {
            Contato item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }


        public HttpResponseMessage PostContato(Contato item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Contato>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutContato(int id, Contato contato)
        {
            contato.Id = id;
            if (repositorio.Update(contato))
            {
                return;
            }
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        public void DeleteContato(int id)
        {
            Contato item = repositorio.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }
    }
}
