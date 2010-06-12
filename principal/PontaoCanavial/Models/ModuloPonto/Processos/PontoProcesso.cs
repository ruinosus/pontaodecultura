using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloPonto.Fabricas;
using PontaoCanavial.Models.ModuloPonto.Repositorios;
using PontaoCanavial.Models.ModuloPonto.VOs;

namespace PontaoCanavial.Models.ModuloPonto.Processos
{
    public class PontoProcesso : Singleton<PontoProcesso>, IPontoProcesso
    {
        #region Atributos
        private IPontoRepositorio pontoRepositorio = null;
        #endregion

        #region Construtor
        public PontoProcesso()
        {
            pontoRepositorio = PontoFabrica.IPontoInstance;
        }



        #endregion


        #region Métodos da Interface

        public void Incluir(Ponto ponto)
        {
            try
            {
                this.pontoRepositorio.Incluir(ponto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Ponto ponto)
        {
            try
            {
                this.pontoRepositorio.Excluir(ponto);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.pontoRepositorio.Excluir(ponto);
        }

        public void Alterar(Ponto ponto)
        {
            this.pontoRepositorio.Alterar(ponto);
        }

        public List<Ponto> Consultar(Ponto ponto, TipoPesquisa tipoPesquisa)
        {
            List<Ponto> pontoList = this.pontoRepositorio.Consultar(ponto, tipoPesquisa);

            return pontoList;
        }

        public List<Ponto> Consultar()
        {
            List<Ponto> pontoList = pontoRepositorio.Consultar();

            return pontoList;
        }

        public PontoFormViewModel MontarPontoFormViewModel(Ponto ponto, TipoPesquisa tipoPesquisa)
        {
            List<Ponto> pontoList = this.pontoRepositorio.Consultar(ponto, tipoPesquisa);

            return null ;
        }

        public void Confirmar()
        {
            pontoRepositorio.Confirmar();
        }

        #endregion
    }


}
