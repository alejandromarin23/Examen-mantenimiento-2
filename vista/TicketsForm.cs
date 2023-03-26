using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vista
{
    public partial class  TicketsForm : Form 
    {
        
        public TicketsForm()
        {
            InitializeComponent();
        }
        string operacion= String.Empty;
       
        TicketDB ticketDB = new TicketDB();
        Ticket ticket = new Ticket();

         
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            
            operacion = "Nuevo";
            HabiltarControles();
            Guardarbutton.Enabled = true;
        }
        

        private void HabiltarControles ()
        {
            Txtfecha.Enabled = true;
            TxtUsuario.Enabled = true;
            Txtcliente.Enabled = true;
            Txtsoporte.Enabled = true;
            Txtsolictud.Enabled = true;
            Txtrespuesta.Enabled = true;
            Txtprecio.Enabled = true;
            Txtimpuesto.Enabled = true;
            Txttotal.Enabled = true;
            Guardarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            Nuevobutton.Enabled = false;


        }
        private void DesabilitarControles()
        {
            Txtfecha.Enabled = false;
            TxtUsuario.Enabled = false;
            Txtcliente.Enabled = false;
            Txtsoporte.Enabled = false;
            Txtsolictud.Enabled = false;
            Txtrespuesta.Enabled = false;
            Txtprecio.Enabled = false;
            Txtimpuesto.Enabled = false;
            Txttotal.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;


        }
        public void LimpiarControles()
        {
            Txtfecha.Clear();
            TxtUsuario.Clear();
            Txtcliente.Clear();
            Txtsoporte.Clear();
            Txtsolictud.Clear();
            Txtrespuesta.Clear();
            Txtprecio.Clear();
            Txtimpuesto.Clear();
            Txttotal.Clear();


        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            DesabilitarControles();
        }

        private void Eliminarbutton_Click(object sender,EventArgs e)
        {

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(Txtfecha.Text)) 
                {
                    errorProvider1.SetError(Txtfecha, "Ingrese una fecha");
                    Txtfecha.Focus();
                    return;

                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(TxtUsuario.Text))
                {
                    errorProvider1.SetError(TxtUsuario, "Ingrese una descripcion");
                    TxtUsuario.Focus();
                    return;

                }
                
                
                ticket.Usuario = TxtUsuario.Text;
                ticket.Cliente = Txtcliente.Text;
                ticket.TipoSoporte = Txtsoporte.Text;
                ticket.DescripcionSolicitud = Txtsolictud.Text;
                ticket.DescripcionRespuesta = Txtrespuesta.Text;
                ticket.Precio = Convert.ToDecimal (Txtprecio.Text);
                ticket.Impuesto = Convert.ToDecimal(Txtimpuesto.Text);
                ticket.Total = Convert.ToDecimal(Txttotal.Text);
                ticket.Fecha = Convert.ToDateTime(Txtfecha.Text);


                // insertar en BD
                bool inserto = ticketDB.Insertar(ticket);
                if(inserto)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    MessageBox.Show("registro guardado");
                    TraerTickets();
                } else if(inserto==false)
                {
                    MessageBox.Show("Error");
                }
                
            }
        }

        

      
        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerTickets();
        }

        private void TraerTickets()
        {
            DataTable dt = new DataTable();

            dt = ticketDB.DevolverUsuario();
            TicketGridView.DataSource = dt;

        }
     
       
        /*Genera el impuesto, se recibe una variable p, que hace referencia al precio*/
        private double Generar_Impuesto(double p)
        {
            double imp;

            imp = (p * 0.15);


            return imp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            double d = Convert.ToDouble(Txtprecio.Text);
            double d2 = Generar_Impuesto(d);
            string s = Convert.ToString(d2);
            Txtimpuesto.AppendText(s);
            Txttotal.AppendText((Convert.ToString(d + d2)));


        }

      
    }
}
