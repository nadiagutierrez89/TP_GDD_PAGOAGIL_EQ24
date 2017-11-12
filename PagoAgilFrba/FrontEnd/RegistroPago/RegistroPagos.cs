﻿using PagoAgilFrba.FrontEnd.AbmCliente;
using PagoAgilFrba.FrontEnd.ABMFactura;
using PagoAgilFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PagoAgilFrba.FrontEnd.RegistroPago
{
    public partial class RegistroPagos : Form
    {
        private Usuario usuarioLogueado;
        private List<Factura> factuasPagar = new List<Factura>();
        private List<MedioDePago> mediosDePagosDelPago = new List<MedioDePago>();
        private Cliente clientePagador;
        private DateTime hoy = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);

        public RegistroPagos()
        {
            InitializeComponent();

        }

        public RegistroPagos(Usuario usuarioLogueado)
            : this()
        {
            this.usuarioLogueado = usuarioLogueado;
            this.tbUser.Text = usuarioLogueado.username;
            this.tbSucursal.Text = usuarioLogueado.socursalActual.codigo_postal_suc + " - " + usuarioLogueado.socursalActual.nombre_suc;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registropago_but_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturas winform = new Facturas(factuasPagar);
            winform.ShowDialog();
            this.registroPago_dgv_listado.DataSource = null;
            this.registroPago_dgv_listado.DataSource = factuasPagar;
            this.actualizarTotalDePago();
            this.Show();
        }

        private void actualizarTotalDePago()
        {
            this.tbTotal.Text = factuasPagar.Sum(f => f.importe_total_fac).ToString();
            this.tbTotalMediosDePago.Text = mediosDePagosDelPago.Sum(m => m.importe).ToString();
        }

        private bool ItemSelccionado(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count != 0;
        }

        private void bttnQuitar_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.registroPago_dgv_listado))
            {
                Factura fact_a_borrar = (Factura)this.registroPago_dgv_listado.CurrentRow.DataBoundItem;

                factuasPagar.Remove(fact_a_borrar);

                this.registroPago_dgv_listado.DataSource = null;
                this.registroPago_dgv_listado.DataSource = factuasPagar;

                this.actualizarTotalDePago();
            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }

        private void bttnSeleccionCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes winform = new Clientes(clientePagador);
            winform.ShowDialog();
            clientePagador = winform.clientePagador;

            if(clientePagador != null)
                this.tbCliente.Text = clientePagador.nombre + " " + clientePagador.apellido + " " + clientePagador.dni;
            this.Show();

        }

        private void registropago_but_pagar_Click(object sender, EventArgs e)
        {
            if (this.factuasPagar.Count < 1)
            {
                MessageBox.Show("No se seleccionaron facturas a pagar", "Error!", MessageBoxButtons.OK);
                return;
            }

            if (this.clientePagador == null)
            {
                MessageBox.Show("Seleccionar algun cliente", "Error!", MessageBoxButtons.OK);
                return;
            }

            Pago unPago = new Pago();
            unPago.facturas = this.factuasPagar;
            unPago.mediosDePago = this.mediosDePagosDelPago;
            unPago.fecha_pago = hoy;
            unPago.dni_cliente = this.clientePagador.dni;
            unPago.importe_total_pago = unPago.importe_total();
            unPago.codigo_postal_suc = this.usuarioLogueado.socursalActual.codigo_postal_suc;
            unPago.cod_user = this.usuarioLogueado.cod_user;


            if (unPago.importe_total_pago != unPago.importe_total_mediosDePago())
            {
                MessageBox.Show("Monto total de facturas no es igual al monto total medios de pago", "Error!", MessageBoxButtons.OK);
                return;
            }

            if (unPago.guardar() > 0)
            {
                MessageBox.Show("Se han guardado los cambios.", ":o)", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios!", ":o(", MessageBoxButtons.OK);
            }

            this.Close();

        }

        private void bttnAgregarFormaPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            MediosDePago winform = new MediosDePago(mediosDePagosDelPago);
            winform.ShowDialog();
            this.dgvMediosDePago.DataSource = null;
            this.dgvMediosDePago.DataSource = mediosDePagosDelPago;
            this.actualizarTotalDePago();
            this.Show();

        }

        private void bttnQuitarFormaPago_Click(object sender, EventArgs e)
        {
            if (this.ItemSelccionado(this.dgvMediosDePago))
            {
                MedioDePago medioDePago_a_borrar = (MedioDePago)this.dgvMediosDePago.CurrentRow.DataBoundItem;

                mediosDePagosDelPago.Remove(medioDePago_a_borrar);

                this.dgvMediosDePago.DataSource = null;
                this.dgvMediosDePago.DataSource = mediosDePagosDelPago;

                this.actualizarTotalDePago();
            }
            else
            {
                MessageBox.Show("Seleccione algun elemento", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}