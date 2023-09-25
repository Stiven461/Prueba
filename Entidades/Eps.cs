using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Eps
    {
        public Eps() { }
        public int Id_Paciente { get; set; }
        public int Id_Liquidacion { get; set; }
        public double Valor_Servico_Hospitalario { get; set; }
        public int Valor_Devengado { get; set; }
        public double Cuota_Moderada { get; set; }
        public double Tarifa { get; set; }
       


        public bool Liquidacion_Cuota_Moderada_Contributivo(int id_paciente, string nombre_paciente, string apellido_paciente, string tipo_identificacion_paciente)
        {
            id_paciente = Id_Paciente;
            
            if (Valor_Devengado < 2)
            {
                Tarifa = 0.15;
                Cuota_Moderada = Valor_Servico_Hospitalario * Tarifa;

                if (Cuota_Moderada > 250000)
                {
                    Cuota_Moderada = 250000;
                }
            }
            if (Valor_Devengado >= 2 || Valor_Devengado == 5)
            {
                Tarifa = 0.2;
                Cuota_Moderada = Valor_Servico_Hospitalario * Tarifa;

                if (Cuota_Moderada > 900000)
                {
                    Cuota_Moderada = 900000;
                }
            }
            if (Valor_Devengado > 6)
            {
                Tarifa = 0.25;
                Cuota_Moderada = Valor_Servico_Hospitalario * Tarifa;

                if (Cuota_Moderada > 1500000)
                {
                    Cuota_Moderada = 1500000;
                }
            }

            return false;
        }

        public bool Liquidacion_Cuota_Moderada_Subsidiado(int id_paciente, string nombre_paciente, string apellido_paciente, string tipo_identificacion_paciente)
        {
            Valor_Devengado = 0;
            Tarifa = 0.05;
            Cuota_Moderada = Valor_Servico_Hospitalario * Tarifa;

            if (Cuota_Moderada > 200000)
            {
                Cuota_Moderada = 200000;
            }

            return false;
        }
    }
}

