using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCob.Presentation.ConexionesRemotas
{
    public partial class GenerarConexion : UserControl
    {
        public GenerarConexion()
        {
            InitializeComponent();
        }
        string IP;
        private void GenerarConexion_Load(object sender, EventArgs e)
        {
            ObtenerIp();
            
        }
        private void ObtenerIp()
        {
            IP = Dns.GetHostEntry(System.Environment.MachineName).AddressList.FirstOrDefault((i) => i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            txtConexiones.Text = IP;
            GenerarReporte();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ObtenerIp();
        }
        private void GenerarReporte()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("IP");
                DataRow row = dt.NewRow();
                row["IP"] = IP;
                dt.Rows.Add(row);

                var rpt = new ConexionesRemotas.rptQR();
                rpt.DataSource = dt;
                reportViewer1.ReportSource = rpt;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
