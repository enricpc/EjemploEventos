using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEventos
{
    public partial class FrmMostrarFacturas : Form
    {
        public FrmMostrarFacturas()
        {
            InitializeComponent();
        }
       static List<Factura> facturas = new List<Factura>();
        private void button1_Click(object sender, EventArgs e)
        {
            var frmAgregarFacturas = new FrmAgregarFacturas();
            frmAgregarFacturas.MyEvent += comun_Logging;
            frmAgregarFacturas.Show();
           
        }
        void comun_Logging(List<Factura> nFacturas)
        {
            facturas = nFacturas;
            dataGridView1.DataSource = facturas;
        }
    }
}
