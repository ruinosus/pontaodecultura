using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;

namespace PontaoCanavial.Models.VOs
{
    [Bind(Include = "Titulo,Preview,Corpo,ImagemPequena,ImagemMedia,ImagemGrande,PontoId")]
    public partial class Noticia
    {

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {

            if (String.IsNullOrEmpty(Titulo))
                yield return new RuleViolation("O Titulo é Necessário para o cadastro", "Titulo");

            if (String.IsNullOrEmpty(Preview))
                yield return new RuleViolation("O Preview é Necessário para o cadastro", "Preview");

            if (String.IsNullOrEmpty(Corpo))
                yield return new RuleViolation("O Corpo é Necessário para o cadastro", "Corpo");

            if ((PontoId) == 0)
                yield return new RuleViolation("O PontoId é Necessário para o cadastro", "PontoId");
            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        }

    }
}
