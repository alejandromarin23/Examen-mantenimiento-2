using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Ticket
    {
 

        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public String Cliente { get; set; }
        public String TipoSoporte { get; set; }
        public String DescripcionSolicitud { get; set; }
        public String DescripcionRespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public byte [] Imagen { get; set; }

        public Ticket()
        {
            
        }

        public Ticket(DateTime fecha, string usuario, String cliente, string tipoSoporte, decimal impuesto, decimal descuento, decimal total, string descripcionSolicitud, string descripcionRespuesta, decimal precio, byte[] imagen)
        {
            Fecha = fecha;
            Usuario = usuario;
            Cliente = cliente;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            Total = total;
            Imagen = imagen;
        }
    }
}
