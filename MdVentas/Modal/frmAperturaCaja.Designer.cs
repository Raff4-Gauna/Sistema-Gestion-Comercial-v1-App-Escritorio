
namespace CapaPresentación.MdVentas.Modal
{
    partial class frmAperturaCaja
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoIncialCaja = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnCierreCaja = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 240;
            this.label5.Text = "Monto Inicial Caja ($)";
            // 
            // txtMontoIncialCaja
            // 
            this.txtMontoIncialCaja.BackColor = System.Drawing.SystemColors.Control;
            this.txtMontoIncialCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoIncialCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoIncialCaja.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMontoIncialCaja.Location = new System.Drawing.Point(197, 59);
            this.txtMontoIncialCaja.Name = "txtMontoIncialCaja";
            this.txtMontoIncialCaja.Size = new System.Drawing.Size(203, 31);
            this.txtMontoIncialCaja.TabIndex = 237;
            this.txtMontoIncialCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoIncialCaja_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 25;
            this.btnRegistrar.Location = new System.Drawing.Point(142, 133);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 37);
            this.btnRegistrar.TabIndex = 234;
            this.btnRegistrar.Text = "Iniciar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.IndianRed;
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnCierreCaja.IconColor = System.Drawing.Color.Black;
            this.btnCierreCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCierreCaja.IconSize = 20;
            this.btnCierreCaja.Location = new System.Drawing.Point(289, 133);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(127, 37);
            this.btnCierreCaja.TabIndex = 235;
            this.btnCierreCaja.Text = "Cierre";
            this.btnCierreCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCierreCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 70);
            this.label4.TabIndex = 242;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 244;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Lime;
            this.lblusuario.Location = new System.Drawing.Point(197, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(130, 31);
            this.lblusuario.TabIndex = 243;
            this.lblusuario.Text = "lblusuario";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(439, 12);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 246;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(471, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 245;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // frmAperturaCaja
            // 
            this.AcceptButton = this.btnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCierreCaja;
            this.ClientSize = new System.Drawing.Size(511, 197);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoIncialCaja);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCierreCaja);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura de Caja";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEstadoCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoIncialCaja;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCierreCaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
    }
}