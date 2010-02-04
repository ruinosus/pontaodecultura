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
        //IQueryable<Ponto> ConsultarTodos(bool consultarApenasPontinhos);
        //Ponto ConsultarPorNomeIdentificador(string nomeIdentificador);
        //Ponto ConsultarPontao();
        //Ponto GetPonto(int id);
        ////PontoFormViewModel Buscar(PontoFormViewModel pfvm, string valor,int id);

        //void Add(Ponto ponto);
        //void Delete(Ponto ponto);

        //void Save();


        /// <summary>
        /// Método responsável por incluir um ponto no sistema.
        /// </summary>
        /// <param name="aluno">Objeto do tipo ponto a ser incluido.</param>
        void Incluir(Ponto ponto);

        /// <summary>
        /// Método responsável por excluir um ponto do sistema.
        /// </summary>
        /// <param name="aluno">Objeto do tipo ponto a ser excluido.</param>
        void Excluir(Ponto ponto);

        /// <summary>
        /// Método reponsável por alterar um ponto do sistema.
        /// </summary>
        /// <param name="aluno">Objeto do tipo ponto a ser alterado.</param>
        void Alterar(Ponto ponto);

        /// <summary>
        /// Método responsável por consultar pontos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="aluno">Objeto do tipo ponto que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os pontos cadastrados.</returns>
        List<Ponto> Consultar(Ponto ponto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os alunos cadastrados.</returns>
        List<Ponto> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}
