using PagoAgilFrba.Models.BO;
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
    public partial class FormRol : Form
    {
        private int _rol_id;
        private Rol rol;
        private ABMRol _abmRol;
        private List<Funcionalidad> funcList;

        public FormRol(ABMRol abmRol, int rol_id)
        {
            InitializeComponent();
            this._abmRol = abmRol;
            funcList = new List<Funcionalidad>();
            this._rol_id = rol_id;

            if (_rol_id != 0)
            {
                this.Text = "Modificar Rol";
                lblTitulo.Text = "Modificar Rol";
                rol = Rol.getRolById(_rol_id);
                txtNombreRol.Text = rol.nombre_rol;
                if ((bool)rol.habilitado)
                    RbActivo.Checked = true;
                if (!(bool)rol.habilitado)
                    RbNoActivo.Checked = true;
            }
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            setDgvFuncionalidades();
            fillDgvFuncionalidades();
        }

        private void fillDgvFuncionalidades()
        {
            funcList = Funcionalidad.retrieveAll();
            dgvFuncionalidades.DataSource = funcList;
            checkFunc();
        }

        private void checkFunc()
        {
            foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                //chk.Value = true;
                chk.Value = Rol.existeRolFuncionalidad(_rol_id, (int)row.Cells["ID"].Value);
            }
        }

        private void setDgvFuncionalidades()
        {
            dgvFuncionalidades.ColumnCount = 2;
            dgvFuncionalidades.AllowUserToAddRows = false;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "chkFunc";
            checkColumn.HeaderText = "Seleccionar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10;
            dgvFuncionalidades.Columns.Insert(0, checkColumn);

            dgvFuncionalidades.Columns[1].Name = "ID";
            dgvFuncionalidades.Columns[1].DataPropertyName = "id";
            dgvFuncionalidades.Columns[1].Visible = false;

            dgvFuncionalidades.Columns[2].Name = "Nombre";
            dgvFuncionalidades.Columns[2].DataPropertyName = "name";
            dgvFuncionalidades.Columns[2].ReadOnly = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validateFields())
                return;
            rol = new Rol();
            rol.nombre_rol = txtNombreRol.Text;
            if (RbActivo.Checked)
                rol.habilitado = true;
            else if (RbNoActivo.Checked)
                rol.habilitado = false;
            else
                rol.habilitado = false;
            if (this._rol_id != 0) //Es modificacion
            {
                rol.cod_rol = this._rol_id;
                Rol.update(rol);
                Rol.deleteAllFunc(this._rol_id);
                saveRolFunc(this._rol_id);

            }
            else
            {
                Rol.create(rol);
                saveRolFunc(Rol.getLastIdRol());
            }
            _abmRol.fillDataGridView();
            this.Hide();
        }

        private void saveRolFunc(int id_rol)
        {
            foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
            {
                //CheckBox chk = (CheckBox)row.Cells[0].Value;
                DataGridViewCheckBoxCell chk = row.Cells["chkFunc"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chk.Value))
                {
                    Rol.createRolFuncionalidad(id_rol, (int)row.Cells["ID"].Value);
                }
            }
        }

        private bool validateFields()
        {
            if (String.IsNullOrEmpty(txtNombreRol.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del rol");
                return false;
            }

            if (RbActivo.Checked == false && RbNoActivo.Checked == false)
            {
                MessageBox.Show("Por favor seleccione si el rol esta activo o no");
                return false;
            }
            return true;
        }
    }
}
