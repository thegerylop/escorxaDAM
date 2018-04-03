namespace ComunitatsAutonomes
{
    partial class ComunitatsAutonomes
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
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.customTextBox2 = new CustomControl.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(248, 156);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(138, 20);
            this.customTextBox1.TabIndex = 39;
            this.customTextBox1.Tag = "nomComunitatAutonoma";
            // 
            // customTextBox2
            // 
            this.customTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox2.Location = new System.Drawing.Point(248, 202);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox2.Placeholder = null;
            this.customTextBox2.Size = new System.Drawing.Size(138, 20);
            this.customTextBox2.TabIndex = 40;
            this.customTextBox2.Tag = "abreviacioComunitatAutonoma";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nom comunitat :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Codi comunitat :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Comunitats autonomes";
            // 
            // ComunitatsAutonomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1211, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Name = "ComunitatsAutonomes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComunitatsAutonomes_Load);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnAfegir, 0);
            this.Controls.SetChildIndex(this.customTextBox1, 0);
            this.Controls.SetChildIndex(this.customTextBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.CustomTextBox customTextBox1;
        private CustomControl.CustomTextBox customTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
