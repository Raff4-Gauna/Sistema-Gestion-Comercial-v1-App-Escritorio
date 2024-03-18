
namespace CapaPresentación.FomsModulos
{
    partial class frmLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicencia));
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btningresar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveUnica = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 20;
            this.btncancelar.Location = new System.Drawing.Point(158, 127);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(104, 29);
            this.btncancelar.TabIndex = 111;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.Black;
            this.btningresar.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
            this.btningresar.IconColor = System.Drawing.Color.Black;
            this.btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btningresar.IconSize = 20;
            this.btningresar.Location = new System.Drawing.Point(45, 127);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 29);
            this.btningresar.TabIndex = 110;
            this.btningresar.Text = "Ingresar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 21);
            this.label2.TabIndex = 109;
            this.label2.Text = "SOLO PERSONAL AUTORIZADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(46, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Contraseña";
            // 
            // txtClaveUnica
            // 
            this.txtClaveUnica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtClaveUnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveUnica.Location = new System.Drawing.Point(49, 65);
            this.txtClaveUnica.Name = "txtClaveUnica";
            this.txtClaveUnica.PasswordChar = '*';
            this.txtClaveUnica.Size = new System.Drawing.Size(213, 32);
            this.txtClaveUnica.TabIndex = 107;
            // 
            // frmLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(317, 167);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClaveUnica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmLicencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btningresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveUnica;
    }
}