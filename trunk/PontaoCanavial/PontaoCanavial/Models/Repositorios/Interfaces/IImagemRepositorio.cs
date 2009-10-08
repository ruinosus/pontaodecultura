using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;


namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IImagemRepositorio
    {
        IQueryable<Imagem> ConsultarTodos();
        Imagem GetImagem(int id);

        void Add(Imagem imagem);
        void Delete(Imagem imagem);

        void Save();
    }
}
