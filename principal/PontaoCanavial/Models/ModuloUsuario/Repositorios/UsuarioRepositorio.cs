using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloUsuario.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Usuario usuario)
        {
            db.Usuario.InsertOnSubmit(usuario);
        }

        public void Excluir(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario();
            usuarioAux.ID = usuario.ID;
            List<Usuario> resultado = this.Consultar(usuarioAux, TipoPesquisa.E);
            usuarioAux = resultado[0];

            db.Usuario.DeleteOnSubmit(usuarioAux);
        }

        public void Alterar(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario();
            usuarioAux.ID = usuario.ID;
            List<Usuario> resultado = this.Consultar(usuarioAux, TipoPesquisa.E);
            usuarioAux = resultado[0];


            usuarioAux = resultado[0];
            usuarioAux.Login = usuario.Login;
            usuarioAux.Nome = usuario.Nome;
			usuarioAux.Senha = usuario.Senha;
			usuarioAux.PKID = usuario.PKID;			

            Confirmar();
        }

        public List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa)
        {
            List<Usuario> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (usuario.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == usuario.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(usuario.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(usuario.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }  

                        if (!string.IsNullOrEmpty(usuario.Login))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Login.Equals((usuario.Login))
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if (!string.IsNullOrEmpty(usuario.Senha))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Senha.Equals((usuario.Senha))
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if (!string.IsNullOrEmpty(usuario.PKID))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.PKID.Equals((usuario.PKID))
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
										
						
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (usuario.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == usuario.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(usuario.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(usuario.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }  

                        if (!string.IsNullOrEmpty(usuario.Login))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Login.Equals((usuario.Login))
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if (!string.IsNullOrEmpty(usuario.Senha))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Senha.Equals((usuario.Senha))
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if (!string.IsNullOrEmpty(usuario.PKID))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.PKID.Equals((usuario.PKID))
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }					
						
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Usuario> Consultar()
        {
            return db.Usuario.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public UsuarioRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}