namespace GestioProcessos
{
    partial class Processat_Inicial
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
            if(disposing && (components != null))
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
            this.txtBoxUsuari = new CustomControl.CustomTextBox();
            this.txtBoxLot = new CustomControl.CustomTextBox();
            this.txtBoxId = new CustomControl.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.AnimalsGrid = new System.Windows.Forms.DataGridView();
            this.numLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUsuari
            // 
            this.txtBoxUsuari.Location = new System.Drawing.Point(686, 423);
            this.txtBoxUsuari.Name = "txtBoxUsuari";
            this.txtBoxUsuari.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxUsuari.Placeholder = null;
            this.txtBoxUsuari.Size = new System.Drawing.Size(161, 20);
            this.txtBoxUsuari.TabIndex = 102;
            this.txtBoxUsuari.Tag = "Nom";
            // 
            // txtBoxLot
            // 
            this.txtBoxLot.Location = new System.Drawing.Point(686, 311);
            this.txtBoxLot.Name = "txtBoxLot";
            this.txtBoxLot.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxLot.Placeholder = null;
            this.txtBoxLot.Size = new System.Drawing.Size(161, 20);
            this.txtBoxLot.TabIndex = 101;
            this.txtBoxLot.Tag = "Nom";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(172, 419);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxId.Placeholder = null;
            this.txtBoxId.Size = new System.Drawing.Size(161, 20);
            this.txtBoxId.TabIndex = 100;
            this.txtBoxId.Tag = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Pes del canal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 16);
            this.label7.TabIndex = 98;
            this.label7.Text = "Documentació d\'Identificació Boví:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Numero Carril:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Usuari:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 104;
            this.label13.Text = "Processat Inicial";
            // 
            // customTextBox1
            // 
            this.customTextBox1.Location = new System.Drawing.Point(172, 308);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.Size = new System.Drawing.Size(161, 20);
            this.customTextBox1.TabIndex = 108;
            this.customTextBox1.Tag = "Nom";
            // 
            // AnimalsGrid
            // 
            this.AnimalsGrid.AllowUserToAddRows = false;
            this.AnimalsGrid.AllowUserToDeleteRows = false;
            this.AnimalsGrid.AllowUserToResizeColumns = false;
            this.AnimalsGrid.AllowUserToResizeRows = false;
            this.AnimalsGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnimalsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AnimalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimalsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLot,
            this.estat});
            this.AnimalsGrid.Location = new System.Drawing.Point(97, 85);
            this.AnimalsGrid.Name = "AnimalsGrid";
            this.AnimalsGrid.Size = new System.Drawing.Size(750, 162);
            this.AnimalsGrid.TabIndex = 109;
            // 
            // numLot
            // 
            this.numLot.HeaderText = "Num. Lot";
            this.numLot.Name = "numLot";
            this.numLot.ReadOnly = true;
            // 
            // estat
            // 
            this.estat.HeaderText = "Estat";
            this.estat.Name = "estat";
            this.estat.ReadOnly = true;
            // 
            // Processat_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.AnimalsGrid);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxUsuari);
            this.Controls.Add(this.txtBoxLot);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Processat_Inicial";
            this.Text = "Processat_Inicial";
            this.Load += new System.EventHandler(this.Processat_Inicial_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtBoxId, 0);
            this.Controls.SetChildIndex(this.txtBoxLot, 0);
            this.Controls.SetChildIndex(this.txtBoxUsuari, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.customTextBox1, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.AnimalsGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControl.CustomTextBox txtBoxUsuari;
        private CustomControl.CustomTextBox txtBoxLot;
        private CustomControl.CustomTextBox txtBoxId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private CustomControl.CustomTextBox customTextBox1;
        private System.Windows.Forms.DataGridView AnimalsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn estat;
    }
}