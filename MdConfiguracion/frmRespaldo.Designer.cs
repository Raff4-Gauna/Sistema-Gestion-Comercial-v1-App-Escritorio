
namespace CapaPresentación.MdConfiguracion
{
    partial class frmRespaldo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRespaldo = new FontAwesome.Sharp.IconButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSeleccionarUbic = new FontAwesome.Sharp.IconButton();
            this.bntRestaurar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeleccionarUbi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUbicacionActual = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para mantener la seguridad de nuestro sistema, es vital generar un respaldo de da" +
    "tos. \r\nEsto asegura que estemos preparados ante posibles pérdidas por fallas téc" +
    "nicas.\r\n";
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldo.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnRespaldo.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRespaldo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRespaldo.IconSize = 50;
            this.btnRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldo.Location = new System.Drawing.Point(220, 119);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Size = new System.Drawing.Size(454, 103);
            this.btnRespaldo.TabIndex = 1;
            this.btnRespaldo.Text = "Generar un Respaldo de la Base de Datos";
            this.btnRespaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldo.UseVisualStyleBackColor = false;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(880, 487);
            this.tabControl.TabIndex = 226;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRespaldo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Guardar Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(202, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ejemplo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(202, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Backup_18-07-18-12-2023.bak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(202, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "El respaldo se va a guardar:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(202, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Backup_Hora-Minuto-Dia-Mes-Año.bak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(202, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recomendable hacerlo una vez por semana o una vez al mes.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSeleccionarUbic);
            this.tabPage2.Controls.Add(this.bntRestaurar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSeleccionarUbi);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtUbicacionActual);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restaurar datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarUbic
            // 
            this.btnSeleccionarUbic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSeleccionarUbic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarUbic.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.btnSeleccionarUbic.IconColor = System.Drawing.Color.Black;
            this.btnSeleccionarUbic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarUbic.IconSize = 40;
            this.btnSeleccionarUbic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarUbic.Location = new System.Drawing.Point(560, 246);
            this.btnSeleccionarUbic.Name = "btnSeleccionarUbic";
            this.btnSeleccionarUbic.Size = new System.Drawing.Size(196, 43);
            this.btnSeleccionarUbic.TabIndex = 2;
            this.btnSeleccionarUbic.Text = "Buscar Copia";
            this.btnSeleccionarUbic.UseVisualStyleBackColor = false;
            this.btnSeleccionarUbic.Click += new System.EventHandler(this.btnSeleccionarUbic_Click);
            // 
            // bntRestaurar
            // 
            this.bntRestaurar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bntRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRestaurar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.bntRestaurar.IconColor = System.Drawing.Color.Black;
            this.bntRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntRestaurar.IconSize = 40;
            this.bntRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntRestaurar.Location = new System.Drawing.Point(560, 310);
            this.bntRestaurar.Name = "bntRestaurar";
            this.bntRestaurar.Size = new System.Drawing.Size(196, 43);
            this.bntRestaurar.TabIndex = 3;
            this.bntRestaurar.Text = "Restaurar Datos";
            this.bntRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntRestaurar.UseVisualStyleBackColor = false;
            this.bntRestaurar.Click += new System.EventHandler(this.bntRestaurar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Introduzca una copia generada anteriormente";
            // 
            // txtSeleccionarUbi
            // 
            this.txtSeleccionarUbi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSeleccionarUbi.Enabled = false;
            this.txtSeleccionarUbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeleccionarUbi.Location = new System.Drawing.Point(105, 251);
            this.txtSeleccionarUbi.Name = "txtSeleccionarUbi";
            this.txtSeleccionarUbi.Size = new System.Drawing.Size(408, 29);
            this.txtSeleccionarUbi.TabIndex = 6;
            this.txtSeleccionarUbi.TextChanged += new System.EventHandler(this.txtSeleccionarUbi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(714, 20);
            this.label4.TabIndex = 224;
            this.label4.Text = "Nuestro sistema cuenta con la posiblidad de restaurar los datos, busque el ultimo" +
    " respaldo de datos.\r\n";
            // 
            // txtUbicacionActual
            // 
            this.txtUbicacionActual.Location = new System.Drawing.Point(113, 317);
            this.txtUbicacionActual.Name = "txtUbicacionActual";
            this.txtUbicacionActual.Size = new System.Drawing.Size(318, 26);
            this.txtUbicacionActual.TabIndex = 7;
            this.txtUbicacionActual.Visible = false;
            // 
            // frmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 511);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRespaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldo de Datos";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnRespaldo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton btnSeleccionarUbic;
        private FontAwesome.Sharp.IconButton bntRestaurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUbicacionActual;
        private System.Windows.Forms.TextBox txtSeleccionarUbi;
    }
}