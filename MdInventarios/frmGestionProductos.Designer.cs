
namespace CapaPresentación.MdInventarios
{
    partial class frmGestionProductos
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
            this.treeViewDatos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewDatos
            // 
            this.treeViewDatos.Location = new System.Drawing.Point(38, 33);
            this.treeViewDatos.Name = "treeViewDatos";
            this.treeViewDatos.Size = new System.Drawing.Size(166, 313);
            this.treeViewDatos.TabIndex = 0;
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 662);
            this.Controls.Add(this.treeViewDatos);
            this.Name = "frmGestionProductos";
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.frmGestionProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewDatos;
    }
}