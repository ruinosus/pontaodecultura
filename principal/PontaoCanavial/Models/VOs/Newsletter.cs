using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;

namespace PontaoCanavial.Models.VOs
{
    [Bind(Include = "Id,PontoId,Email")]
    public partial class Newsletter
    {
        
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Email))
                yield return new RuleViolation("O E-mail é Necessário para o cadastro", "Email");

            //if (int.IsNullOrEmpty(PontoId))
            //    yield return new RuleViolation("O E-mail é Necessário para o cadastro", "Email"); 
            
            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        }
    }
}

