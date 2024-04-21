namespace _24_2_ejercicioFormulario
{
    partial class frDatosPersonales
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
            System.Windows.Forms.Button btnAceptar;
            System.Windows.Forms.Button btnCancelar;
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAceptar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAceptar.Location = new System.Drawing.Point(164, 503);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(100, 31);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCancelar.Location = new System.Drawing.Point(359, 503);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 31);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(40, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApellido.Location = new System.Drawing.Point(38, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(85, 24);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDNI.Location = new System.Drawing.Point(78, 149);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(45, 24);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.BackColor = System.Drawing.Color.Transparent;
            this.lblDirección.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirección.Location = new System.Drawing.Point(31, 204);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(92, 24);
            this.lblDirección.TabIndex = 3;
            this.lblDirección.Text = "Dirección:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(31, 256);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(129, 36);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 32);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(129, 93);
            this.txtApellido.MaxLength = 10;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 32);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(129, 146);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(147, 32);
            this.txtDNI.TabIndex = 8;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtDirección
            // 
            this.txtDirección.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDirección.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirección.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirección.Location = new System.Drawing.Point(129, 201);
            this.txtDirección.MaxLength = 32;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(412, 32);
            this.txtDirección.TabIndex = 9;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(35, 283);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(529, 214);
            this.txtResultado.TabIndex = 13;
            // 
            // frDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 573);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frDatosPersonales";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

