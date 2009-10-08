using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;

namespace PontaoCanavial.Models.VOs
{
[Bind(Include = "Id,Nome,Email,Senha,Telefone")]
    public partial class Usuario
    {

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {

            if (String.IsNullOrEmpty(Nome))
                yield return new RuleViolation("O nome é Necessário para o cadastro", "Nome");

            if (String.IsNullOrEmpty(Email))
                yield return new RuleViolation("O Email é Necessário para o cadastro", "Email");

            if (String.IsNullOrEmpty(Senha))
                yield return new RuleViolation("O Email é Necessário para o cadastro", "Senha");

            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        }

    }
}
