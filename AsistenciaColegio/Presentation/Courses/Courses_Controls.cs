using SisCob.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.Courses
{
    public partial class Courses_Controls : UserControl
    {
        public Courses_Controls()
        {
            InitializeComponent();
        }
        int IdCourse = 0;
        private void Courses_Controls_Load(object sender, EventArgs e)
        {

            MostrarDisenoInicial();
        }
        private void MostrarDisenoInicial()
        {
            panelAgregarGrado.Visible = false;
            dgvCourses.Visible = true;
            dgvCourses.Dock = DockStyle.Fill;
            Show_Courses();
            MostrarNiveles();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbNivel.SelectedValue != null && string.IsNullOrEmpty(txtNombreCurso.Text) != true)
            {
                Insertar_Curso();
            }
            else
            {
                MessageBox.Show("Selecciona el nivel correspondiente", "Comprueba:");
            }
        }
        private void MostrarNiveles()
        {
            var clase = new Obtener_datos();
            var dt = new DataTable();
            clase.MostrarNiveles(ref dt);
            cbNivel.DisplayMember = "Nombre_Nivel";
            cbNivel.ValueMember = "IdNivel";
            cbNivel.DataSource = dt;
        }
        private void Show_Courses()
        {
            var dt = new DataTable();
            Obtener_datos.mostrar_Cursos(ref dt);
            dgvCourses.DataSource = dt;
            Bases.ClassBases.Multilinea(ref dgvCourses);
            dgvCourses.Columns[1].Visible = false;
            dgvCourses.Columns[3].Visible = false;
        }
        private void Insertar_Curso()
        {
            var name_course = txtNombreCurso.Text;
            int IdNivel = Convert.ToInt32(cbNivel.SelectedValue);
            if (Insertar_datos.Insertar_Cursos(name_course, IdNivel) == true) {
                Show_Courses();
                txtNombreCurso.Clear();
                MostrarDisenoInicial();
            }
            else
            {
                MessageBox.Show("Ya existe un grado con este nombre", "Verifica:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCurso.SelectAll();
            }

        }
        private void Edit_Course() 
        {
            int IdNivel = Convert.ToInt32(cbNivel.SelectedValue);
            if (Editar_datos.Editar_Cursos(IdCourse,txtNombreCurso.Text,IdNivel) == true)
            {
                btnGuardar.Visible = true;
                btnActualizar.Visible = false;
                Show_Courses();
                txtNombreCurso.Clear();
                MostrarDisenoInicial();
            }
        }
        private void Obtener_curso()
        {
            txtNombreCurso.Text = dgvCourses.SelectedCells[2].Value.ToString();
            cbNivel.SelectedValue = Convert.ToInt32(dgvCourses.SelectedCells[3].Value);
            IdCourse = Convert.ToInt32(dgvCourses.SelectedCells[1].Value);
            btnGuardar.Visible = false;
            btnActualizar.Visible = true;
            panelAgregarGrado.Visible = true;
            panelAgregarGrado.Dock = DockStyle.Fill;
            dgvCourses.Visible = false;
        }
        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvCourses.Columns["edi"].Index)
            {
                MostrarNiveles();
                Obtener_curso();
            }
        }

        private void btnActaulizar_Click(object sender, EventArgs e)
        {
            if (cbNivel.SelectedValue != null && string.IsNullOrEmpty(txtNombreCurso.Text) != true)
            {
                Edit_Course();
            }
            else
            {
                MessageBox.Show("Selecciona el nivel correspondiente", "Comprueba:");
            }
            
        }

        private void btnMostrarPanelGrado_Click(object sender, EventArgs e)
        {
            panelAgregarGrado.Visible = true;
            panelAgregarGrado.Dock = DockStyle.Fill;
            dgvCourses.Visible = false;
            MostrarNiveles();
        }

        private void cbNivel_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MostrarDisenoInicial();
        }
    }
}
