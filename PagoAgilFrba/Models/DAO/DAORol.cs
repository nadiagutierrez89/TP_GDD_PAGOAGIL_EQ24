using PagoAgilFrba.Models.BO;
using PagoAgilFrba.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.DAO
{
    class DAORol
    {
        internal static List<Rol> getRolesDe(decimal cod_user)
        {
            List<Rol> rolesDe = new List<Rol>();
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@cod_user", cod_user));

            SqlDataReader lector = DBAcess.GetDataReader("MARGINADOS.sp_rolesDe", "SP", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.nombre_rol = (string)lector["nombre_rol"];
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    rolesDe.Add(unRol);
                }
                lector.Close();
            }
            return rolesDe;
        }

        public static List<Rol> buscarRoles()
        {
            List<Rol> roles = new List<Rol>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT R.cod_rol,R.nombre_rol,R.habilitado FROM MARGINADOS.Rol R", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    unRol.nombre_rol = (string)lector["nombre_rol"];
                    unRol.habilitado = (bool)lector["habilitado"];
                    roles.Add(unRol);
                }
                lector.Close();
            }
            return roles;
        }

        public static int altaLogica(Rol rol)
        {
            try
            {
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@cod_rol", rol.cod_rol));
                return DBAcess.WriteInBase("UPDATE MARGINADOS.Rol SET Rol.habilitado=1  WHERE Rol.cod_rol=@cod_rol", "T", paramList);
            }
            catch
            {
                return 0;
            }

        }

        public static int bajaLogica(Rol rol)
        {
            try
            {
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@cod_rol", rol.cod_rol));
                return DBAcess.WriteInBase("UPDATE MARGINADOS.Rol SET Rol.habilitado=0  WHERE Rol.cod_rol=@cod_rol", "T", paramList);
            }
            catch
            {
                return 0;
            }


        }

        public static Rol crearRol(Rol r)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            parameterList.Add(new SqlParameter("@nombre_rol", r.nombre_rol));

            try
            {
                DBAcess.WriteInBase("INSERT INTO MARGINADOS.Rol (Rol.nombre_rol,Rol.habilitado) " +
                                                    " VALUES (@nombre_rol,1)", "T", parameterList);
            }
            catch
            {
                return null;
            }

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@nombre_rol", r.nombre_rol));

            List<Rol> roles = new List<Rol>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT R.cod_rol,R.nombre_rol,R.habilitado FROM MARGINADOS.Rol R WHERE R.nombre_rol=@nombre_rol", "T", param);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    unRol.nombre_rol = (string)lector["nombre_rol"];
                    unRol.habilitado = (bool)lector["habilitado"];
                    roles.Add(unRol);
                }
                lector.Close();
            }
            return roles[0];
        }

        public static bool existeNombreRol(string nombreRol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre_rol", nombreRol));
            List<Rol> roles = new List<Rol>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT * FROM MARGINADOS.Rol R WHERE R.nombre_rol=@nombre_rol", "T", parametros);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Rol unRol = new Rol();
                    unRol.cod_rol = (decimal)lector["cod_rol"];
                    unRol.nombre_rol = (string)lector["nombre_rol"];
                    unRol.habilitado = (bool)lector["habilitado"];
                    roles.Add(unRol);
                }
                lector.Close();
            }
            return roles.Count >= 1;
        }

        public static List<Funcionalidad> obtenerFuncionalidades(string nombreAnteriorRol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre_rol", nombreAnteriorRol));
            List<Funcionalidad> func = new List<Funcionalidad>();
            SqlDataReader lector = DBAcess.GetDataReader("SELECT F.cod_funcionalidad,F.nombre_func FROM MARGINADOS.Funcionalidad F ,MARGINADOS.Rol R , MARGINADOS.RolFuncionalidad RF WHERE R.nombre_rol=@nombre_rol AND RF.cod_funcionalidad=F.cod_funcionalidad ", "T", parametros);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.cod_funcionalidad = (decimal)lector["cod_funcionalidad"];
                    funcionalidad.nombre_func = (string)lector["nombre_func"];
                    func.Add(funcionalidad);
                }
                lector.Close();
            }
            return func;
        }

        internal static int cambiarNombre(Rol rol, string nombreViejoRol)
        {
            try
            {
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@nom_ant", nombreViejoRol));
                paramList.Add(new SqlParameter("@nombre_rol", rol.nombre_rol));
                return DBAcess.WriteInBase("UPDATE MARGINADOS.Rol SET Rol.nombre_rol=@nombre_rol WHERE Rol.nombre_rol=@nom_ant", "T", paramList);
            }
            catch
            {
                return 0;
            }


        }


        internal static int getLastIdRol()
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            int id = 0;

            SqlDataReader lector = DBAcess.GetDataReader("select IDENT_CURRENT('MARGINADOS.Rol') as id", "T", paramList);
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    id = (int)lector["id"];
                }
            }

            return id;
        }

        public static int update(Rol rol)
        {
            try
            {
                List<SqlParameter> ListaParametros = new List<SqlParameter>();

                ListaParametros.Add(new SqlParameter("@cod_rol", rol.cod_rol));
                ListaParametros.Add(new SqlParameter("@nombre_rol", rol.nombre_rol));
                ListaParametros.Add(new SqlParameter("@habilitado", rol.habilitado));

                return DBAcess.WriteInBase("update MARGINADOS.Rol set nombre_rol=@nombre_rol, habilitado=@habilitado where cod_rol = @cod_rol ", "T", ListaParametros);
            }
            catch { return 0; }
        }

    }
}
