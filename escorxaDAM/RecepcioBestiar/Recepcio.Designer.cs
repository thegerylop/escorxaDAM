namespace RecepcioBestiar
{
    partial class Recepcio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userComboBox = new CustomControl.comboBox();
            this.REMO = new CustomControl.CustomTextBox();
            this.ORI = new CustomControl.CustomTextBox();
            this.TOTAN = new CustomControl.CustomTextBox();
            this.dateToday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numLot = new CustomControl.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AnimalsGrid = new System.Windows.Forms.DataGridView();
            this.DIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIB_Mare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LLegirEdi = new System.Windows.Forms.Button();
            this.TRA = new CustomControl.CustomTextBox();
            this.dateSortida = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Usuari Receptor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(74, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Codi REMO";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(74, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Codi REGA";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(592, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Transportista";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.Location = new System.Drawing.Point(489, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Data sortida de l\' explotació";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.Location = new System.Drawing.Point(489, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Data d\'entrada al escorxador";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(74, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Num. Animals";
            // 
            // userComboBox
            // 
            this.userComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(706, 215);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Reference = null;
            this.userComboBox.Size = new System.Drawing.Size(109, 21);
            this.userComboBox.TabIndex = 47;
            // 
            // REMO
            // 
            this.REMO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.REMO.Location = new System.Drawing.Point(194, 177);
            this.REMO.Name = "REMO";
            this.REMO.Options = CustomControl.CustomTextBox.Items.Text;
            this.REMO.Placeholder = null;
            this.REMO.ReadOnly = true;
            this.REMO.Size = new System.Drawing.Size(150, 20);
            this.REMO.TabIndex = 49;
            // 
            // ORI
            // 
            this.ORI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ORI.Location = new System.Drawing.Point(194, 140);
            this.ORI.Name = "ORI";
            this.ORI.Options = CustomControl.CustomTextBox.Items.Text;
            this.ORI.Placeholder = null;
            this.ORI.ReadOnly = true;
            this.ORI.Size = new System.Drawing.Size(150, 20);
            this.ORI.TabIndex = 50;
            // 
            // TOTAN
            // 
            this.TOTAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TOTAN.Location = new System.Drawing.Point(194, 216);
            this.TOTAN.Name = "TOTAN";
            this.TOTAN.Options = CustomControl.CustomTextBox.Items.Text;
            this.TOTAN.Placeholder = null;
            this.TOTAN.ReadOnly = true;
            this.TOTAN.Size = new System.Drawing.Size(52, 20);
            this.TOTAN.TabIndex = 51;
            // 
            // dateToday
            // 
            this.dateToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateToday.Enabled = false;
            this.dateToday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToday.Location = new System.Drawing.Point(706, 177);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(109, 20);
            this.dateToday.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "REMO";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(78, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 1);
            this.panel1.TabIndex = 56;
            // 
            // numLot
            // 
            this.numLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numLot.Location = new System.Drawing.Point(194, 96);
            this.numLot.Name = "numLot";
            this.numLot.Options = CustomControl.CustomTextBox.Items.Text;
            this.numLot.Placeholder = null;
            this.numLot.ReadOnly = true;
            this.numLot.Size = new System.Drawing.Size(150, 20);
            this.numLot.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label10.Location = new System.Drawing.Point(74, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Num. Lot";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(64, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 20);
            this.label15.TabIndex = 68;
            this.label15.Text = "Animals";
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
            this.DIB,
            this.Pais,
            this.Sexe,
            this.Edat,
            this.DIB_Mare});
            this.AnimalsGrid.Location = new System.Drawing.Point(68, 339);
            this.AnimalsGrid.Name = "AnimalsGrid";
            this.AnimalsGrid.Size = new System.Drawing.Size(750, 162);
            this.AnimalsGrid.TabIndex = 69;
            // 
            // DIB
            // 
            this.DIB.HeaderText = "DIB";
            this.DIB.Name = "DIB";
            this.DIB.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            this.Sexe.ReadOnly = true;
            // 
            // Edat
            // 
            this.Edat.HeaderText = "Edad";
            this.Edat.Name = "Edat";
            this.Edat.ReadOnly = true;
            // 
            // DIB_Mare
            // 
            this.DIB_Mare.HeaderText = "DIB Mare";
            this.DIB_Mare.Name = "DIB_Mare";
            this.DIB_Mare.ReadOnly = true;
            // 
            // LLegirEdi
            // 
            this.LLegirEdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LLegirEdi.BackColor = System.Drawing.Color.DimGray;
            this.LLegirEdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LLegirEdi.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.LLegirEdi.ForeColor = System.Drawing.Color.White;
            this.LLegirEdi.Location = new System.Drawing.Point(580, 549);
            this.LLegirEdi.Name = "LLegirEdi";
            this.LLegirEdi.Size = new System.Drawing.Size(132, 26);
            this.LLegirEdi.TabIndex = 71;
            this.LLegirEdi.Text = "Llegir Edi";
            this.LLegirEdi.UseVisualStyleBackColor = false;
            this.LLegirEdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // TRA
            // 
            this.TRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TRA.Location = new System.Drawing.Point(706, 96);
            this.TRA.Name = "TRA";
            this.TRA.Options = CustomControl.CustomTextBox.Items.Text;
            this.TRA.Placeholder = null;
            this.TRA.ReadOnly = true;
            this.TRA.Size = new System.Drawing.Size(112, 20);
            this.TRA.TabIndex = 72;
            // 
            // dateSortida
            // 
            this.dateSortida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateSortida.Enabled = false;
            this.dateSortida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSortida.Location = new System.Drawing.Point(706, 140);
            this.dateSortida.Name = "dateSortida";
            this.dateSortida.Size = new System.Drawing.Size(109, 20);
            this.dateSortida.TabIndex = 53;
            // 
            // Recepcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.TRA);
            this.Controls.Add(this.LLegirEdi);
            this.Controls.Add(this.AnimalsGrid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numLot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.dateSortida);
            this.Controls.Add(this.TOTAN);
            this.Controls.Add(this.ORI);
            this.Controls.Add(this.REMO);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Recepcio";
            this.Text = "Recepcio";
            this.Load += new System.EventHandler(this.Recepcio_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.userComboBox, 0);
            this.Controls.SetChildIndex(this.REMO, 0);
            this.Controls.SetChildIndex(this.ORI, 0);
            this.Controls.SetChildIndex(this.TOTAN, 0);
            this.Controls.SetChildIndex(this.dateSortida, 0);
            this.Controls.SetChildIndex(this.dateToday, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.numLot, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.AnimalsGrid, 0);
            this.Controls.SetChildIndex(this.LLegirEdi, 0);
            this.Controls.SetChildIndex(this.TRA, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomControl.comboBox userComboBox;
        private CustomControl.CustomTextBox REMO;
        private CustomControl.CustomTextBox ORI;
        private CustomControl.CustomTextBox TOTAN;
        private System.Windows.Forms.DateTimePicker dateToday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.CustomTextBox numLot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView AnimalsGrid;
        public System.Windows.Forms.Button LLegirEdi;
        private CustomControl.CustomTextBox TRA;
        private System.Windows.Forms.DateTimePicker dateSortida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIB_Mare;
    }
}