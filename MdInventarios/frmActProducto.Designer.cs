
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActProducto));
            this.txtcodigobarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbldescripciongeneral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpreciofinal = new System.Windows.Forms.TextBox();
            this.btnlimpiarcampos = new FontAwesome.Sharp.IconButton();
            this.btnactualizarprod = new FontAwesome.Sharp.IconButton();
            this.lblfechacaducidad = new System.Windows.Forms.Label();
            this.txtstockexistente = new System.Windows.Forms.TextBox();
            this.lblprecioactual = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblubicacionproducto = new System.Windows.Forms.Label();
            this.lblfechavencimiento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblstockexistente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtcodigobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarra.Location = new System.Drawing.Point(133, 27);
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(284, 26);
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
            this.label10.Location = new System.Drawing.Point(130, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 18);
            this.label10.TabIndex = 111;
            this.label10.Text = "Código de Barra ";
            // 
            // lbldescripciongeneral
            // 
            this.lbldescripciongeneral.AutoSize = true;
            this.lbldescripciongeneral.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbldescripciongeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripciongeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbldescripciongeneral.Location = new System.Drawing.Point(4, 18);
            this.lbldescripciongeneral.Name = "lbldescripciongeneral";
            this.lbldescripciongeneral.Size = new System.Drawing.Size(11, 13);
            this.lbldescripciongeneral.TabIndex = 114;
            this.lbldescripciongeneral.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 143;
            this.label6.Text = "Vencimiento: ";
            this.label6.Visible = false;
            // 
            // txtpreciofinal
            // 
            this.txtpreciofinal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpreciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciofinal.Location = new System.Drawing.Point(6, 19);
            this.txtpreciofinal.Multiline = true;
            this.txtpreciofinal.Name = "txtpreciofinal";
            this.txtpreciofinal.Size = new System.Drawing.Size(177, 44);
            this.txtpreciofinal.TabIndex = 147;
            this.txtpreciofinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciofinal_KeyPress);
            this.txtpreciofinal.Leave += new System.EventHandler(this.txtpreciofinal_Leave);
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
            this.btnlimpiarcampos.Location = new System.Drawing.Point(128, 276);
            this.btnlimpiarcampos.Name = "btnlimpiarcampos";
            this.btnlimpiarcampos.Size = new System.Drawing.Size(173, 30);
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
            this.btnactualizarprod.Location = new System.Drawing.Point(334, 276);
            this.btnactualizarprod.Name = "btnactualizarprod";
            this.btnactualizarprod.Size = new System.Drawing.Size(173, 30);
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
            this.lblfechacaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblfechacaducidad.ForeColor = System.Drawing.Color.Black;
            this.lblfechacaducidad.Location = new System.Drawing.Point(183, 179);
            this.lblfechacaducidad.Name = "lblfechacaducidad";
            this.lblfechacaducidad.Size = new System.Drawing.Size(106, 13);
            this.lblfechacaducidad.TabIndex = 175;
            this.lblfechacaducidad.Text = "Fecha de Caducidad";
            this.lblfechacaducidad.Visible = false;
            // 
            // txtstockexistente
            // 
            this.txtstockexistente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstockexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockexistente.Location = new System.Drawing.Point(6, 19);
            this.txtstockexistente.Name = "txtstockexistente";
            this.txtstockexistente.Size = new System.Drawing.Size(126, 40);
            this.txtstockexistente.TabIndex = 178;
            this.txtstockexistente.Text = "0";
            this.txtstockexistente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstockexistente_KeyPress);
            // 
            // lblprecioactual
            // 
            this.lblprecioactual.AutoSize = true;
            this.lblprecioactual.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblprecioactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblprecioactual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblprecioactual.Location = new System.Drawing.Point(3, 16);
            this.lblprecioactual.Name = "lblprecioactual";
            this.lblprecioactual.Size = new System.Drawing.Size(16, 24);
            this.lblprecioactual.TabIndex = 179;
            this.lblprecioactual.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(15, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 180;
            this.label13.Text = "Código ";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(12, 25);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(115, 26);
            this.txtcodigo.TabIndex = 181;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblubicacionproducto
            // 
            this.lblubicacionproducto.AutoSize = true;
            this.lblubicacionproducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblubicacionproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubicacionproducto.ForeColor = System.Drawing.Color.Black;
            this.lblubicacionproducto.Location = new System.Drawing.Point(167, 179);
            this.lblubicacionproducto.Name = "lblubicacionproducto";
            this.lblubicacionproducto.Size = new System.Drawing.Size(10, 13);
            this.lblubicacionproducto.TabIndex = 182;
            this.lblubicacionproducto.Text = ".";
            this.lblubicacionproducto.Visible = false;
            // 
            // lblfechavencimiento
            // 
            this.lblfechavencimiento.AutoSize = true;
            this.lblfechavencimiento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblfechavencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechavencimiento.ForeColor = System.Drawing.Color.Black;
            this.lblfechavencimiento.Location = new System.Drawing.Point(78, 178);
            this.lblfechavencimiento.Name = "lblfechavencimiento";
            this.lblfechavencimiento.Size = new System.Drawing.Size(10, 13);
            this.lblfechavencimiento.TabIndex = 183;
            this.lblfechavencimiento.Text = ".";
            this.lblfechavencimiento.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblfechavencimiento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblubicacionproducto);
            this.groupBox2.Controls.Add(this.lblfechacaducidad);
            this.groupBox2.Controls.Add(this.txtindice);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 191);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del Producto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblprecioactual);
            this.groupBox4.Location = new System.Drawing.Point(6, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 45);
            this.groupBox4.TabIndex = 193;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PVP Actual";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblstockexistente);
            this.groupBox3.Location = new System.Drawing.Point(6, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 45);
            this.groupBox3.TabIndex = 192;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock Existente";
            // 
            // lblstockexistente
            // 
            this.lblstockexistente.AutoSize = true;
            this.lblstockexistente.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblstockexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblstockexistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblstockexistente.Location = new System.Drawing.Point(3, 16);
            this.lblstockexistente.Name = "lblstockexistente";
            this.lblstockexistente.Size = new System.Drawing.Size(16, 24);
            this.lblstockexistente.TabIndex = 190;
            this.lblstockexistente.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldescripciongeneral);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 45);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 188;
            this.label2.Text = "Ubic del Prod:";
            this.label2.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(299, 163);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 190;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(331, 163);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 189;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtstockexistente);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(444, 78);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 69);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actualizar Stock";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightYellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(436, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 202);
            this.textBox1.TabIndex = 191;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtpreciofinal);
            this.groupBox5.Location = new System.Drawing.Point(443, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(191, 69);
            this.groupBox5.TabIndex = 192;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actualizar Precio Venta";
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(551, 21);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(76, 32);
            this.btnbuscarproducto.TabIndex = 193;
            this.btnbuscarproducto.Text = "(F10)";
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtidproducto
            // 
            this.txtidproducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtidproducto.Location = new System.Drawing.Point(513, 286);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(32, 20);
            this.txtidproducto.TabIndex = 194;
            this.txtidproducto.Visible = false;
            // 
            // frmActProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 321);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcodigobarra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnlimpiarcampos);
            this.Controls.Add(this.btnactualizarprod);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigobarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbldescripciongeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpreciofinal;
        private FontAwesome.Sharp.IconButton btnlimpiarcampos;
        private FontAwesome.Sharp.IconButton btnactualizarprod;
        private System.Windows.Forms.Label lblfechacaducidad;
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
        private System.Windows.Forms.Label lblstockexistente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
    }
}