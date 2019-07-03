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
          
           
         EventAccion(repository.GetFacturas());
        }
        public delegate void myEvendDelegate(List<Factura> facturas);
        public event myEvendDelegate MyEvent;

        protected virtual void EventAccion(List<Factura> facturas)
        {
            myEvendDelegate tmp = MyEvent;
            if (tmp != null)
            {
                tmp(facturas);
            }
        }
    }
}
