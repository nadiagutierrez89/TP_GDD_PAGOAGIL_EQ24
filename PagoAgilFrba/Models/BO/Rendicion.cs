﻿using PagoAgilFrba.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Models.BO
{
    public class Rendicion
    {
        public decimal ? nro_rendicion { get; set; }

        public decimal porcentaje_comision { get; set; }

        public List<Factura> facturas { get; set; }

        public int cant_facturas_rendidas { get; set; }

        public decimal importe_total_rendicion { get; set; }

        public decimal importe_comision { get; set; }

        public DateTime fecha_rendicion { get; set; }

        public decimal cod_empresa { get; set; }


        internal int guardar()
        {
            return DAORendicion.guardar(this);
        }

        internal bool existeOtraRendicionEnElMes()
        {
            return DAORendicion.existeOtraRendicionEnElMes(this);
        }
    }
}
