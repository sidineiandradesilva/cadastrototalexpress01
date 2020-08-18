using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace apptotal.Models
{
    public class FiltroBasicoModel
    {
        public FiltroBasicoModel()
        {

        }

        [Display(Name = "Código:")]
        public String codigo { get; set; }
        [Display(Name = "Descrição:")]
        public String descricao { get; set; }
        [Display(Name = "Dt. inicial:")]
        public String dtini { get; set; }
        [Display(Name = "Dt. fim:")]
        public String dtfim { get; set; }
        [Display(Name = "Ativo:")]
        public String ativo { get; set; }
        
    }
}