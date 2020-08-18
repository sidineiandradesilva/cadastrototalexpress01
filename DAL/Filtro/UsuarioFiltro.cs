using System;


namespace DAL.Filtro
{
    public class UsuarioFiltro : FiltroBasico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Dtnasc { get; set; }

        public UsuarioFiltro()
        {

        }
    }
}
