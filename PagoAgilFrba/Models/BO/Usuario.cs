using PagoAgilFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Usuario
    {
        public string username { get; set; }
        public string pass { get; set; }
        public bool habilitado { get; set; }
        public decimal nro_intentos { get; set; }


        internal void ReiniciarFallidos()
        {  
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@nombre", username));
            DBAcess.WriteInBase("UPDATE MARGINADOS.Usuario SET nro_intentos=0 WHERE username=@nombre", "T", paramList);
        }
           
        
            internal void ActualizarFallidos()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@intentos_login", nro_intentos + 1));
            paramList.Add(new SqlParameter("@nombre", username));
            DBAcess.ExecStoredProcedure("MARGINADOS.ActualizaIntentos", paramList);
          }
    }
}
