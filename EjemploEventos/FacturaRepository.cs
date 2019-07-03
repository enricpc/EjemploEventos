using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public class FacturaRepository
    {
        private static List<Factura> listaFactura;
        static FacturaRepository()
        {
            listaFactura = new List<Factura>();
            Factura factura1 = new Factura()
            {
                Id = 1,
                Descripcion = "bablab1",
                Direccion = "Patata"
            };
            listaFactura.Add(factura1);
            Factura factura2 = new Factura()
            {
                Id = 2,
                Descripcion = "bababab2",
                Direccion = "Nactarina"
            };
            listaFactura.Add(factura2);
            Factura factura3 = new Factura()
            {
                Id = 3,
                Descripcion = "ababab3",
                Direccion = "moniato"
            };
            listaFactura.Add(factura3);
        }

        public List<Factura> GetFacturas()
        {
            return listaFactura;
        }
    
    }
}
