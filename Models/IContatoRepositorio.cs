using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi2_Contatos.Controllers;
using WebApi2_Contatos.Models;

namespace WebApi2_Contatos.Models
{
    public interface IContatoRepositorio
    {
        IEnumerable<Contato> GetAll();
        Contato Get(int id);
        Contato Add(Contato item);
        void Remove(int id);
        bool Update(Contato item);
        bool Update(ContatosController contato);
    }
}
