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
        FacturaRepository facturaRepository = new FacturaRepository();
        public FrmMostrarFacturas()
        {
            InitializeComponent();
            dataGridView1.DataSource = facturaRepository.GetFacturas();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarFacturas frmAgregarFacturas = new FrmAgregarFacturas();
            frmAgregarFacturas.MyEvent += actualizarFactura;
            frmAgregarFacturas.Show();
        }
        void actualizarFactura()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = facturaRepository.GetFacturas();
        }
    }
}
