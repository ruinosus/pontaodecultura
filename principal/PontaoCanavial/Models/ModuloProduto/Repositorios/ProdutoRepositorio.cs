using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using MySql.Data.MySqlClient;

namespace PontaoCanavial.Models.ModuloProduto.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Produto produto)
        {
            db.Produto.InsertOnSubmit(produto);
        }

        public void Excluir(Produto produto)
        {
            Produto produtoAux = new Produto();
            produtoAux.ID = produto.ID;
            List<Produto> resultado = this.Consultar(produtoAux, TipoPesquisa.E);
            produtoAux = resultado[0];

            db.Produto.DeleteOnSubmit(produtoAux);
        }

        public void Alterar(Produto produto)
        {
            Produto produtoAux = new Produto();
            produtoAux.ID = produto.ID;
            List<Produto> resultado = this.Consultar(produtoAux, TipoPesquisa.E);
            produtoAux = resultado[0];


            produtoAux = resultado[0];
            produtoAux.Descricao = produto.Descricao;
            produtoAux.Nome = produto.Nome;
            produtoAux.CategoriaID = produto.CategoriaID;
			produtoAux.PontoID = produto.PontoID;
			produtoAux.UsuarioID = produto.UsuarioID;
			produtoAux.ImagemGrande = produto.ImagemGrande;
			produtoAux.ImagemMedia = produto.ImagemMedia;
			produtoAux.ImagemPequena = produto.ImagemPequena;

            Confirmar();
        }

        public List<Produto> Consultar(Produto produto, TipoPesquisa tipoPesquisa)
        {
            List<Produto> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (produto.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == produto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(produto.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(produto.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }  

                        if (!string.IsNullOrEmpty(produto.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(produto.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(produto.PontoID!=null && produto.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == produto.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
						
						if(produto.CategoriaID!=null && produto.CategoriaID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.CategoriaID == produto.CategoriaID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                         if (produto.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == produto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(produto.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(produto.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
                       
                        if (!string.IsNullOrEmpty(produto.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(produto.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(produto.PontoID!=null && produto.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == produto.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
						
						if(produto.CategoriaID!=null && produto.CategoriaID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.CategoriaID == produto.CategoriaID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Produto> Consultar()
        {
            return db.Produto.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ProdutoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}