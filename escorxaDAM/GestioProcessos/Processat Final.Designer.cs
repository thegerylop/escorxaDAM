namespace GestioProcessos
{
    partial class Processat_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processat_Final));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxId = new CustomControl.CustomTextBox();
            this.PesBalança = new CustomControl.CustomTextBox();
            this.txtBoxLot = new CustomControl.CustomTextBox();
            this.txtBoxDIB = new CustomControl.CustomTextBox();
            this.txtBoxO2 = new CustomControl.CustomTextBox();
            this.txtBoxCO2 = new CustomControl.CustomTextBox();
            this.txtBoxMG = new CustomControl.CustomTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SafataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.comboTipus = new CustomControl.comboBox();
            this.txtDate = new CustomControl.CustomTextBox();
            this.btnPes = new System.Windows.Forms.Button();
            this.btnAnalisi = new System.Windows.Forms.Button();
            this.txtEstat = new CustomControl.CustomTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDateCad = new CustomControl.CustomTextBox();
            this.txtBoxUsuari = new CustomControl.comboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SafataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Text = "Finalitzar";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tipus:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Safata";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Identificador:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Pes total:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Dia / Hora envasat:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Data caducitat:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "Lot:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Usuari:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 77;
            this.label9.Text = "Pes animals:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(535, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "%de O2:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(523, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "% de CO2:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxId.Location = new System.Drawing.Point(227, 264);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxId.Placeholder = null;
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(161, 20);
            this.txtBoxId.TabIndex = 80;
            this.txtBoxId.Tag = "Nom";
            // 
            // PesBalança
            // 
            this.PesBalança.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PesBalança.Location = new System.Drawing.Point(227, 350);
            this.PesBalança.Name = "PesBalança";
            this.PesBalança.Options = CustomControl.CustomTextBox.Items.Text;
            this.PesBalança.Placeholder = null;
            this.PesBalança.ReadOnly = true;
            this.PesBalança.Size = new System.Drawing.Size(161, 20);
            this.PesBalança.TabIndex = 81;
            this.PesBalança.Tag = "Nom";
            // 
            // txtBoxLot
            // 
            this.txtBoxLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxLot.Location = new System.Drawing.Point(608, 216);
            this.txtBoxLot.Name = "txtBoxLot";
            this.txtBoxLot.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxLot.Placeholder = null;
            this.txtBoxLot.ReadOnly = true;
            this.txtBoxLot.Size = new System.Drawing.Size(161, 20);
            this.txtBoxLot.TabIndex = 84;
            this.txtBoxLot.Tag = "Nom";
            // 
            // txtBoxDIB
            // 
            this.txtBoxDIB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDIB.Location = new System.Drawing.Point(227, 305);
            this.txtBoxDIB.Name = "txtBoxDIB";
            this.txtBoxDIB.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxDIB.Placeholder = null;
            this.txtBoxDIB.ReadOnly = true;
            this.txtBoxDIB.Size = new System.Drawing.Size(161, 20);
            this.txtBoxDIB.TabIndex = 86;
            this.txtBoxDIB.Tag = "Nom";
            // 
            // txtBoxO2
            // 
            this.txtBoxO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxO2.Location = new System.Drawing.Point(608, 349);
            this.txtBoxO2.Name = "txtBoxO2";
            this.txtBoxO2.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxO2.Placeholder = null;
            this.txtBoxO2.ReadOnly = true;
            this.txtBoxO2.Size = new System.Drawing.Size(161, 20);
            this.txtBoxO2.TabIndex = 87;
            this.txtBoxO2.Tag = "Nom";
            // 
            // txtBoxCO2
            // 
            this.txtBoxCO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxCO2.Location = new System.Drawing.Point(608, 391);
            this.txtBoxCO2.Name = "txtBoxCO2";
            this.txtBoxCO2.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxCO2.Placeholder = null;
            this.txtBoxCO2.ReadOnly = true;
            this.txtBoxCO2.Size = new System.Drawing.Size(161, 20);
            this.txtBoxCO2.TabIndex = 88;
            this.txtBoxCO2.Tag = "Nom";
            // 
            // txtBoxMG
            // 
            this.txtBoxMG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMG.Location = new System.Drawing.Point(608, 430);
            this.txtBoxMG.Name = "txtBoxMG";
            this.txtBoxMG.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxMG.Placeholder = null;
            this.txtBoxMG.ReadOnly = true;
            this.txtBoxMG.Size = new System.Drawing.Size(161, 20);
            this.txtBoxMG.TabIndex = 90;
            this.txtBoxMG.Tag = "Nom";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(475, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 16);
            this.label12.TabIndex = 89;
            this.label12.Text = "mg de mioglobina:";
            // 
            // SafataGrid
            // 
            this.SafataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SafataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SafataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SafataGrid.Location = new System.Drawing.Point(227, 87);
            this.SafataGrid.Name = "SafataGrid";
            this.SafataGrid.Size = new System.Drawing.Size(219, 90);
            this.SafataGrid.TabIndex = 91;
            this.SafataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SafataGrid_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(72, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 108);
            this.panel1.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 93;
            this.label13.Text = "Safates pendents";
            // 
            // comboTipus
            // 
            this.comboTipus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTipus.FormattingEnabled = true;
            this.comboTipus.Items.AddRange(new object[] {
            "SN",
            "SF",
            "SE"});
            this.comboTipus.Location = new System.Drawing.Point(227, 215);
            this.comboTipus.Name = "comboTipus";
            this.comboTipus.Reference = null;
            this.comboTipus.Size = new System.Drawing.Size(161, 21);
            this.comboTipus.TabIndex = 95;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.Location = new System.Drawing.Point(227, 391);
            this.txtDate.Name = "txtDate";
            this.txtDate.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtDate.Placeholder = null;
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(161, 20);
            this.txtDate.TabIndex = 99;
            this.txtDate.Tag = "Nom";
            // 
            // btnPes
            // 
            this.btnPes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPes.BackColor = System.Drawing.Color.DimGray;
            this.btnPes.Enabled = false;
            this.btnPes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPes.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnPes.ForeColor = System.Drawing.Color.White;
            this.btnPes.Location = new System.Drawing.Point(422, 549);
            this.btnPes.Name = "btnPes";
            this.btnPes.Size = new System.Drawing.Size(132, 26);
            this.btnPes.TabIndex = 100;
            this.btnPes.Text = "Pesar";
            this.btnPes.UseVisualStyleBackColor = false;
            this.btnPes.Click += new System.EventHandler(this.btnPes_Click);
            // 
            // btnAnalisi
            // 
            this.btnAnalisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnalisi.BackColor = System.Drawing.Color.DimGray;
            this.btnAnalisi.Enabled = false;
            this.btnAnalisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalisi.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnAnalisi.ForeColor = System.Drawing.Color.White;
            this.btnAnalisi.Location = new System.Drawing.Point(577, 549);
            this.btnAnalisi.Name = "btnAnalisi";
            this.btnAnalisi.Size = new System.Drawing.Size(132, 26);
            this.btnAnalisi.TabIndex = 101;
            this.btnAnalisi.Text = "Analisi";
            this.btnAnalisi.UseVisualStyleBackColor = false;
            this.btnAnalisi.Click += new System.EventHandler(this.btnAnalisi_Click);
            // 
            // txtEstat
            // 
            this.txtEstat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstat.Location = new System.Drawing.Point(608, 264);
            this.txtEstat.Name = "txtEstat";
            this.txtEstat.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtEstat.Placeholder = null;
            this.txtEstat.ReadOnly = true;
            this.txtEstat.Size = new System.Drawing.Size(161, 20);
            this.txtEstat.TabIndex = 104;
            this.txtEstat.Tag = "Nom";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(475, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 16);
            this.label14.TabIndex = 103;
            this.label14.Text = "Estat de l\'envasat:";
            // 
            // txtDateCad
            // 
            this.txtDateCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateCad.Location = new System.Drawing.Point(227, 429);
            this.txtDateCad.Name = "txtDateCad";
            this.txtDateCad.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtDateCad.Placeholder = null;
            this.txtDateCad.ReadOnly = true;
            this.txtDateCad.Size = new System.Drawing.Size(161, 20);
            this.txtDateCad.TabIndex = 105;
            this.txtDateCad.Tag = "Nom";
            // 
            // txtBoxUsuari
            // 
            this.txtBoxUsuari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsuari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBoxUsuari.Enabled = false;
            this.txtBoxUsuari.FormattingEnabled = true;
            this.txtBoxUsuari.Location = new System.Drawing.Point(608, 303);
            this.txtBoxUsuari.Name = "txtBoxUsuari";
            this.txtBoxUsuari.Reference = null;
            this.txtBoxUsuari.Size = new System.Drawing.Size(161, 21);
            this.txtBoxUsuari.TabIndex = 106;
            // 
            // Processat_Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.txtBoxUsuari);
            this.Controls.Add(this.txtDateCad);
            this.Controls.Add(this.txtEstat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAnalisi);
            this.Controls.Add(this.btnPes);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.comboTipus);
            this.Controls.Add(this.SafataGrid);
            this.Controls.Add(this.txtBoxMG);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxCO2);
            this.Controls.Add(this.txtBoxO2);
            this.Controls.Add(this.txtBoxDIB);
            this.Controls.Add(this.txtBoxLot);
            this.Controls.Add(this.PesBalança);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Processat_Final";
            this.Text = "Processat_Final";
            this.Load += new System.EventHandler(this.Processat_Final_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtBoxId, 0);
            this.Controls.SetChildIndex(this.PesBalança, 0);
            this.Controls.SetChildIndex(this.txtBoxLot, 0);
            this.Controls.SetChildIndex(this.txtBoxDIB, 0);
            this.Controls.SetChildIndex(this.txtBoxO2, 0);
            this.Controls.SetChildIndex(this.txtBoxCO2, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtBoxMG, 0);
            this.Controls.SetChildIndex(this.SafataGrid, 0);
            this.Controls.SetChildIndex(this.comboTipus, 0);
            this.Controls.SetChildIndex(this.txtDate, 0);
            this.Controls.SetChildIndex(this.btnPes, 0);
            this.Controls.SetChildIndex(this.btnAnalisi, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtEstat, 0);
            this.Controls.SetChildIndex(this.txtDateCad, 0);
            this.Controls.SetChildIndex(this.txtBoxUsuari, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SafataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CustomControl.CustomTextBox txtBoxId;
        private CustomControl.CustomTextBox PesBalança;
        private CustomControl.CustomTextBox txtBoxLot;
        private CustomControl.CustomTextBox txtBoxDIB;
        private CustomControl.CustomTextBox txtBoxO2;
        private CustomControl.CustomTextBox txtBoxCO2;
        private CustomControl.CustomTextBox txtBoxMG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView SafataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private CustomControl.comboBox comboTipus;
        private CustomControl.CustomTextBox txtDate;
        public System.Windows.Forms.Button btnPes;
        public System.Windows.Forms.Button btnAnalisi;
        private CustomControl.CustomTextBox txtEstat;
        private System.Windows.Forms.Label label14;
        private CustomControl.CustomTextBox txtDateCad;
        private CustomControl.comboBox txtBoxUsuari;
    }
}