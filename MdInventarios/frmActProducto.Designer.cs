
namespace CapaPresentación.MdInventarios
{
    partial class frmActProducto
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
            this.txtcodigobarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldescripciongeneral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtpreciofinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlimpiarcampos = new FontAwesome.Sharp.IconButton();
            this.btnactualizarprod = new FontAwesome.Sharp.IconButton();
            this.lblfechacaducidad = new System.Windows.Forms.Label();
            this.lblstockexistente = new System.Windows.Forms.Label();
            this.txtstockexistente = new System.Windows.Forms.TextBox();
            this.lblprecioactual = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblubicacionproducto = new System.Windows.Forms.Label();
            this.lblfechavencimiento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtcodigobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarra.Location = new System.Drawing.Point(248, 29);
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(399, 29);
            this.txtcodigobarra.TabIndex = 112;
            this.txtcodigobarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigobarra_KeyDown);
            this.txtcodigobarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigobarra_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(245, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 111;
            this.label10.Text = "Código de Barra *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Descripción Prod: ";
            // 
            // lbldescripciongeneral
            // 
            this.lbldescripciongeneral.AutoSize = true;
            this.lbldescripciongeneral.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbldescripciongeneral.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripciongeneral.ForeColor = System.Drawing.Color.Black;
            this.lbldescripciongeneral.Location = new System.Drawing.Point(209, 32);
            this.lbldescripciongeneral.Name = "lbldescripciongeneral";
            this.lbldescripciongeneral.Size = new System.Drawing.Size(456, 24);
            this.lbldescripciongeneral.TabIndex = 114;
            this.lbldescripciongeneral.Text = "TIPO + MARCA + DESCRIPCIÓN + CAPACIDAD/TAMAÑO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 143;
            this.label6.Text = "Vencimiento: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(53, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 144;
            this.label15.Text = "Actualizar Stock:";
            // 
            // txtpreciofinal
            // 
            this.txtpreciofinal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpreciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciofinal.Location = new System.Drawing.Point(208, 113);
            this.txtpreciofinal.Multiline = true;
            this.txtpreciofinal.Name = "txtpreciofinal";
            this.txtpreciofinal.Size = new System.Drawing.Size(236, 59);
            this.txtpreciofinal.TabIndex = 147;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 146;
            this.label7.Text = "Actualizar Precio Venta:";
            // 
            // btnlimpiarcampos
            // 
            this.btnlimpiarcampos.BackColor = System.Drawing.Color.Wheat;
            this.btnlimpiarcampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarcampos.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarcampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarcampos.IconSize = 18;
            this.btnlimpiarcampos.Location = new System.Drawing.Point(371, 367);
            this.btnlimpiarcampos.Name = "btnlimpiarcampos";
            this.btnlimpiarcampos.Size = new System.Drawing.Size(198, 30);
            this.btnlimpiarcampos.TabIndex = 171;
            this.btnlimpiarcampos.Text = "Limpiar Campos";
            this.btnlimpiarcampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarcampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarcampos.UseVisualStyleBackColor = false;
            this.btnlimpiarcampos.Click += new System.EventHandler(this.btnlimpiarcampos_Click);
            // 
            // btnactualizarprod
            // 
            this.btnactualizarprod.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnactualizarprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarprod.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnactualizarprod.IconColor = System.Drawing.Color.Black;
            this.btnactualizarprod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnactualizarprod.IconSize = 16;
            this.btnactualizarprod.Location = new System.Drawing.Point(111, 367);
            this.btnactualizarprod.Name = "btnactualizarprod";
            this.btnactualizarprod.Size = new System.Drawing.Size(198, 30);
            this.btnactualizarprod.TabIndex = 170;
            this.btnactualizarprod.Text = "Actualizar Producto";
            this.btnactualizarprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizarprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizarprod.UseVisualStyleBackColor = false;
            this.btnactualizarprod.Click += new System.EventHandler(this.btnactualizarprod_Click);
            // 
            // lblfechacaducidad
            // 
            this.lblfechacaducidad.AutoSize = true;
            this.lblfechacaducidad.BackColor = System.Drawing.Color.White;
            this.lblfechacaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechacaducidad.ForeColor = System.Drawing.Color.Black;
            this.lblfechacaducidad.Location = new System.Drawing.Point(279, 237);
            this.lblfechacaducidad.Name = "lblfechacaducidad";
            this.lblfechacaducidad.Size = new System.Drawing.Size(143, 18);
            this.lblfechacaducidad.TabIndex = 175;
            this.lblfechacaducidad.Text = "Fecha de Caducidad";
            // 
            // lblstockexistente
            // 
            this.lblstockexistente.AutoSize = true;
            this.lblstockexistente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblstockexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockexistente.ForeColor = System.Drawing.Color.Black;
            this.lblstockexistente.Location = new System.Drawing.Point(463, 73);
            this.lblstockexistente.Name = "lblstockexistente";
            this.lblstockexistente.Size = new System.Drawing.Size(19, 29);
            this.lblstockexistente.TabIndex = 177;
            this.lblstockexistente.Text = ".";
            // 
            // txtstockexistente
            // 
            this.txtstockexistente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstockexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockexistente.Location = new System.Drawing.Point(208, 75);
            this.txtstockexistente.Name = "txtstockexistente";
            this.txtstockexistente.Size = new System.Drawing.Size(236, 29);
            this.txtstockexistente.TabIndex = 178;
            this.txtstockexistente.Text = "0";
            // 
            // lblprecioactual
            // 
            this.lblprecioactual.AutoSize = true;
            this.lblprecioactual.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblprecioactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecioactual.ForeColor = System.Drawing.Color.Black;
            this.lblprecioactual.Location = new System.Drawing.Point(463, 142);
            this.lblprecioactual.Name = "lblprecioactual";
            this.lblprecioactual.Size = new System.Drawing.Size(19, 29);
            this.lblprecioactual.TabIndex = 179;
            this.lblprecioactual.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(105, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 180;
            this.label13.Text = "Código *";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(103, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(136, 29);
            this.txtcodigo.TabIndex = 181;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            // 
            // lblubicacionproducto
            // 
            this.lblubicacionproducto.AutoSize = true;
            this.lblubicacionproducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblubicacionproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubicacionproducto.ForeColor = System.Drawing.Color.Black;
            this.lblubicacionproducto.Location = new System.Drawing.Point(208, 229);
            this.lblubicacionproducto.Name = "lblubicacionproducto";
            this.lblubicacionproducto.Size = new System.Drawing.Size(19, 29);
            this.lblubicacionproducto.TabIndex = 182;
            this.lblubicacionproducto.Text = ".";
            // 
            // lblfechavencimiento
            // 
            this.lblfechavencimiento.AutoSize = true;
            this.lblfechavencimiento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblfechavencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechavencimiento.ForeColor = System.Drawing.Color.Black;
            this.lblfechavencimiento.Location = new System.Drawing.Point(208, 189);
            this.lblfechavencimiento.Name = "lblfechavencimiento";
            this.lblfechavencimiento.Size = new System.Drawing.Size(19, 29);
            this.lblfechavencimiento.TabIndex = 183;
            this.lblfechavencimiento.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblprecioactual);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblubicacionproducto);
            this.groupBox2.Controls.Add(this.txtpreciofinal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblfechavencimiento);
            this.groupBox2.Controls.Add(this.lbldescripciongeneral);
            this.groupBox2.Controls.Add(this.txtstockexistente);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblstockexistente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 275);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(561, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 190;
            this.label4.Text = "Existente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(561, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 189;
            this.label3.Text = "PVP Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(74, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 188;
            this.label2.Text = "Ubic del Prod:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(586, 365);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 190;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(618, 365);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 189;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // frmActProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 412);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcodigobarra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblfechacaducidad);
            this.Controls.Add(this.btnlimpiarcampos);
            this.Controls.Add(this.btnactualizarprod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Producto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmActProducto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigobarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescripciongeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtpreciofinal;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnlimpiarcampos;
        private FontAwesome.Sharp.IconButton btnactualizarprod;
        private System.Windows.Forms.Label lblfechacaducidad;
        private System.Windows.Forms.Label lblstockexistente;
        private System.Windows.Forms.TextBox txtstockexistente;
        private System.Windows.Forms.Label lblprecioactual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblubicacionproducto;
        private System.Windows.Forms.Label lblfechavencimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}