using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Cliente
    {
        internal static List<Cliente> buscarClientes(string filtro)
        {
            List<Cliente> misClientes = DAOCliente.getClientesQueCumplenCon(filtro);
            return misClientes; //.FindAll(c => c.fecha_baja.ha);
        }


        public decimal dni { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string mail { get; set; }

        public string telefono { get; set; }

        public string calle { get; set; }

        public string nro_piso { get; set; }

        public string depto { get; set; }

        public string localidad { get; set; }

        public string cod_postal { get; set; }

        public DateTime fecha_nac { get; set; }

        public DateTime ? fecha_baja { get; set; }

        internal int guardar()
        {
            return DAOCliente.guardar(this);
        }

        internal static bool existeClienteSegun(string p1, string p2)
        {
            return DAOCliente.existeClienteSegun(p1,p2);
        }
    }
}
