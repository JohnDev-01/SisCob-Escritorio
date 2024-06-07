using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisCob.Data;
using SisCob.Models;

namespace SisCob.Presentation.Students
{
    public partial class Show_students : UserControl
    {
        public Show_students()
        {
            InitializeComponent();
        }
        int IdStudents = 0;

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                lblBuscarEtiqueta.Visible = true;
            }
            else
            {
                lblBuscarEtiqueta.Visible = false;
                
            }
            Show_Students();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }
        private void Show_Students()
        {
            var dt = new DataTable();
            Obtener_datos.Show_Students(ref dt,txtbuscar.Text);
            dgvStudents.DataSource = dt;
            Bases.ClassBases.Multilinea(ref dgvStudents);
            dgvStudents.Columns[1].Visible = false;
            dgvStudents.Columns[9].Visible = false;
            dgvStudents.Columns[6].Visible = false;
            dgvStudents.Columns[7].Visible = false;

        }
        private void Show_students_Load(object sender, EventArgs e)
        {
            Show_Students();
            pAgregarEditar.Visible = false;
            panelMostarEstudiante.Visible = true;
            panelMostarEstudiante.Dock = DockStyle.Fill;
        }
        private void ObtenerValoresStudents()
        {
            Mstudents m = new Mstudents();
            try
            {
                m.IdStudents = Convert.ToInt32(dgvStudents.SelectedCells[1].Value);
                m.NombreStudents = dgvStudents.SelectedCells[2].Value.ToString();
                m.Nombre_padre = dgvStudents.SelectedCells[3].Value.ToString();
                m.Nombre_madre = dgvStudents.SelectedCells[4].Value.ToString();
                m.Numero_contacto = dgvStudents.SelectedCells[5].Value.ToString();
                m.Numero_contacto2 = dgvStudents.SelectedCells[6].Value.ToString();
                m.Direccion = dgvStudents.SelectedCells[7].Value.ToString();
                m.Fecha_nac = Convert.ToDateTime(dgvStudents.SelectedCells[8].Value);
                m.idCurso = Convert.ToInt32(dgvStudents.SelectedCells[9].Value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            ShowEditStudents(ref m);
            IdStudents = m.IdStudents;
        }
        private void ShowEditStudents(ref Mstudents m)
        {
            pAgregarEditar.Visible = true;
            pAgregarEditar.Dock = DockStyle.Fill;
            pAgregarEditar.BringToFront();
            panelMostarEstudiante.Visible = false;
            btnGuardarEstudiante.Visible = false;
            btnActualizar.Visible = true;

            //Asignar Data:
            Show_Courses();
            txtNomEstud.Text = m.NombreStudents;
            txtNombrepadre.Text = m.Nombre_padre;
            txtNombremadre.Text = m.Nombre_madre;
            txtNumero1.Text = m.Numero_contacto;
            txtNumero2.Text = m.Numero_contacto2;
            txtDireccion.Text = m.Direccion;
            dtFecha.Value = m.Fecha_nac;
            cbGrado.SelectedValue = m.idCurso;
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStudents.Columns["edi"].Index)
            {
                ObtenerValoresStudents();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Show_Courses()
        {
            var d = new DataTable();
            Obtener_datos.mostrar_Cursos(ref d);
            cbGrado.ValueMember = "IdCurso";
            cbGrado.DisplayMember = "Nombre_Curso";
            cbGrado.DataSource = d;
        }
        private void LlenarModelo(ref Mstudents models)
        {
            //Asignacion de un Objeto con los datos correspondientes
            var Data = new
            {
                Nombre = txtNomEstud.Text,
                NombrePadre = txtNombrepadre.Text,
                NombreMadre = txtNombremadre.Text,
                Telefono1 = txtNumero1.Text,
                Telefono2 = txtNumero2.Text,
                Direccion = txtDireccion.Text,
                Fecha = dtFecha.Value,
                IdGrado = Convert.ToInt32(cbGrado.SelectedValue)

            };

            //Asignacion al Modelo

            models.NombreStudents = Data.Nombre;
            models.Nombre_padre = Data.NombrePadre;
            models.Nombre_madre = Data.NombreMadre;
            models.Numero_contacto = Data.Telefono1;
            models.Numero_contacto2 = Data.Telefono2;
            models.Direccion = Data.Direccion;
            models.Fecha_nac = Data.Fecha;
            models.idCurso = Data.IdGrado;
        }
        private void Guardar()
        {
            Mstudents models = new Mstudents();
            LlenarModelo(ref models);
            //Insertar a la base de datos
            if (Insertar_datos.Insertar_Students(models) == true)
            {
                Limpiar_Volver();
                MessageBox.Show("Estudiante creado correctamente.","Correcto:",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtbuscar.Focus();
            }
        }
        private void Update_Students()
        {
            Mstudents models = new Mstudents();
            models.IdStudents = IdStudents; 
            LlenarModelo(ref models);
            if(Editar_datos.Editar_Students(models) == true)
            {
                Limpiar_Volver();
                MessageBox.Show("Editado Correctamente.", "Estado Actualizado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
            }
        }
        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            string message = "";
            if (Validar_Data_Vacia(ref message) == true)
            {
                Guardar();
            }
            else
            {
                MessageBox.Show(message, "-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool  Validar_Data_Vacia(ref string message)
        {
            bool estado = true;
           if (string.IsNullOrWhiteSpace(txtNomEstud.Text) == true)
            {
                errorProvider1.SetError(txtNomEstud, "El nombre del estudiante no puede estar vacio");
                estado =  false;
                message = "El nombre del estudiante no puede estar vacio";
            }
            else
            {
                errorProvider1.Clear();
                estado = true;
            }
            if (cbGrado.SelectedValue == null)
            {
                errorProvider1.SetError(cbGrado, "El grado del estudiante no puede estar vacio");
                estado = false;
                message = "El grado del estudiante no puede estar vacio";

            }
            else
            {
                errorProvider1.Clear();
                estado = true;
            }

            if (string.IsNullOrEmpty(txtNombrepadre.Text))
            {
                txtNombrepadre.Text = "-";
            }
            if (string.IsNullOrEmpty(txtNombremadre.Text))
            {
                txtNombremadre.Text = "-";
            }
            if (string.IsNullOrEmpty(txtNumero1.Text))
            {
                txtNumero1.Text = "0000000000";
            }
            if (string.IsNullOrEmpty(txtNumero2.Text))
            {
                txtNumero2.Text = "0000000000";
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                txtDireccion.Text = "-";
            }
            return estado;
        }
        private void Organizar_Paneles_agregar()
        {
            panelMostarEstudiante.Visible = false;
            pAgregarEditar.Visible = true;
            pAgregarEditar.Dock = DockStyle.Fill;
            txtNomEstud.Clear();
            txtNombrepadre.Clear();
            txtNombremadre.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtDireccion.Clear();
            dtFecha.Value = DateTime.Now;
            Show_Courses();
            btnGuardarEstudiante.Visible = true;
            btnActualizar.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Organizar_Paneles_agregar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Limpiar_Volver();
        }
        private void Limpiar_Volver()
        {
            pAgregarEditar.Visible = false;
            panelMostarEstudiante.Visible = true;
            Show_Students();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string message = "";

            if (Validar_Data_Vacia(ref message) == true)
            {
                Update_Students();
            }
            else
            {
                MessageBox.Show(message, "-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNomEstud_TextChanged(object sender, EventArgs e)
        {
            string Message = "";
            Validar_Data_Vacia(ref Message) ;
        }

        private void txtNombrepadre_TextChanged(object sender, EventArgs e)
        {
            string Message = "";
            Validar_Data_Vacia(ref Message);
        }

        private void txtNombremadre_TextChanged(object sender, EventArgs e)
        {
            string Message = "";
            Validar_Data_Vacia(ref Message);
        }

        private void txtNumero1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            string Message = "";
            Validar_Data_Vacia(ref Message);
        }

        private void txtPrueba_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
