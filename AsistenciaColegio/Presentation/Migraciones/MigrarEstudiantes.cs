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

namespace SisCob.Presentation.Migraciones
{
    public partial class MigrarEstudiantes : UserControl
    {
        public MigrarEstudiantes()
        {
            InitializeComponent();
        }
        
        private void MigrarEstudiantes_Load(object sender, EventArgs e)
        {
            MostrarGrado();
           
        }
        private void MostrarGrado()
        {
            var dt = new DataTable();
            Obtener_datos.mostrar_Cursos(ref dt);
            cbGradode.DisplayMember = "Nombre_Curso";
            cbGradode.ValueMember = "IdCurso";
            cbGradode.DataSource = dt;

            dt = new DataTable();
            Obtener_datos.mostrar_Cursos(ref dt);
            cbGradoA.DisplayMember = "Nombre_Curso";
            cbGradoA.ValueMember = "IdCurso";
            cbGradoA.DataSource = dt;
        }

        private void cbGradode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = cbGradode.SelectedValue.ToString();
            int IdGradoSeleccionado = Convert.ToInt32(selectedItems);
           
            try
            {
                
                var dt = new DataTable();
                Obtener_datos.MostrarEstudiantesPorGrado(IdGradoSeleccionado, ref dt);
                dgvEstudiantes.DataSource = dt;
                //Data.Bases.Multilinea(ref dgvEstudiantes);
                dgvEstudiantes.Columns[1].Visible = false;
                dgvEstudiantes.Columns[0].Width = 35;
                dgvEstudiantes.Columns[2].Width = 150;
                dgvEstudiantes.Columns[3].Width = 150;
                dgvEstudiantes.Columns[4].Width = 150;
                dgvEstudiantes.Columns[5].Width = 100;

                DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
                styCabeceras.BackColor = System.Drawing.Color.White;
                styCabeceras.ForeColor = System.Drawing.Color.Black;
                styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvEstudiantes.ColumnHeadersDefaultCellStyle = styCabeceras;

                dgvEstudiantes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEstudiantes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             

            }
            catch (Exception ex)
            {

            }
        }

        private void cbGradoA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvEstudiantes.Columns["check"].Index)
            {
                try
                {
                    var estado = Convert.ToBoolean(dgvEstudiantes.SelectedCells[0].Value);
                    if (estado == true)
                    {
                        dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value = false;
                    }
                    else
                    {
                        dgvEstudiantes.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                }
                catch (Exception ex)
                {

                }
                
            }
            
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvEstudiantes.Rows.Count; i++)
                {
                    var estado = Convert.ToBoolean(dgvEstudiantes.Rows[i].Cells[0].Value);
                    if (estado == false)
                    {
                        dgvEstudiantes.Rows[i].Cells[0].Value = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }
        private void MigrarEstudiante(int IdgradoMigrar,int Idestudiante)
        {
            Editar_datos.MigrarEstudiante(Idestudiante, IdgradoMigrar);
        }
        private void btnMigrar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdgradoAMigrar = Convert.ToInt32(cbGradoA.SelectedValue.ToString());
                for (int i = 0; i < dgvEstudiantes.Rows.Count; i++)
                {
                    bool estado = Convert.ToBoolean( dgvEstudiantes.Rows[i].Cells[0].Value);
                    if (estado == true)
                    {
                        int Idestudiante = Convert.ToInt32(dgvEstudiantes.Rows[i].Cells[1].Value);
                        MigrarEstudiante(IdgradoAMigrar, Idestudiante);
                    }
                }
                //Limpiar los datos consultados
                dgvEstudiantes.DataSource = null;
                MostrarGrado();
                MessageBox.Show("Estudiante(s) migrado(s) correctamente", "Operacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
