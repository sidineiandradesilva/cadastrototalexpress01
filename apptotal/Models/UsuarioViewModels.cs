using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apptotal.Models
{
    public class UsuarioViewModels : FiltroBasicoModel
    {
        [Display(Name = "ID do Usuário:")]
        public int ID { get; set; }
        [Display(Name = "Nome do Usuario:")]
        public string Nome { get; set; }
        [Display(Name = "Dt. nascimento:")]
        public DateTime Dtnasc { get; set; }
    }
}