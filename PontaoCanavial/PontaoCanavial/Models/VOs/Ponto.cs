using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web.Mvc;


namespace PontaoCanavial.Models.VOs
{
    [Bind(Include = "Id,Nome,NomeIdentificador,DescricaoOficina,ImagemOficina,ApresentacaoProjeto,ObjetivoProjeto,EquipeProjeto,JustificativaProjeto,EPontao")]
    public partial class Ponto
    {
        
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {

            if (String.IsNullOrEmpty(Nome))
                yield return new RuleViolation("O nome é Necessário para o cadastro", "Nome");
            
            if (String.IsNullOrEmpty(NomeIdentificador))
                yield return new RuleViolation("O nome identificador é Necessário para o cadastro", "Nome");
            
            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Violação das regras, registro não salvo.");
        }
    }
}
