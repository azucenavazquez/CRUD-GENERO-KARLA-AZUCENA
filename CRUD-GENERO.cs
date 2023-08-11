using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using Utilerias;

namespace MyApp
{

    public partial class Form1 : Form
    {
        #region PROPIEDADES
        public ClassEnumeracionesGenero Estado { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Form1()
        {
            InitializeComponent();
            CargaDatos();
            this.Estado = ClassEnumeracionesGenero.Inicial;
        }
        #endregion

        #region METODOS
        private void CargaDatos()
        {
            List<Usuario> usuarios = clsNUsuario.ObtenerLista();
            dgvDatos.DataSource = usuarios;

            #region FORMATEAR GRID
            if (dgvDatos.Columns.Contains("ID"))
            {
                dgvDatos.Columns["ID"].Visible = false;
            }
            if (dgvDatos.Columns.Contains(""))
            {
                dgvDatos.Columns["Nombre"].HeaderText = "Nombre ";
            }
            if (dgvDatos.Columns.Contains("Descripcion"))
            {
                dgvDatos.Columns["Descripcion"].HeaderText = "Descripcion";
            }
            #endregion
        }
        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            
        }
        #endregion

        #region EVENTOS CLICKs BOTONES
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            lblTituloPanelDatos.Text = "Nuevo Genero";
            panelDatos.BringToFront();
            panelDatos.Visible = true;
            panelGrid.SendToBack();
            this.Estado = EstadosDeForma.Nuevo;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvDatos.SelectedRows[0].Cells["ID"].Value;

                ClsGenero usuario = ClsGenero.GetOne(ID);

                txtNombre.Text = ClsGenero.CrearGenero;
                txtDescripcion.Text = ClsGenero.Actualizar;
              

                lblTituloPanelDatos.Text = "Actualizar Genero";
                panelDatos.BringToFront();
                panelDatos.Visible = true;
                panelGrid.SendToBack();
                this.Estado = EstadosDeForma.Actualizar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvDatos.SelectedRows[0].Cells["ID"].Value;

                if (ClsGenero.Eliminar(ID))
                    CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Estado == EstadosDeForma.Nuevo)
                {
                    if (clsNUsuario.CrearCuenta(txtUsuario.Text,
                                    txtPassword.Text, txtCorreoElectronico.Text)
                    )
                    {
                        CargaDatos();
                        btnCancelar_Click(null, null);
                    }
                }
                else if (this.Estado == ClassEnumeracionesGenero.Actualizar)
                {
                    int ID = (int)dgvDatos.SelectedRows[0].Cells["ID"].Value;
                    Usuario usuario = new Usuario();
                    usuario.ID = ID;
                    usuario.Usuario1 = txtUsuario.Text;
                    usuario.Password = txtPassword.Text;
                    usuario.CorreoElectronico = txtCorreoElectronico.Text;

                    if (ClsGenero.Actualizar(Genero))
                    {
                        CargaDatos();
                        btnCancelar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelGrid.BringToFront();
            panelDatos.Visible = false;
            panelDatos.SendToBack();
            this.Estado = ClassEnumeracionesGenero.Inicial;
        }
        #endregion


    }
}

