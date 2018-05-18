namespace GestioProcessos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLot = new CustomControl.CustomTextBox();
            this.txtMaxTemp = new CustomControl.CustomTextBox();
            this.txtMinTemp = new CustomControl.CustomTextBox();
            this.dgwEmmagatzematge = new System.Windows.Forms.DataGridView();
            this.pnlSafates = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.txtNumCamFrigo = new CustomControl.CustomTextBox();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnTreure = new System.Windows.Forms.Button();
            this.estatRefrigeracioComboBox = new CustomControl.comboBox();
            this.txtUserIn = new CustomControl.CustomTextBox();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxNevera = new System.Windows.Forms.GroupBox();
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
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nº cambra frigorífica:";
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Usuari entrada:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Data entrada:";
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 356);
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
            this.label8.Location = new System.Drawing.Point(27, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Temperatura màxima:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 77;
            this.label9.Text = "Temperatura mínima:";
            this.label9.Visible = false;
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
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaxTemp.Location = new System.Drawing.Point(172, 34);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtMaxTemp.Placeholder = null;
            this.txtMaxTemp.ReadOnly = true;
            this.txtMaxTemp.Size = new System.Drawing.Size(265, 20);
            this.txtMaxTemp.TabIndex = 95;
            this.txtMaxTemp.Tag = "Nom";
            this.txtMaxTemp.Visible = false;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMinTemp.Location = new System.Drawing.Point(172, 75);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Options = CustomControl.CustomTextBox.Items.Text;
            this.txtMinTemp.Placeholder = null;
            this.txtMinTemp.ReadOnly = true;
            this.txtMinTemp.Size = new System.Drawing.Size(265, 20);
            this.txtMinTemp.TabIndex = 96;
            this.txtMinTemp.Tag = "Nom";
            this.txtMinTemp.Visible = false;
            // 
            // dgwEmmagatzematge
            // 
            this.dgwEmmagatzematge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwEmmagatzematge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmmagatzematge.Location = new System.Drawing.Point(227, 117);
            this.dgwEmmagatzematge.Name = "dgwEmmagatzematge";
            this.dgwEmmagatzematge.Size = new System.Drawing.Size(774, 191);
            this.dgwEmmagatzematge.TabIndex = 1;
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
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(93, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 16);
            this.label14.TabIndex = 93;
            this.label14.Text = "Estat refrigeració:";
            this.label14.Visible = false;
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
            // 
            // estatRefrigeracioComboBox
            // 
            this.estatRefrigeracioComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estatRefrigeracioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estatRefrigeracioComboBox.FormattingEnabled = true;
            this.estatRefrigeracioComboBox.Location = new System.Drawing.Point(227, 400);
            this.estatRefrigeracioComboBox.Name = "estatRefrigeracioComboBox";
            this.estatRefrigeracioComboBox.Reference = null;
            this.estatRefrigeracioComboBox.Size = new System.Drawing.Size(247, 21);
            this.estatRefrigeracioComboBox.TabIndex = 91;
            this.estatRefrigeracioComboBox.Visible = false;
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
            // 
            // dateOut
            // 
            this.dateOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOut.Location = new System.Drawing.Point(172, 116);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(265, 20);
            this.dateOut.TabIndex = 97;
            this.dateOut.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 1000;
            this.label3.Text = "Data sortida:";
            this.label3.Visible = false;
            // 
            // gbxNevera
            // 
            this.gbxNevera.Controls.Add(this.txtMinTemp);
            this.gbxNevera.Controls.Add(this.label8);
            this.gbxNevera.Controls.Add(this.dateOut);
            this.gbxNevera.Controls.Add(this.label9);
            this.gbxNevera.Controls.Add(this.label3);
            this.gbxNevera.Controls.Add(this.txtMaxTemp);
            this.gbxNevera.Location = new System.Drawing.Point(564, 356);
            this.gbxNevera.Name = "gbxNevera";
            this.gbxNevera.Size = new System.Drawing.Size(450, 168);
            this.gbxNevera.TabIndex = 1001;
            this.gbxNevera.TabStop = false;
            this.gbxNevera.Text = "Dades refrigeració";
            this.gbxNevera.Visible = false;
            // 
            // Emmagatzematge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 717);
            this.Controls.Add(this.gbxNevera);
            this.Controls.Add(this.txtUserIn);
            this.Controls.Add(this.estatRefrigeracioComboBox);
            this.Controls.Add(this.btnTreure);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.txtNumCamFrigo);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgwEmmagatzematge);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlSafates);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Emmagatzematge";
            this.Text = "Processat_Final";
            this.Load += new System.EventHandler(this.Emmagatzematge_Load);
            this.Controls.SetChildIndex(this.pnlSafates, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtLot, 0);
            this.Controls.SetChildIndex(this.dgwEmmagatzematge, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.dateIn, 0);
            this.Controls.SetChildIndex(this.txtNumCamFrigo, 0);
            this.Controls.SetChildIndex(this.btnActualitzar, 0);
            this.Controls.SetChildIndex(this.btnTreure, 0);
            this.Controls.SetChildIndex(this.estatRefrigeracioComboBox, 0);
            this.Controls.SetChildIndex(this.txtUserIn, 0);
            this.Controls.SetChildIndex(this.gbxNevera, 0);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControl.CustomTextBox txtLot;
        private CustomControl.CustomTextBox txtMaxTemp;
        private CustomControl.CustomTextBox txtMinTemp;
        private System.Windows.Forms.DataGridView dgwEmmagatzematge;
        private System.Windows.Forms.Panel pnlSafates;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateIn;
        private CustomControl.CustomTextBox txtNumCamFrigo;
        public System.Windows.Forms.Button btnActualitzar;
        public System.Windows.Forms.Button btnTreure;
        private CustomControl.comboBox estatRefrigeracioComboBox;
        private CustomControl.CustomTextBox txtUserIn;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxNevera;
    }
}