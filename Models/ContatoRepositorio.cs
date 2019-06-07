using System;
using System.Collections.Generic;
using WebApi2_Contatos.Controllers;
using WebApi2_Contatos.Models;

namespace WebApi2_Contatos.Models
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private List<Contato> contatos = new List<Contato>();
        private int _nextId = 1;

        public ContatoRepositorio()
        {
            Add(new Contato { Nome = "Scorpion", TipoCanal = "email", Canal = "scorpion@mortalkombat.com", Descricao = "Melhor jogador" });
            Add(new Contato { Nome = "Noob", TipoCanal = "email", Canal = "noob@mortalkombat.com", Descricao = "Como seu nome diz, é um noob" });
            Add(new Contato { Nome = "Liu Kang", TipoCanal = "email", Canal = "liukang@mortalkombat.com", Descricao = "Guerreiro shaolin" });
            Add(new Contato { Nome = "Kenshi", TipoCanal = "email", Canal = "kenshi@mortalkombat.com", Descricao = "Ninja ceguinho" });
            Add(new Contato { Nome = "Quanchi", TipoCanal = "email", Canal = "quanchi@mortalkombat.com", Descricao = "Hipinotiza geral" });
            Add(new Contato { Nome = "Freddy Kruegger", TipoCanal = "email", Canal = "fredinho@mortalkombat.com", Descricao = "Jogador esquecido" });
            Add(new Contato { Nome = "Scarlet", TipoCanal = "email", Canal = "scarlet@mortalkombat.com", Descricao = "O+, joga sangue em geral" });
            Add(new Contato { Nome = "Reptile", TipoCanal = "email", Canal = "reptile@mortalkombat.com", Descricao = "Largato metido a besta" });
            Add(new Contato { Nome = "Sonya Blade", TipoCanal = "email", Canal = "sonya@mortalkombat.com", Descricao = "Melhor jogador" });
            Add(new Contato { Nome = "Jax Briggs", TipoCanal = "email", Canal = "jax@mortalkombat.com", Descricao = "Brasil acima de todos, Deus acima de tudo" });
        }

        public Contato Add(Contato item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            contatos.Add(item);
            return item;
        }

        public Contato Get(int id)
        {
            return contatos.Find(p => p.Id == id);
        }

        public IEnumerable<Contato> GetAll()
        {
            return contatos;
        }

        public void Remove(int id)
        {
            contatos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Contato item)
        {
            if( item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = contatos.FindIndex(p => p.Id == item.Id);

            if(index == -1)
            {
                return false;
            }
            contatos.RemoveAt(index);
            contatos.Add(item);
            return true;
        }

        public bool Update(ContatosController contato)
        {
            throw new NotImplementedException();
        }
    }
}