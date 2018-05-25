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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processat_Inicial));
            this.txtBoxPesCanal = new CustomControl.CustomTextBox();
            this.txtBoxCarril = new CustomControl.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gridLots = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.gridAnimalsLot = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuaris = new CustomControl.comboBox();
            this.txtBoxEstat = new CustomControl.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalitzar = new System.Windows.Forms.Button();
            this.txtDIB = new CustomControl.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLots)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimalsLot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtBoxPesCanal
            // 
            this.txtBoxPesCanal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPesCanal.Location = new System.Drawing.Point(617, 342);
            this.txtBoxPesCanal.Name = "txtBoxPesCanal";
            this.txtBoxPesCanal.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxPesCanal.Placeholder = null;
            this.txtBoxPesCanal.ReadOnly = true;
            this.txtBoxPesCanal.Size = new System.Drawing.Size(161, 20);
            this.txtBoxPesCanal.TabIndex = 102;
            this.txtBoxPesCanal.Tag = "Nom";
            // 
            // txtBoxCarril
            // 
            this.txtBoxCarril.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCarril.Location = new System.Drawing.Point(617, 390);
            this.txtBoxCarril.Name = "txtBoxCarril";
            this.txtBoxCarril.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxCarril.Placeholder = null;
            this.txtBoxCarril.ReadOnly = true;
            this.txtBoxCarril.Size = new System.Drawing.Size(161, 20);
            this.txtBoxCarril.TabIndex = 100;
            this.txtBoxCarril.Tag = "Nom";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Pes del canal:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Numero Carril:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 295);
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
            // gridLots
            // 
            this.gridLots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLots.Location = new System.Drawing.Point(127, 130);
            this.gridLots.Name = "gridLots";
            this.gridLots.ReadOnly = true;
            this.gridLots.Size = new System.Drawing.Size(261, 100);
            this.gridLots.TabIndex = 106;
            this.gridLots.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLots_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gridAnimalsLot);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(102, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 148);
            this.panel1.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Animals del Lot";
            // 
            // gridAnimalsLot
            // 
            this.gridAnimalsLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridAnimalsLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnimalsLot.Location = new System.Drawing.Point(336, 36);
            this.gridAnimalsLot.Name = "gridAnimalsLot";
            this.gridAnimalsLot.ReadOnly = true;
            this.gridAnimalsLot.Size = new System.Drawing.Size(340, 100);
            this.gridAnimalsLot.TabIndex = 134;
            this.gridAnimalsLot.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAnimals_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Lots";
            // 
            // Usuaris
            // 
            this.Usuaris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuaris.Enabled = false;
            this.Usuaris.FormattingEnabled = true;
            this.Usuaris.Location = new System.Drawing.Point(227, 292);
            this.Usuaris.Name = "Usuaris";
            this.Usuaris.Reference = null;
            this.Usuaris.Size = new System.Drawing.Size(161, 21);
            this.Usuaris.TabIndex = 108;
            // 
            // txtBoxEstat
            // 
            this.txtBoxEstat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxEstat.Location = new System.Drawing.Point(227, 344);
            this.txtBoxEstat.Name = "txtBoxEstat";
            this.txtBoxEstat.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxEstat.Placeholder = null;
            this.txtBoxEstat.ReadOnly = true;
            this.txtBoxEstat.Size = new System.Drawing.Size(161, 20);
            this.txtBoxEstat.TabIndex = 119;
            this.txtBoxEstat.Tag = "Nom";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Estat:";
            // 
            // btnFinalitzar
            // 
            this.btnFinalitzar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalitzar.BackColor = System.Drawing.Color.DimGray;
            this.btnFinalitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalitzar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnFinalitzar.ForeColor = System.Drawing.Color.White;
            this.btnFinalitzar.Location = new System.Drawing.Point(730, 549);
            this.btnFinalitzar.Name = "btnFinalitzar";
            this.btnFinalitzar.Size = new System.Drawing.Size(132, 26);
            this.btnFinalitzar.TabIndex = 131;
            this.btnFinalitzar.Text = "Finalitzar";
            this.btnFinalitzar.UseVisualStyleBackColor = false;
            this.btnFinalitzar.Visible = false;
            this.btnFinalitzar.Click += new System.EventHandler(this.btnFinalitzar_Click);
            // 
            // txtDIB
            // 
            this.txtDIB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDIB.Location = new System.Drawing.Point(617, 294);
            this.txtDIB.Name = "txtDIB";
            this.txtDIB.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtDIB.Placeholder = null;
            this.txtDIB.ReadOnly = true;
            this.txtDIB.Size = new System.Drawing.Size(161, 20);
            this.txtDIB.TabIndex = 133;
            this.txtDIB.Tag = "Nom";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 132;
            this.label5.Text = "DIB:";
            // 
            // Processat_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.txtDIB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinalitzar);
            this.Controls.Add(this.txtBoxEstat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Usuaris);
            this.Controls.Add(this.gridLots);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxPesCanal);
            this.Controls.Add(this.txtBoxCarril);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Processat_Inicial";
            this.Text = "Processat_Inicial";
            this.Load += new System.EventHandler(this.Processat_Inicial_Load);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtBoxCarril, 0);
            this.Controls.SetChildIndex(this.txtBoxPesCanal, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridLots, 0);
            this.Controls.SetChildIndex(this.Usuaris, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtBoxEstat, 0);
            this.Controls.SetChildIndex(this.btnFinalitzar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDIB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridLots)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimalsLot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControl.CustomTextBox txtBoxPesCanal;
        private CustomControl.CustomTextBox txtBoxCarril;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView gridLots;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CustomControl.comboBox Usuaris;
        private CustomControl.CustomTextBox txtBoxEstat;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnFinalitzar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridAnimalsLot;
        private CustomControl.CustomTextBox txtDIB;
        private System.Windows.Forms.Label label5;
    }
}