using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IBannerRepositorio
    {
        IQueryable<Banner> ConsultarTodos();        
        Banner ConsultarBanner();
        Banner GetBanner(int id);

        void Add(Banner banner);
        void Delete(Banner banner);

        void Save();
    }
}
