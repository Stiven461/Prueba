using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        public int Id_Afiliado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoIdentificacion { get; set; }
        public string TipoRegimen { get; set; }

        Eps ret = new Eps();

        public Paciente()
        {
        }

        public void Pasar_datos()
        {
            if (TipoRegimen == "Contributivo")
            {
                ret.Liquidacion_Cuota_Moderada_Contributivo(Id_Afiliado, Nombre, Apellido, TipoIdentificacion);
            }
            else
            {
                ret.Liquidacion_Cuota_Moderada_Subsidiado(Id_Afiliado, Nombre, Apellido, TipoIdentificacion);
            }
        }

    }
}
