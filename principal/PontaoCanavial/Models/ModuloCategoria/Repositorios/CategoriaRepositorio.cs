using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloCategoria.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region M�todos da Interface

        public void Incluir(Categoria categoria)
        {
            db.Categoria.InsertOnSubmit(categoria);
        }

        public void Excluir(Categoria categoria)
        {
            Categoria categoriaAux = new Categoria();
            categoriaAux.ID = categoria.ID;
            List<Categoria> resultado = this.Consultar(categoriaAux, TipoPesquisa.E);
            categoriaAux = resultado[0];

            db.Categoria.DeleteOnSubmit(categoriaAux);
        }

        public void Alterar(Categoria categoria)
        {
            Categoria categoriaAux = new Categoria();
            categoriaAux.ID = categoria.ID;
            List<Categoria> resultado = this.Consultar(categoriaAux, TipoPesquisa.E);
            categoriaAux = resultado[0];


            categoriaAux = resultado[0];
            categoriaAux.Descricao = categoria.Descricao;
           
            Confirmar();
        }

        public List<Categoria> Consultar(Categoria categoria, TipoPesquisa tipoPesquisa)
        {
            List<Categoria> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (categoria.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == categoria.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(categoria.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(categoria.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
						break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                       if (categoria.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == categoria.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(categoria.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(categoria.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
						break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Categoria> Consultar()
        {
            return db.Categoria.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public CategoriaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}