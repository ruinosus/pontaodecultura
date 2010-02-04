using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloPonto.Repositorios;
using PontaoCanavial.Models.ModuloBasico.Enums;

    [Bind(Include = "Nome,NomeIdentificador,Objetivo,Justificativa,Logo,Equipe,Apresentacao,Contato,ImagemPequena,ImagemMedia,ImagemGrande")]
    public partial class Ponto
    {
        #region Atributos
        private bool editando; 
        #endregion

        #region Propriedades
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public bool Editando
        {
            get { return editando; }
            set { editando = value; }
        } 
        #endregion

        #region Eventos
        public IEnumerable<RuleViolation> GetRuleViolations()
        {

            if (String.IsNullOrEmpty(Nome))
                yield return new RuleViolation("O nome é Necessário para o cadastro", "Nome");

            if (String.IsNullOrEmpty(NomeIdentificador))
                yield return new RuleViolation("O nome identificador é Necessário para o cadastro", "NomeIdentificador");
            else
            {
                if (!this.Editando)
                {
                    PontoRepositorio repositorio = PontoRepositorio.Instance;
                    Ponto p = new Ponto();
                    p.NomeIdentificador = this.NomeIdentificador;

                    List<Ponto> resultado = repositorio.Consultar(p, TipoPesquisa.E);

                    if (resultado.Count > 0)
                        yield return new RuleViolation("Nome identificador já informado, por favor informe outro.", "NomeIdentificador");
                }
            }

            //validar nomeidentificador,minusculos e sem caracteres especiais
            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        } 
        #endregion

    }

