
namespace Navegador_V4._0
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorFechadesdeMasRecienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butBuscar = new System.Windows.Forms.Button();
            this.butAtras = new System.Windows.Forms.Button();
            this.butAdelante = new System.Windows.Forms.Button();
            this.ventanaGoogle = new System.Windows.Forms.WebBrowser();
            this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(692, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarPorFechadesdeMasRecienteToolStripMenuItem,
            this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // ordenarPorFechadesdeMasRecienteToolStripMenuItem
            // 
            this.ordenarPorFechadesdeMasRecienteToolStripMenuItem.Name = "ordenarPorFechadesdeMasRecienteToolStripMenuItem";
            this.ordenarPorFechadesdeMasRecienteToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.ordenarPorFechadesdeMasRecienteToolStripMenuItem.Text = "Ordenar por fecha(desde mas reciente)";
            this.ordenarPorFechadesdeMasRecienteToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorFechadesdeMasRecienteToolStripMenuItem_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.Location = new System.Drawing.Point(890, 3);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(75, 23);
            this.butBuscar.TabIndex = 2;
            this.butBuscar.Text = "Ir";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // butAtras
            // 
            this.butAtras.Location = new System.Drawing.Point(85, 1);
            this.butAtras.Name = "butAtras";
            this.butAtras.Size = new System.Drawing.Size(42, 23);
            this.butAtras.TabIndex = 3;
            this.butAtras.Text = "<<";
            this.butAtras.UseVisualStyleBackColor = true;
            this.butAtras.Click += new System.EventHandler(this.butAtras_Click);
            // 
            // butAdelante
            // 
            this.butAdelante.Location = new System.Drawing.Point(133, 1);
            this.butAdelante.Name = "butAdelante";
            this.butAdelante.Size = new System.Drawing.Size(42, 23);
            this.butAdelante.TabIndex = 4;
            this.butAdelante.Text = ">>";
            this.butAdelante.UseVisualStyleBackColor = true;
            this.butAdelante.Click += new System.EventHandler(this.butAdelante_Click);
            // 
            // ventanaGoogle
            // 
            this.ventanaGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ventanaGoogle.Location = new System.Drawing.Point(0, 32);
            this.ventanaGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.ventanaGoogle.Name = "ventanaGoogle";
            this.ventanaGoogle.Size = new System.Drawing.Size(988, 534);
            this.ventanaGoogle.TabIndex = 5;
            // 
            // ordenarPorFechadesdeMasAntiguoToolStripMenuItem
            // 
            this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem.Name = "ordenarPorFechadesdeMasAntiguoToolStripMenuItem";
            this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem.Text = "Ordenar por fecha(desde mas antiguo)";
            this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorFechadesdeMasAntiguoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 564);
            this.Controls.Add(this.ventanaGoogle);
            this.Controls.Add(this.butAdelante);
            this.Controls.Add(this.butAtras);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorFechadesdeMasRecienteToolStripMenuItem;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Button butAtras;
        private System.Windows.Forms.Button butAdelante;
        private System.Windows.Forms.WebBrowser ventanaGoogle;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorFechadesdeMasAntiguoToolStripMenuItem;
    }
}

