using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloGaleria.Fabricas;
using PontaoCanavial.Models.ModuloGaleria.Repositorios;

namespace PontaoCanavial.Models.ModuloGaleria.Processos
{
    public class GaleriaProcesso :Singleton<GaleriaProcesso>, IGaleriaProcesso
    {
        #region Atributos
        private IGaleriaRepositorio galeriaRepositorio = null;
        #endregion

        #region Construtor
        public GaleriaProcesso()
        {
            galeriaRepositorio = GaleriaFabrica.IGaleriaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Galeria galeria)
        {
            try
            {
                this.galeriaRepositorio.Incluir(galeria);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Galeria galeria)
        {
            try
            {
                this.galeriaRepositorio.Excluir(galeria);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.galeriaRepositorio.Excluir(galeria);
        }

        public void Alterar(Galeria galeria)
        {
            this.galeriaRepositorio.Alterar(galeria);
        }

        public List<Galeria> Consultar(Galeria galeria, TipoPesquisa tipoPesquisa)
        {
            List<Galeria> galeriaList = this.galeriaRepositorio.Consultar(galeria, tipoPesquisa);

            return galeriaList;
        }

        public List<Galeria> Consultar()
        {
            List<Galeria> galeriaList = galeriaRepositorio.Consultar();

            return galeriaList;
        }

        public void Confirmar()
        {
            galeriaRepositorio.Confirmar();
        }

        #endregion
    }
       
}