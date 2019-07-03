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
        FrmAgregarFacturas frmAgregarFacturas = new FrmAgregarFacturas();
        public FrmMostrarFacturas()
        {
            InitializeComponent();
            frmAgregarFacturas.MyEvent += nuevaFactura;
        }
       static List<Factura> facturas = new List<Factura>();
        private void button1_Click(object sender, EventArgs e)
        {

            frmAgregarFacturas.Show();
        }
        void nuevaFactura(List<Factura> nFacturas)
        {
            facturas = nFacturas;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = facturas;
        }
    }
}
