using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;

namespace PontaoCanavial.Models.ModuloPonto.Repositorios
{
    public class PontoRepositorio : IPontoRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Ponto ponto)
        {
            db.Ponto.InsertOnSubmit(ponto);
        }

        public void Excluir(Ponto ponto)
        {
            Ponto pontoAux = new Ponto();
            pontoAux.ID = ponto.ID;
            List<Ponto> resultado = this.Consultar(pontoAux, TipoPesquisa.E);
            pontoAux = resultado[0];

            db.Ponto.DeleteOnSubmit(pontoAux);
        }

        public void Alterar(Ponto ponto)
        {
            Ponto pontoAux = new Ponto();
            pontoAux.ID = ponto.ID;
            List<Ponto> resultado = this.Consultar(pontoAux, TipoPesquisa.E);
            pontoAux = resultado[0];


            pontoAux = resultado[0];
            pontoAux.Apresentacao = ponto.Apresentacao;
            pontoAux.Cabecalho = ponto.Cabecalho;
            pontoAux.Contato = ponto.Contato;
            pontoAux.EPontao = ponto.EPontao;
            pontoAux.Equipe = ponto.Equipe;
            pontoAux.ImagemGrande = ponto.ImagemGrande;
            pontoAux.ImagemMedia = ponto.ImagemMedia;
            pontoAux.ImagemPequena = ponto.ImagemPequena;
            pontoAux.Justificativa = ponto.Justificativa;
            pontoAux.Logo = ponto.Logo;
            pontoAux.Nome = ponto.Nome;
            pontoAux.NomeIdentificador = ponto.NomeIdentificador;
            pontoAux.Objetivo = ponto.Objetivo;

            Confirmar();
        }

        public List<Ponto> Consultar(Ponto ponto, TipoPesquisa tipoPesquisa)
        {
            List<Ponto> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (ponto.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == ponto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Apresentacao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Apresentacao.Contains(ponto.Apresentacao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Contato))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Contato.Contains(ponto.Contato)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (ponto.EPontao.HasValue)
                        {

                            resultado = ((from p in resultado
                                          where
                                            p.EPontao.HasValue && p.EPontao.Value == ponto.EPontao
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Equipe))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Equipe.Contains(ponto.Equipe)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Justificativa))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Justificativa.Contains(ponto.Justificativa)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(ponto.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Objetivo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Objetivo.Contains(ponto.Objetivo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
                        break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (ponto.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == ponto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Apresentacao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Apresentacao.Contains(ponto.Apresentacao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Contato))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Contato.Contains(ponto.Contato)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (ponto.EPontao.HasValue)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                            p.EPontao.HasValue && p.EPontao.Value == ponto.EPontao
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Equipe))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Equipe.Contains(ponto.Equipe)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Justificativa))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Justificativa.Contains(ponto.Justificativa)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(ponto.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(ponto.Objetivo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Objetivo.Contains(ponto.Objetivo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Ponto> Consultar()
        {
            return db.Ponto.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public PontoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}
