
namespace CapaPresentación.MdLicencia
{
    partial class frmAjustesLicencia
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
            this.btnEstablecer = new FontAwesome.Sharp.IconButton();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiasDiferenciaActual = new System.Windows.Forms.Label();
            this.lblFechaInicioActual = new System.Windows.Forms.Label();
            this.lblFechaFinActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEstablecer
            // 
            this.btnEstablecer.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEstablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecer.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnEstablecer.IconColor = System.Drawing.Color.Black;
            this.btnEstablecer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstablecer.IconSize = 25;
            this.btnEstablecer.Location = new System.Drawing.Point(497, 39);
            this.btnEstablecer.Name = "btnEstablecer";
            this.btnEstablecer.Size = new System.Drawing.Size(135, 36);
            this.btnEstablecer.TabIndex = 246;
            this.btnEstablecer.Text = "Establecer";
            this.btnEstablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstablecer.UseVisualStyleBackColor = false;
            this.btnEstablecer.Click += new System.EventHandler(this.btnEstablecer_Click);
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(347, 49);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(134, 26);
            this.txtfechafin.TabIndex = 245;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(117, 49);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(134, 26);
            this.txtfechainicio.TabIndex = 243;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 244;
            this.label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 242;
            this.label3.Text = "Fecha Fin:";
            // 
            // lblDiasDiferenciaActual
            // 
            this.lblDiasDiferenciaActual.AutoSize = true;
            this.lblDiasDiferenciaActual.BackColor = System.Drawing.Color.Black;
            this.lblDiasDiferenciaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasDiferenciaActual.ForeColor = System.Drawing.Color.Lime;
            this.lblDiasDiferenciaActual.Location = new System.Drawing.Point(176, 106);
            this.lblDiasDiferenciaActual.Name = "lblDiasDiferenciaActual";
            this.lblDiasDiferenciaActual.Size = new System.Drawing.Size(20, 29);
            this.lblDiasDiferenciaActual.TabIndex = 250;
            this.lblDiasDiferenciaActual.Text = ".";
            // 
            // lblFechaInicioActual
            // 
            this.lblFechaInicioActual.AutoSize = true;
            this.lblFechaInicioActual.BackColor = System.Drawing.Color.Black;
            this.lblFechaInicioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioActual.ForeColor = System.Drawing.Color.Lime;
            this.lblFechaInicioActual.Location = new System.Drawing.Point(176, 147);
            this.lblFechaInicioActual.Name = "lblFechaInicioActual";
            this.lblFechaInicioActual.Size = new System.Drawing.Size(20, 29);
            this.lblFechaInicioActual.TabIndex = 251;
            this.lblFechaInicioActual.Text = ".";
            // 
            // lblFechaFinActual
            // 
            this.lblFechaFinActual.AutoSize = true;
            this.lblFechaFinActual.BackColor = System.Drawing.Color.Black;
            this.lblFechaFinActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinActual.ForeColor = System.Drawing.Color.Lime;
            this.lblFechaFinActual.Location = new System.Drawing.Point(176, 186);
            this.lblFechaFinActual.Name = "lblFechaFinActual";
            this.lblFechaFinActual.Size = new System.Drawing.Size(20, 29);
            this.lblFechaFinActual.TabIndex = 252;
            this.lblFechaFinActual.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(97, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 21);
            this.label2.TabIndex = 253;
            this.label2.Text = "RENOVAR TIEMPO DE USO DEL SISTEMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 254;
            this.label1.Text = "Dias de Uso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 255;
            this.label5.Text = "Fecha Inicio Establecida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 256;
            this.label6.Text = "Fecha Fin Establecida:";
            // 
            // frmAjustesLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 221);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaFinActual);
            this.Controls.Add(this.lblFechaInicioActual);
            this.Controls.Add(this.lblDiasDiferenciaActual);
            this.Controls.Add(this.btnEstablecer);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjustesLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTIVAR PRODUCTO";
            this.Load += new System.EventHandler(this.frmAjustesLicencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEstablecer;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiasDiferenciaActual;
        private System.Windows.Forms.Label lblFechaInicioActual;
        private System.Windows.Forms.Label lblFechaFinActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}