﻿namespace GestioProcessos
{
    partial class Emmagatzematge
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
            if (disposing && (components != null))
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserIn = new System.Windows.Forms.Label();
            this.lblDataIn = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.txtLot = new CustomControl.CustomTextBox();
            this.txtMaxTemp = new CustomControl.CustomTextBox();
            this.txtMinTemp = new CustomControl.CustomTextBox();
            this.dgwEmmagatzematge = new System.Windows.Forms.DataGridView();
            this.pnlSafates = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEstat = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.txtNumCamFrigo = new CustomControl.CustomTextBox();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnTreure = new System.Windows.Forms.Button();
            this.txtUserIn = new CustomControl.CustomTextBox();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.lblDataOut = new System.Windows.Forms.Label();
            this.gbxNevera = new System.Windows.Forms.GroupBox();
            this.txtEstat = new CustomControl.CustomTextBox();
            this.customTextBox1 = new CustomControl.CustomTextBox();
            this.lblUserOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmmagatzematge)).BeginInit();
            this.pnlSafates.SuspendLayout();
            this.gbxNevera.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(594, 594);
            this.btnInserir.Size = new System.Drawing.Size(199, 26);
            this.btnInserir.TabIndex = 99;
            this.btnInserir.Text = "Posar al refrigerador";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(73, 442);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(132, 16);
            this.lblNumero.TabIndex = 70;
            this.lblNumero.Text = "Nº cambra frigorífica:";
            this.lblNumero.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Emmagatzematge i conservació";
            // 
            // lblUserIn
            // 
            this.lblUserIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserIn.AutoSize = true;
            this.lblUserIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIn.Location = new System.Drawing.Point(106, 486);
            this.lblUserIn.Name = "lblUserIn";
            this.lblUserIn.Size = new System.Drawing.Size(99, 16);
            this.lblUserIn.TabIndex = 71;
            this.lblUserIn.Text = "Usuari entrada:";
            this.lblUserIn.Visible = false;
            // 
            // lblDataIn
            // 
            this.lblDataIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataIn.AutoSize = true;
            this.lblDataIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataIn.Location = new System.Drawing.Point(116, 531);
            this.lblDataIn.Name = "lblDataIn";
            this.lblDataIn.Size = new System.Drawing.Size(89, 16);
            this.lblDataIn.TabIndex = 73;
            this.lblDataIn.Text = "Data entrada:";
            this.lblDataIn.Visible = false;
            // 
            // lblLot
            // 
            this.lblLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLot.AutoSize = true;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Location = new System.Drawing.Point(176, 356);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(29, 16);
            this.lblLot.TabIndex = 75;
            this.lblLot.Text = "Lot:";
            this.lblLot.Visible = false;
            // 
            // lblTempMax
            // 
            this.lblTempMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTempMax.AutoSize = true;
            this.lblTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMax.Location = new System.Drawing.Point(27, 33);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(139, 16);
            this.lblTempMax.TabIndex = 76;
            this.lblTempMax.Text = "Temperatura màxima:";
            this.lblTempMax.Visible = false;
            // 
            // lblTempMin
            // 
            this.lblTempMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTempMin.AutoSize = true;
            this.lblTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMin.Location = new System.Drawing.Point(31, 74);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(135, 16);
            this.lblTempMin.TabIndex = 77;
            this.lblTempMin.Text = "Temperatura mínima:";
            // 
            // txtLot
            // 
            this.txtLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLot.Location = new System.Drawing.Point(227, 355);
            this.txtLot.Name = "txtLot";
            this.txtLot.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtLot.Placeholder = null;
            this.txtLot.ReadOnly = true;
            this.txtLot.Size = new System.Drawing.Size(247, 20);
            this.txtLot.TabIndex = 90;
            this.txtLot.Tag = "Nom";
            this.txtLot.Visible = false;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaxTemp.Location = new System.Drawing.Point(172, 32);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtMaxTemp.Placeholder = null;
            this.txtMaxTemp.ReadOnly = true;
            this.txtMaxTemp.Size = new System.Drawing.Size(265, 20);
            this.txtMaxTemp.TabIndex = 95;
            this.txtMaxTemp.Tag = "Nom";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMinTemp.Location = new System.Drawing.Point(172, 73);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtMinTemp.Placeholder = null;
            this.txtMinTemp.ReadOnly = true;
            this.txtMinTemp.Size = new System.Drawing.Size(265, 20);
            this.txtMinTemp.TabIndex = 96;
            this.txtMinTemp.Tag = "Nom";
            // 
            // dgwEmmagatzematge
            // 
            this.dgwEmmagatzematge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwEmmagatzematge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmmagatzematge.Location = new System.Drawing.Point(227, 117);
            this.dgwEmmagatzematge.Name = "dgwEmmagatzematge";
            this.dgwEmmagatzematge.Size = new System.Drawing.Size(774, 191);
            this.dgwEmmagatzematge.TabIndex = 1;
            this.dgwEmmagatzematge.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmmagatzematge_CellDoubleClick);
            // 
            // pnlSafates
            // 
            this.pnlSafates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSafates.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlSafates.Controls.Add(this.label13);
            this.pnlSafates.Location = new System.Drawing.Point(72, 109);
            this.pnlSafates.Name = "pnlSafates";
            this.pnlSafates.Size = new System.Drawing.Size(942, 209);
            this.pnlSafates.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 93;
            this.label13.Text = "Lots pendents";
            // 
            // lblEstat
            // 
            this.lblEstat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstat.AutoSize = true;
            this.lblEstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstat.Location = new System.Drawing.Point(93, 401);
            this.lblEstat.Name = "lblEstat";
            this.lblEstat.Size = new System.Drawing.Size(112, 16);
            this.lblEstat.TabIndex = 93;
            this.lblEstat.Text = "Estat refrigeració:";
            this.lblEstat.Visible = false;
            // 
            // dateIn
            // 
            this.dateIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIn.Location = new System.Drawing.Point(227, 527);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(247, 20);
            this.dateIn.TabIndex = 94;
            this.dateIn.Visible = false;
            // 
            // txtNumCamFrigo
            // 
            this.txtNumCamFrigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumCamFrigo.Location = new System.Drawing.Point(227, 441);
            this.txtNumCamFrigo.Name = "txtNumCamFrigo";
            this.txtNumCamFrigo.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtNumCamFrigo.Placeholder = null;
            this.txtNumCamFrigo.Size = new System.Drawing.Size(247, 20);
            this.txtNumCamFrigo.TabIndex = 92;
            this.txtNumCamFrigo.Tag = "Nom";
            this.txtNumCamFrigo.Visible = false;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualitzar.BackColor = System.Drawing.Color.DimGray;
            this.btnActualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualitzar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnActualitzar.ForeColor = System.Drawing.Color.White;
            this.btnActualitzar.Location = new System.Drawing.Point(372, 594);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(199, 26);
            this.btnActualitzar.TabIndex = 98;
            this.btnActualitzar.Text = "Actualitzar safates";
            this.btnActualitzar.UseVisualStyleBackColor = false;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnTreure
            // 
            this.btnTreure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTreure.BackColor = System.Drawing.Color.DimGray;
            this.btnTreure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTreure.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnTreure.ForeColor = System.Drawing.Color.White;
            this.btnTreure.Location = new System.Drawing.Point(815, 594);
            this.btnTreure.Name = "btnTreure";
            this.btnTreure.Size = new System.Drawing.Size(199, 26);
            this.btnTreure.TabIndex = 100;
            this.btnTreure.Text = "Treure del refrigerador";
            this.btnTreure.UseVisualStyleBackColor = false;
            this.btnTreure.Click += new System.EventHandler(this.btnTreure_Click);
            // 
            // txtUserIn
            // 
            this.txtUserIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserIn.Location = new System.Drawing.Point(227, 486);
            this.txtUserIn.Name = "txtUserIn";
            this.txtUserIn.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtUserIn.Placeholder = null;
            this.txtUserIn.ReadOnly = true;
            this.txtUserIn.Size = new System.Drawing.Size(247, 20);
            this.txtUserIn.TabIndex = 93;
            this.txtUserIn.Tag = "Nom";
            this.txtUserIn.Visible = false;
            // 
            // dateOut
            // 
            this.dateOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOut.Location = new System.Drawing.Point(172, 159);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(265, 20);
            this.dateOut.TabIndex = 97;
            // 
            // lblDataOut
            // 
            this.lblDataOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataOut.AutoSize = true;
            this.lblDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOut.Location = new System.Drawing.Point(82, 163);
            this.lblDataOut.Name = "lblDataOut";
            this.lblDataOut.Size = new System.Drawing.Size(84, 16);
            this.lblDataOut.TabIndex = 1000;
            this.lblDataOut.Text = "Data sortida:";
            // 
            // gbxNevera
            // 
            this.gbxNevera.Controls.Add(this.txtMaxTemp);
            this.gbxNevera.Controls.Add(this.customTextBox1);
            this.gbxNevera.Controls.Add(this.lblTempMax);
            this.gbxNevera.Controls.Add(this.lblTempMin);
            this.gbxNevera.Controls.Add(this.txtMinTemp);
            this.gbxNevera.Controls.Add(this.lblDataOut);
            this.gbxNevera.Controls.Add(this.dateOut);
            this.gbxNevera.Controls.Add(this.lblUserOut);
            this.gbxNevera.Location = new System.Drawing.Point(564, 355);
            this.gbxNevera.Name = "gbxNevera";
            this.gbxNevera.Size = new System.Drawing.Size(450, 201);
            this.gbxNevera.TabIndex = 1001;
            this.gbxNevera.TabStop = false;
            this.gbxNevera.Text = "Dades refrigeració";
            // 
            // txtEstat
            // 
            this.txtEstat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstat.Location = new System.Drawing.Point(227, 400);
            this.txtEstat.Name = "txtEstat";
            this.txtEstat.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtEstat.Placeholder = null;
            this.txtEstat.ReadOnly = true;
            this.txtEstat.Size = new System.Drawing.Size(247, 20);
            this.txtEstat.TabIndex = 91;
            this.txtEstat.Tag = "Nom";
            this.txtEstat.Visible = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox1.Location = new System.Drawing.Point(172, 115);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Options = CustomControl.CustomTextBox.Items.Text;
            this.customTextBox1.Placeholder = null;
            this.customTextBox1.ReadOnly = true;
            this.customTextBox1.Size = new System.Drawing.Size(265, 20);
            this.customTextBox1.TabIndex = 1003;
            this.customTextBox1.Tag = "Nom";
            // 
            // lblUserOut
            // 
            this.lblUserOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserOut.AutoSize = true;
            this.lblUserOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOut.Location = new System.Drawing.Point(72, 116);
            this.lblUserOut.Name = "lblUserOut";
            this.lblUserOut.Size = new System.Drawing.Size(94, 16);
            this.lblUserOut.TabIndex = 1002;
            this.lblUserOut.Text = "Usuari sortida:";
            this.lblUserOut.Visible = false;
            // 
            // Emmagatzematge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 717);
            this.Controls.Add(this.txtEstat);
            this.Controls.Add(this.gbxNevera);
            this.Controls.Add(this.txtUserIn);
            this.Controls.Add(this.btnTreure);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.txtNumCamFrigo);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.lblEstat);
            this.Controls.Add(this.dgwEmmagatzematge);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.lblLot);
            this.Controls.Add(this.lblDataIn);
            this.Controls.Add(this.lblUserIn);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlSafates);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Emmagatzematge";
            this.Text = "Processat_Final";
            this.Load += new System.EventHandler(this.Emmagatzematge_Load);
            this.Controls.SetChildIndex(this.pnlSafates, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.Controls.SetChildIndex(this.lblUserIn, 0);
            this.Controls.SetChildIndex(this.lblDataIn, 0);
            this.Controls.SetChildIndex(this.lblLot, 0);
            this.Controls.SetChildIndex(this.txtLot, 0);
            this.Controls.SetChildIndex(this.dgwEmmagatzematge, 0);
            this.Controls.SetChildIndex(this.lblEstat, 0);
            this.Controls.SetChildIndex(this.dateIn, 0);
            this.Controls.SetChildIndex(this.txtNumCamFrigo, 0);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnTreure, 0);
            this.Controls.SetChildIndex(this.txtUserIn, 0);
            this.Controls.SetChildIndex(this.gbxNevera, 0);
            this.Controls.SetChildIndex(this.txtEstat, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmmagatzematge)).EndInit();
            this.pnlSafates.ResumeLayout(false);
            this.pnlSafates.PerformLayout();
            this.gbxNevera.ResumeLayout(false);
            this.gbxNevera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserIn;
        private System.Windows.Forms.Label lblDataIn;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblTempMin;
        private CustomControl.CustomTextBox txtLot;
        private CustomControl.CustomTextBox txtMaxTemp;
        private CustomControl.CustomTextBox txtMinTemp;
        private System.Windows.Forms.DataGridView dgwEmmagatzematge;
        private System.Windows.Forms.Panel pnlSafates;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEstat;
        private System.Windows.Forms.DateTimePicker dateIn;
        private CustomControl.CustomTextBox txtNumCamFrigo;
        public System.Windows.Forms.Button btnActualitzar;
        public System.Windows.Forms.Button btnTreure;
        private CustomControl.CustomTextBox txtUserIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label lblDataOut;
        private System.Windows.Forms.GroupBox gbxNevera;
        private CustomControl.CustomTextBox txtEstat;
        private CustomControl.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label lblUserOut;
    }
}