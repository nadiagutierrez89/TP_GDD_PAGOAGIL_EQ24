﻿using PagoAgilFrba.Models.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.AbmRol
{
    public partial class ABMRol : Form
    {
        private List<Rol> rolList;
        private Rol selectedRol;

        public ABMRol()
        {
            InitializeComponent();
            rolList = new List<Rol>();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            dataGridViewRol.AutoGenerateColumns = false;
            dataGridViewRol.MultiSelect = false;
            SetDgv();
            fillDataGridView();
        }

        public void fillDataGridView()
        {
            rolList = Rol.retrieveAll();
            dataGridViewRol.DataSource = rolList;
        }

        private void SetDgv()
        {
            dataGridViewRol.ColumnCount = 3;
            dataGridViewRol.AllowUserToAddRows = false;

            dataGridViewRol.Columns[0].Name = "cod_rol";
            dataGridViewRol.Columns[0].DataPropertyName = "cod_rol";
            dataGridViewRol.Columns[0].Visible = false;

            dataGridViewRol.Columns[1].Name = "nombre_rol";
            dataGridViewRol.Columns[1].DataPropertyName = "nombre_rol";
            dataGridViewRol.Columns[1].ReadOnly = true;

            dataGridViewRol.Columns[2].Name = "habilitado";
            dataGridViewRol.Columns[2].DataPropertyName = "habilitado";
            dataGridViewRol.Columns[2].ReadOnly = true;
            dataGridViewRol.Columns[2].Width = 40;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewRol.Columns.Add(btn);
            btn.HeaderText = "Modificar";
            btn.Text = "Modificar";
            btn.Name = "btnModificar";
            btn.UseColumnTextForButtonValue = true;

            btn = new DataGridViewButtonColumn();
            dataGridViewRol.Columns.Add(btn);
            btn.HeaderText = "Eliminar";
            btn.Text = "Eliminar";
            btn.Name = "btnEliminar";
            btn.UseColumnTextForButtonValue = true;
        }


        private void createColumns()
        {
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "cod_rol";
            colId.HeaderText = "cod_rol";
            colId.Width = 70;
            colId.ReadOnly = true;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "nombre_rol";
            colNombre.HeaderText = "nombre_rol";
            colNombre.Width = 120;
            colNombre.ReadOnly = true;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.DataPropertyName = "habilitado";
            colEstado.HeaderText = "habilitado";
            colEstado.Width = 50;
            colEstado.ReadOnly = true;

            dataGridViewRol.Columns.Add(colId);
            dataGridViewRol.Columns.Add(colNombre);
            dataGridViewRol.Columns.Add(colEstado);
            dataGridViewRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // borrarButton.Enabled = true;
            //  modificarButton.Enabled = true;
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            selectedRol = (Rol)dataGridViewRol.CurrentRow.DataBoundItem;
            System.Windows.Forms.MessageBox.Show("Rol Nombre: " + selectedRol.nombre_rol + " Rol Id: " + selectedRol.cod_rol);
            Rol.deleteRol((int)selectedRol.cod_rol);
            fillDataGridView();
        }

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            showFormRol();
        }

        private void showFormRol(int rol_id = 0)
        {
            FormRol formRol = new FormRol(this, rol_id);
            formRol.ShowDialog();
        }

        private void dataGridViewRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewRol.CurrentCell.OwningRow;
            int rol_id = Convert.ToInt32(row.Cells["cod_rol"].Value.ToString());

            if (e.ColumnIndex == 3)
                showFormRol(rol_id);
            else if (e.ColumnIndex == 4)
                DeleteRol(rol_id);
        }

        private void DeleteRol(int rol_id)
        {
            Rol.deleteRol(rol_id);
            this.fillDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showFormRol();
        }
    }
}
