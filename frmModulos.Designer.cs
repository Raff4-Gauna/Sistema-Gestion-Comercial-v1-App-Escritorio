
namespace CapaPresentación
{
    partial class frmModulos
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
            this.mdSocios = new FontAwesome.Sharp.IconButton();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.mdConfiguracion = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 34);
            this.label1.TabIndex = 89;
            this.label1.Text = "Sistema de Gestión Comercial ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mdSocios
            // 
            this.mdSocios.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mdSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdSocios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdSocios.ForeColor = System.Drawing.Color.Black;
            this.mdSocios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.mdSocios.IconColor = System.Drawing.Color.Black;
            this.mdSocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdSocios.IconSize = 30;
            this.mdSocios.Location = new System.Drawing.Point(200, 60);
            this.mdSocios.Name = "mdSocios";
            this.mdSocios.Size = new System.Drawing.Size(154, 66);
            this.mdSocios.TabIndex = 91;
            this.mdSocios.Text = "Socios";
            this.mdSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdSocios.UseVisualStyleBackColor = false;
            this.mdSocios.Click += new System.EventHandler(this.mdSocios_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 40;
            this.btnsalir.Location = new System.Drawing.Point(665, 133);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(71, 36);
            this.btnsalir.TabIndex = 90;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // mdConfiguracion
            // 
            this.mdConfiguracion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mdConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.mdConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.mdConfiguracion.IconColor = System.Drawing.Color.Black;
            this.mdConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdConfiguracion.IconSize = 30;
            this.mdConfiguracion.Location = new System.Drawing.Point(40, 60);
            this.mdConfiguracion.Name = "mdConfiguracion";
            this.mdConfiguracion.Size = new System.Drawing.Size(154, 66);
            this.mdConfiguracion.TabIndex = 88;
            this.mdConfiguracion.Text = "Configuraciónes";
            this.mdConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdConfiguracion.UseVisualStyleBackColor = false;
            this.mdConfiguracion.Click += new System.EventHandler(this.mdConfiguracion_Click);
            // 
            // frmModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 181);
            this.Controls.Add(this.mdSocios);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton mdConfiguracion;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton mdSocios;
    }
}