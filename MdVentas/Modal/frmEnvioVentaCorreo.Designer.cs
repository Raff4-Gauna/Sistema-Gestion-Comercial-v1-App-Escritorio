
namespace CapaPresentación.MdVentas.Modal
{
    partial class frmEnvioVentaCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvioVentaCorreo));
            this.btnEnviar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.txtemaildestino = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            this.btnEnviar.IconColor = System.Drawing.Color.Black;
            this.btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnviar.IconSize = 25;
            this.btnEnviar.Location = new System.Drawing.Point(142, 294);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(165, 30);
            this.btnEnviar.TabIndex = 166;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.Location = new System.Drawing.Point(355, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 30);
            this.btnCancelar.TabIndex = 167;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.BackColor = System.Drawing.SystemColors.Control;
            this.txtmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmensaje.Location = new System.Drawing.Point(204, 127);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(368, 127);
            this.txtmensaje.TabIndex = 228;
            this.txtmensaje.Text = "¡Gracias por tu compra! Adjuntamos tu factura. Cualquier consulta, estamos a tu d" +
    "isposición.";
            // 
            // txtemaildestino
            // 
            this.txtemaildestino.BackColor = System.Drawing.SystemColors.Control;
            this.txtemaildestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemaildestino.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtemaildestino.Location = new System.Drawing.Point(204, 68);
            this.txtemaildestino.Name = "txtemaildestino";
            this.txtemaildestino.Size = new System.Drawing.Size(368, 29);
            this.txtemaildestino.TabIndex = 227;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(206, 12);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(236, 29);
            this.txtnombrecliente.TabIndex = 226;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 230;
            this.label5.Text = "Email Destinatario: *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(35, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 18);
            this.label15.TabIndex = 229;
            this.label15.Text = "Nombre del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(116, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 232;
            this.label2.Text = "Mensaje:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 70);
            this.label4.TabIndex = 233;
            // 
            // frmEnvioVentaCorreo
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(622, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.txtemaildestino);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnvioVentaCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Comprobante por Email";
            this.Load += new System.EventHandler(this.frmEnvioVentaCorreo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEnviar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.TextBox txtemaildestino;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}