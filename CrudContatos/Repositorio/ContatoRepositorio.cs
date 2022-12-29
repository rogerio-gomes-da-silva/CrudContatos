﻿using CrudContatos.Data;
using CrudContatos.Models;
using Microsoft.IdentityModel.Tokens;

namespace CrudContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _context;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //gravar no banco de dados
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }
    }
}