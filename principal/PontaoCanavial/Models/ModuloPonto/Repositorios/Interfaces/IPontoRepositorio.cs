using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloPonto.Repositorios
{
    public interface IPontoRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um ponto no sistema.
        /// </summary>
        /// <param name="ponto">Objeto do tipo ponto a ser incluido.</param>
        void Incluir(Ponto ponto);

        /// <summary>
        /// Método responsável por excluir um ponto do sistema.
        /// </summary>
        /// <param name="ponto">Objeto do tipo ponto a ser excluido.</param>
        void Excluir(Ponto ponto);

        /// <summary>
        /// Método reponsável por alterar um ponto do sistema.
        /// </summary>
        /// <param name="ponto">Objeto do tipo ponto a ser alterado.</param>
        void Alterar(Ponto ponto);

        /// <summary>
        /// Método responsável por consultar pontos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="ponto">Objeto do tipo ponto que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os pontos cadastrados.</returns>
        List<Ponto> Consultar(Ponto ponto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os pontos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os pontos cadastrados.</returns>
        List<Ponto> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}