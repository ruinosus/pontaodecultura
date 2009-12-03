using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;

namespace PontaoCanavial.Models.VOs
{
    [Bind(Include = "Nome,Descricao,ImagemPequena,ImagemMedia,ImagemGrande,PontoId")]

    public partial class Projeto
    {
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {

            if (String.IsNullOrEmpty(Nome))
                yield return new RuleViolation("O Nome é Necessário para o cadastro", "Nome");

            if (String.IsNullOrEmpty(Descricao))
                yield return new RuleViolation("O Descricao é Necessário para o cadastro", "Descricao");

            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        }
    }
}
