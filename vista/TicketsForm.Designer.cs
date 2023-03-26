
namespace vista
{
    partial class TicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtfecha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtsoporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.Txtsolictud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtrespuesta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtimpuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // Txtfecha
            // 
            this.Txtfecha.Enabled = false;
            this.Txtfecha.Location = new System.Drawing.Point(178, 23);
            this.Txtfecha.Name = "Txtfecha";
            this.Txtfecha.Size = new System.Drawing.Size(100, 20);
            this.Txtfecha.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Location = new System.Drawing.Point(178, 49);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // Txtcliente
            // 
            this.Txtcliente.Enabled = false;
            this.Txtcliente.Location = new System.Drawing.Point(178, 75);
            this.Txtcliente.Name = "Txtcliente";
            this.Txtcliente.Size = new System.Drawing.Size(100, 20);
            this.Txtcliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // Txtsoporte
            // 
            this.Txtsoporte.Enabled = false;
            this.Txtsoporte.Location = new System.Drawing.Point(178, 101);
            this.Txtsoporte.Name = "Txtsoporte";
            this.Txtsoporte.Size = new System.Drawing.Size(100, 20);
            this.Txtsoporte.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Soporte";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Location = new System.Drawing.Point(382, 317);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 24;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Location = new System.Drawing.Point(285, 317);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 22;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(178, 317);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // TicketGridView
            // 
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Location = new System.Drawing.Point(1, 346);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.Size = new System.Drawing.Size(800, 108);
            this.TicketGridView.TabIndex = 25;
            // 
            // Txtsolictud
            // 
            this.Txtsolictud.Enabled = false;
            this.Txtsolictud.Location = new System.Drawing.Point(178, 127);
            this.Txtsolictud.Name = "Txtsolictud";
            this.Txtsolictud.Size = new System.Drawing.Size(100, 20);
            this.Txtsolictud.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Descripcion solicitud";
            // 
            // Txtrespuesta
            // 
            this.Txtrespuesta.Enabled = false;
            this.Txtrespuesta.Location = new System.Drawing.Point(178, 155);
            this.Txtrespuesta.Name = "Txtrespuesta";
            this.Txtrespuesta.Size = new System.Drawing.Size(100, 20);
            this.Txtrespuesta.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Descripcion Respuesta";
            // 
            // Txtprecio
            // 
            this.Txtprecio.Enabled = false;
            this.Txtprecio.Location = new System.Drawing.Point(179, 181);
            this.Txtprecio.Name = "Txtprecio";
            this.Txtprecio.Size = new System.Drawing.Size(100, 20);
            this.Txtprecio.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Precio";
            // 
            // Txtimpuesto
            // 
            this.Txtimpuesto.Enabled = false;
            this.Txtimpuesto.Location = new System.Drawing.Point(178, 202);
            this.Txtimpuesto.Name = "Txtimpuesto";
            this.Txtimpuesto.Size = new System.Drawing.Size(100, 20);
            this.Txtimpuesto.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Impuesto";
            // 
            // Txttotal
            // 
            this.Txttotal.Enabled = false;
            this.Txttotal.Location = new System.Drawing.Point(178, 226);
            this.Txttotal.Name = "Txttotal";
            this.Txttotal.Size = new System.Drawing.Size(100, 20);
            this.Txttotal.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txtimpuesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txtprecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txtrespuesta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtsolictud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TicketGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Txtsoporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtfecha);
            this.Controls.Add(this.label1);
            this.Name = "TicketsForm";
            this.Text = "TICKETSForm";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtfecha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtsoporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView TicketGridView;
        private System.Windows.Forms.TextBox Txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtimpuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txtrespuesta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtsolictud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}