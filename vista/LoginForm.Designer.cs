
namespace vista
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.mostrarbutton = new System.Windows.Forms.Button();
            this.imagenpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.CodigoUsuarioTextBox.Location = new System.Drawing.Point(170, 44);
            this.CodigoUsuarioTextBox.Name = "txtusuario";
            this.CodigoUsuarioTextBox.Size = new System.Drawing.Size(141, 20);
            this.CodigoUsuarioTextBox.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(170, 88);
            this.ContraseñaTextBox.Name = "txtcontraseña";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(141, 20);
            this.ContraseñaTextBox.TabIndex = 3;
            this.ContraseñaTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarbutton.Image = global::vista.Properties.Resources.aceptar;
            this.aceptarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aceptarbutton.Location = new System.Drawing.Point(150, 125);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(81, 23);
            this.aceptarbutton.TabIndex = 5;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbutton.Image = global::vista.Properties.Resources.desenfrenado;
            this.cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarbutton.Location = new System.Drawing.Point(247, 125);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(88, 23);
            this.cancelarbutton.TabIndex = 6;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // mostrarbutton
            // 
            this.mostrarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarbutton.Image = global::vista.Properties.Resources.ver;
            this.mostrarbutton.Location = new System.Drawing.Point(316, 88);
            this.mostrarbutton.Name = "mostrarbutton";
            this.mostrarbutton.Size = new System.Drawing.Size(36, 23);
            this.mostrarbutton.TabIndex = 7;
            this.mostrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostrarbutton.UseVisualStyleBackColor = true;
            this.mostrarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // imagenpictureBox
            // 
            this.imagenpictureBox.BackColor = System.Drawing.Color.White;
            this.imagenpictureBox.Image = global::vista.Properties.Resources.usuario;
            this.imagenpictureBox.Location = new System.Drawing.Point(358, 44);
            this.imagenpictureBox.Name = "imagenpictureBox";
            this.imagenpictureBox.Size = new System.Drawing.Size(73, 72);
            this.imagenpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenpictureBox.TabIndex = 4;
            this.imagenpictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarbutton;
            this.ClientSize = new System.Drawing.Size(466, 211);
            this.Controls.Add(this.mostrarbutton);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.imagenpictureBox);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.CodigoUsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoUsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.PictureBox imagenpictureBox;
        private System.Windows.Forms.Button aceptarbutton;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button mostrarbutton;
    }
}

