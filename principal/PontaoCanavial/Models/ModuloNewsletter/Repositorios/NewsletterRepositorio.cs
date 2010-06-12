using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using MySql.Data.MySqlClient;

namespace PontaoCanavial.Models.ModuloNewsletter.Repositorios
{
    public class NewsletterRepositorio : INewsletterRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Newsletter newsletter)
        {
            db.Newsletter.InsertOnSubmit(newsletter);
        }

        public void Excluir(Newsletter newsletter)
        {
            Newsletter newsletterAux = new Newsletter();
            newsletterAux.ID = newsletter.ID;
            List<Newsletter> resultado = this.Consultar(newsletterAux, TipoPesquisa.E);
            newsletterAux = resultado[0];

            db.Newsletter.DeleteOnSubmit(newsletterAux);
        }

        public void Alterar(Newsletter newsletter)
        {
            Newsletter newsletterAux = new Newsletter();
            newsletterAux.ID = newsletter.ID;
            List<Newsletter> resultado = this.Consultar(newsletterAux, TipoPesquisa.E);
            newsletterAux = resultado[0];


            newsletterAux = resultado[0];
            newsletterAux.Email = newsletter.Email;
           
            Confirmar();
        }

        public List<Newsletter> Consultar(Newsletter newsletter, TipoPesquisa tipoPesquisa)
        {
            List<Newsletter> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (newsletter.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == newsletter.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(newsletter.Email))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Email.Contains(newsletter.Email)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
						break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                       if (newsletter.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == newsletter.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(newsletter.Email))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Email.Contains(newsletter.Email)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
						break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Newsletter> Consultar()
        {
            return db.Newsletter.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public NewsletterRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}