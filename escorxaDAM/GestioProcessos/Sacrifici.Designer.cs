namespace GestioProcessos
{
    partial class Sacrifici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sacrifici));
            this.gridAnimals = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFinalitzar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSacrifici = new CustomControl.CustomTextBox();
            this.Usuaris = new CustomControl.comboBox();
            this.txtBoxNLot = new CustomControl.CustomTextBox();
            this.txtBoxIncidencies = new CustomControl.CustomTextBox();
            this.cBoxAtordiment = new CustomControl.comboBox();
            this.txtBoxBox = new CustomControl.CustomTextBox();
            this.txtBoxEstat = new CustomControl.CustomTextBox();
            this.txtBoxAparell = new CustomControl.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimals)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(837, 621);
            this.btnInserir.Visible = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gridAnimals
            // 
            this.gridAnimals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnimals.Location = new System.Drawing.Point(190, 72);
            this.gridAnimals.Name = "gridAnimals";
            this.gridAnimals.Size = new System.Drawing.Size(306, 198);
            this.gridAnimals.TabIndex = 109;
            this.gridAnimals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAnimals_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(35, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 218);
            this.panel1.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Incoming RIP";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 108;
            this.label13.Text = "Sacrifici";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 114;
            this.label8.Text = "Estat:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 113;
            this.label7.Text = "Identficador de l\'aparell:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 112;
            this.label2.Text = "Usuari:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "Box d\'immovilització:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Sistema d\'atordiment:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "Dades";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(40, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 1);
            this.panel2.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 125;
            this.label6.Text = "Incidències:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 127;
            this.label9.Text = "Num. Lot:";
            // 
            // btnFinalitzar
            // 
            this.btnFinalitzar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalitzar.BackColor = System.Drawing.Color.DimGray;
            this.btnFinalitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalitzar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnFinalitzar.ForeColor = System.Drawing.Color.White;
            this.btnFinalitzar.Location = new System.Drawing.Point(837, 621);
            this.btnFinalitzar.Name = "btnFinalitzar";
            this.btnFinalitzar.Size = new System.Drawing.Size(132, 26);
            this.btnFinalitzar.TabIndex = 130;
            this.btnFinalitzar.Text = "Finalitzar";
            this.btnFinalitzar.UseVisualStyleBackColor = false;
            this.btnFinalitzar.Visible = false;
            this.btnFinalitzar.Click += new System.EventHandler(this.btnFinalitzar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 131;
            this.label10.Text = "Dia sacrifici :";
            // 
            // dataSacrifici
            // 
            this.dataSacrifici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataSacrifici.Location = new System.Drawing.Point(589, 598);
            this.dataSacrifici.Name = "dataSacrifici";
            this.dataSacrifici.Options = CustomControl.CustomTextBox.Items.Text;
            this.dataSacrifici.Placeholder = null;
            this.dataSacrifici.ReadOnly = true;
            this.dataSacrifici.Size = new System.Drawing.Size(161, 20);
            this.dataSacrifici.TabIndex = 132;
            this.dataSacrifici.Tag = "Nom";
            // 
            // Usuaris
            // 
            this.Usuaris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usuaris.Enabled = false;
            this.Usuaris.FormattingEnabled = true;
            this.Usuaris.Location = new System.Drawing.Point(181, 467);
            this.Usuaris.Name = "Usuaris";
            this.Usuaris.Reference = null;
            this.Usuaris.Size = new System.Drawing.Size(163, 21);
            this.Usuaris.TabIndex = 129;
            // 
            // txtBoxNLot
            // 
            this.txtBoxNLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNLot.Location = new System.Drawing.Point(589, 533);
            this.txtBoxNLot.Name = "txtBoxNLot";
            this.txtBoxNLot.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxNLot.Placeholder = null;
            this.txtBoxNLot.ReadOnly = true;
            this.txtBoxNLot.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNLot.TabIndex = 128;
            this.txtBoxNLot.Tag = "Nom";
            // 
            // txtBoxIncidencies
            // 
            this.txtBoxIncidencies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxIncidencies.Location = new System.Drawing.Point(183, 598);
            this.txtBoxIncidencies.Name = "txtBoxIncidencies";
            this.txtBoxIncidencies.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxIncidencies.Placeholder = null;
            this.txtBoxIncidencies.Size = new System.Drawing.Size(161, 20);
            this.txtBoxIncidencies.TabIndex = 126;
            this.txtBoxIncidencies.Tag = "Nom";
            // 
            // cBoxAtordiment
            // 
            this.cBoxAtordiment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxAtordiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAtordiment.FormattingEnabled = true;
            this.cBoxAtordiment.Location = new System.Drawing.Point(183, 532);
            this.cBoxAtordiment.Name = "cBoxAtordiment";
            this.cBoxAtordiment.Reference = null;
            this.cBoxAtordiment.Size = new System.Drawing.Size(161, 21);
            this.cBoxAtordiment.TabIndex = 122;
            this.cBoxAtordiment.TextChanged += new System.EventHandler(this.cBoxAtordiment_TextChanged);
            // 
            // txtBoxBox
            // 
            this.txtBoxBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxBox.Location = new System.Drawing.Point(183, 404);
            this.txtBoxBox.Name = "txtBoxBox";
            this.txtBoxBox.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxBox.Placeholder = null;
            this.txtBoxBox.ReadOnly = true;
            this.txtBoxBox.Size = new System.Drawing.Size(161, 20);
            this.txtBoxBox.TabIndex = 118;
            this.txtBoxBox.Tag = "Nom";
            // 
            // txtBoxEstat
            // 
            this.txtBoxEstat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxEstat.Location = new System.Drawing.Point(589, 470);
            this.txtBoxEstat.Name = "txtBoxEstat";
            this.txtBoxEstat.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxEstat.Placeholder = null;
            this.txtBoxEstat.ReadOnly = true;
            this.txtBoxEstat.Size = new System.Drawing.Size(161, 20);
            this.txtBoxEstat.TabIndex = 117;
            this.txtBoxEstat.Tag = "Nom";
            // 
            // txtBoxAparell
            // 
            this.txtBoxAparell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxAparell.Location = new System.Drawing.Point(589, 399);
            this.txtBoxAparell.Name = "txtBoxAparell";
            this.txtBoxAparell.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtBoxAparell.Placeholder = null;
            this.txtBoxAparell.ReadOnly = true;
            this.txtBoxAparell.Size = new System.Drawing.Size(161, 20);
            this.txtBoxAparell.TabIndex = 116;
            this.txtBoxAparell.Tag = "Nom";
            // 
            // Sacrifici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 749);
            this.Controls.Add(this.dataSacrifici);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFinalitzar);
            this.Controls.Add(this.Usuaris);
            this.Controls.Add(this.txtBoxNLot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxIncidencies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxAtordiment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxBox);
            this.Controls.Add(this.txtBoxEstat);
            this.Controls.Add(this.txtBoxAparell);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAnimals);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Sacrifici";
            this.Text = "Sacrifici";
            this.Load += new System.EventHandler(this.Sacrifici_Load);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridAnimals, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtBoxAparell, 0);
            this.Controls.SetChildIndex(this.txtBoxEstat, 0);
            this.Controls.SetChildIndex(this.txtBoxBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cBoxAtordiment, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtBoxIncidencies, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtBoxNLot, 0);
            this.Controls.SetChildIndex(this.Usuaris, 0);
            this.Controls.SetChildIndex(this.btnFinalitzar, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dataSacrifici, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAnimals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private CustomControl.CustomTextBox txtBoxBox;
        private CustomControl.CustomTextBox txtBoxEstat;
        private CustomControl.CustomTextBox txtBoxAparell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private CustomControl.comboBox cBoxAtordiment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private CustomControl.CustomTextBox txtBoxIncidencies;
        private System.Windows.Forms.Label label6;
        private CustomControl.CustomTextBox txtBoxNLot;
        private System.Windows.Forms.Label label9;
        private CustomControl.comboBox Usuaris;
        public System.Windows.Forms.Button btnFinalitzar;
        private CustomControl.CustomTextBox dataSacrifici;
        private System.Windows.Forms.Label label10;
    }
}