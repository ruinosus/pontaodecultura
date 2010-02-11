using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloGaleria.Constantes;

namespace PontaoCanavial.Models.ModuloGaleria.Excecoes
{
    /// <summary>
    /// Classe GaleriaNaoAlteradaExcecao
    /// </summary>
    public class GaleriaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public GaleriaNaoAlteradaExcecao()
            : base(GaleriaConstantes.GALERIA_NAO_ALTERADA)
        { }
    }
}