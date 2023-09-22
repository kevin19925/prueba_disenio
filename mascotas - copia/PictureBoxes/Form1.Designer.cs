
namespace PictureBoxes
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
            this.tvParametros = new System.Windows.Forms.TreeView();
            this.tbTransparencia = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.lbAutos = new System.Windows.Forms.ListBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransparencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tvParametros
            // 
            this.tvParametros.Location = new System.Drawing.Point(97, 324);
            this.tvParametros.Name = "tvParametros";
            this.tvParametros.Size = new System.Drawing.Size(182, 173);
            this.tvParametros.TabIndex = 1;
            this.tvParametros.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvParametros_AfterSelect);
            // 
            // tbTransparencia
            // 
            this.tbTransparencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbTransparencia.Location = new System.Drawing.Point(543, 239);
            this.tbTransparencia.Maximum = 4;
            this.tbTransparencia.Minimum = 1;
            this.tbTransparencia.Name = "tbTransparencia";
            this.tbTransparencia.Size = new System.Drawing.Size(227, 45);
            this.tbTransparencia.TabIndex = 2;
            this.tbTransparencia.Value = 1;
            this.tbTransparencia.Scroll += new System.EventHandler(this.tbTransparencia_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista De Autos: ";
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(340, 324);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(430, 173);
            this.lbResultado.TabIndex = 4;
            // 
            // lbAutos
            // 
            this.lbAutos.FormattingEnabled = true;
            this.lbAutos.Location = new System.Drawing.Point(97, 60);
            this.lbAutos.Name = "lbAutos";
            this.lbAutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAutos.ScrollAlwaysVisible = true;
            this.lbAutos.Size = new System.Drawing.Size(397, 173);
            this.lbAutos.TabIndex = 5;
            this.lbAutos.SelectedIndexChanged += new System.EventHandler(this.lbAutos_SelectedIndexChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Location = new System.Drawing.Point(543, 60);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(227, 164);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escoger Filtro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAutos);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTransparencia);
            this.Controls.Add(this.tvParametros);
            this.Controls.Add(this.pbFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTransparencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TreeView tvParametros;
        private System.Windows.Forms.TrackBar tbTransparencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.ListBox lbAutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

