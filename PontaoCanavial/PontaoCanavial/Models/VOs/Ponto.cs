using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web.Mvc;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.Repositorios;


namespace PontaoCanavial.Models.VOs
{
    [Bind(Include = "Nome,NomeIdentificador,EquipeProjeto,DescricaoOficina,ApresentacaoProjeto,ObjetivoProjeto,JustificativaProjeto")]
    public partial class Ponto
    {
        private IPontoRepositorio pontoRepositorio;

        public IPontoRepositorio PontoRepositorio
        {
            get
            {
                return this.pontoRepositorio;
            }
            set { this.pontoRepositorio = value; }
        }

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {

            if (String.IsNullOrEmpty(Nome))
                yield return new RuleViolation("O nome é Necessário para o cadastro", "Nome");

            if (String.IsNullOrEmpty(NomeIdentificador))
                yield return new RuleViolation("O nome identificador é Necessário para o cadastro", "NomeIdentificador");
            else
            {
                Ponto p = pontoRepositorio.ConsultarPorNomeIdentificador(NomeIdentificador);

                if (p != null)
                    yield return new RuleViolation("Nome identificador já informado, por favor informe outro.", "NomeIdentificador");
            }

            //validar nomeidentificador,minusculos e sem caracteres especiais
            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        }

    }
}
