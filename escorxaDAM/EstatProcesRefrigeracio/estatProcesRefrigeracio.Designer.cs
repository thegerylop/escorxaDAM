namespace EstatProcesRefrigeracio
{
    partial class estatProcesRefrigeracio
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
            if(disposing && (components != null))
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Estat refrigeració";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nom estat :";
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(222, 185);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(138, 20);
            this.customTextBox1.TabIndex = 57;
            this.customTextBox1.Tag = "nomEstatRefrigeracio";
            // 
            // estatProcesRefrigeracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1211, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customTextBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "estatProcesRefrigeracio";
            this.Load += new System.EventHandler(this.estatProcesRefrigeracio_Load);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.customTextBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControl.CustomTextBox customTextBox1;
    }
}
