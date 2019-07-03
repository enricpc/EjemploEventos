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
    public partial class FrmAgregarFacturas : Form
    {
        public FrmAgregarFacturas()
        {
            InitializeComponent();
        }
        FacturaRepository repository = new FacturaRepository();
        private void button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura()
            {
                Id = Convert.ToInt32(textBox1.Text.ToString()),
                Descripcion = textBox2.Text.ToString(),
                Direccion = textBox3.Text.ToString()

        };
            repository.addFactura(factura);
         EventAccion();
        }
        public delegate void myEvendDelegate();
        public event myEvendDelegate MyEvent;

        protected virtual void EventAccion()
        {
            myEvendDelegate tmp = MyEvent;
            if (tmp != null)
            {
                tmp();
            }
        }
    }
}
