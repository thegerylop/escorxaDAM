namespace Balança
{
    partial class Balança
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
            this.btnPesar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPes = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPesar
            // 
            this.btnPesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesar.Location = new System.Drawing.Point(66, 77);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(75, 28);
            this.btnPesar.TabIndex = 2;
            this.btnPesar.Text = "PESAR";
            this.btnPesar.UseVisualStyleBackColor = true;
            this.btnPesar.Click += new System.EventHandler(this.btnPesar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "PES:";
            // 
            // txtPes
            // 
            this.txtPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPes.Location = new System.Drawing.Point(230, 76);
            this.txtPes.Multiline = true;
            this.txtPes.Name = "txtPes";
            this.txtPes.ReadOnly = true;
            this.txtPes.Size = new System.Drawing.Size(253, 29);
            this.txtPes.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(396, 134);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 29);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Balança
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 214);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesar);
            this.Name = "Balança";
            this.Text = "Balança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPes;
        private System.Windows.Forms.Button btnEnviar;
    }
}

