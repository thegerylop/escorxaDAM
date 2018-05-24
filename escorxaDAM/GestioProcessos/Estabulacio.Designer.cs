namespace GestioProcessos
{
    partial class Estabulacio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estabulacio));
            this.estabulacioDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuaris = new CustomControl.comboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Incidencies = new CustomControl.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumEstable = new CustomControl.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lots = new CustomControl.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DiaEntrada = new CustomControl.CustomTextBox();
            this.DiaSortida = new CustomControl.CustomTextBox();
            this.btnFinalitzar = new System.Windows.Forms.Button();
            this.Estats = new CustomControl.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estabulacioDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(837, 621);
            this.btnInserir.Visible = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // estabulacioDataGrid
            // 
            this.estabulacioDataGrid.AllowUserToAddRows = false;
            this.estabulacioDataGrid.AllowUserToDeleteRows = false;
            this.estabulacioDataGrid.AllowUserToResizeColumns = false;
            this.estabulacioDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estabulacioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estabulacioDataGrid.Location = new System.Drawing.Point(52, 77);
            this.estabulacioDataGrid.Name = "estabulacioDataGrid";
            this.estabulacioDataGrid.Size = new System.Drawing.Size(378, 172);
            this.estabulacioDataGrid.TabIndex = 112;
            this.estabulacioDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estabulacioDataGrid_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Estabulació";
            // 
            // Usuaris
            // 
            this.Usuaris.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Usuaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usuaris.Enabled = false;
            this.Usuaris.FormattingEnabled = true;
            this.Usuaris.Location = new System.Drawing.Point(202, 593);
            this.Usuaris.Name = "Usuaris";
            this.Usuaris.Reference = null;
            this.Usuaris.Size = new System.Drawing.Size(192, 21);
            this.Usuaris.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(479, 537);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 20);
            this.label14.TabIndex = 110;
            this.label14.Text = "Dia/Hora Sortida :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(479, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 20);
            this.label13.TabIndex = 109;
            this.label13.Text = "Dia/Hora entrada :";
            // 
            // Incidencies
            // 
            this.Incidencies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Incidencies.Location = new System.Drawing.Point(661, 432);
            this.Incidencies.Name = "Incidencies";
            this.Incidencies.Options = CustomControl.CustomTextBox.Items.Text;
            this.Incidencies.Placeholder = null;
            this.Incidencies.Size = new System.Drawing.Size(192, 20);
            this.Incidencies.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Incidencies :";
            // 
            // NumEstable
            // 
            this.NumEstable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumEstable.Location = new System.Drawing.Point(202, 539);
            this.NumEstable.Name = "NumEstable";
            this.NumEstable.Options = CustomControl.CustomTextBox.Items.Text;
            this.NumEstable.Placeholder = null;
            this.NumEstable.ReadOnly = true;
            this.NumEstable.Size = new System.Drawing.Size(192, 20);
            this.NumEstable.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "Usuari :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Numero estable :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Dades";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(52, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 1);
            this.panel1.TabIndex = 99;
            // 
            // Lots
            // 
            this.Lots.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lots.Location = new System.Drawing.Point(202, 434);
            this.Lots.Name = "Lots";
            this.Lots.Options = CustomControl.CustomTextBox.Items.Text;
            this.Lots.Placeholder = null;
            this.Lots.ReadOnly = true;
            this.Lots.Size = new System.Drawing.Size(192, 20);
            this.Lots.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 114;
            this.label6.Text = "Lot :";
            // 
            // DiaEntrada
            // 
            this.DiaEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiaEntrada.Location = new System.Drawing.Point(661, 485);
            this.DiaEntrada.Name = "DiaEntrada";
            this.DiaEntrada.Options = CustomControl.CustomTextBox.Items.Text;
            this.DiaEntrada.Placeholder = null;
            this.DiaEntrada.ReadOnly = true;
            this.DiaEntrada.Size = new System.Drawing.Size(192, 20);
            this.DiaEntrada.TabIndex = 115;
            // 
            // DiaSortida
            // 
            this.DiaSortida.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiaSortida.Location = new System.Drawing.Point(661, 539);
            this.DiaSortida.Name = "DiaSortida";
            this.DiaSortida.Options = CustomControl.CustomTextBox.Items.Text;
            this.DiaSortida.Placeholder = null;
            this.DiaSortida.ReadOnly = true;
            this.DiaSortida.Size = new System.Drawing.Size(192, 20);
            this.DiaSortida.TabIndex = 116;
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
            this.btnFinalitzar.TabIndex = 117;
            this.btnFinalitzar.Text = "Finalitzar";
            this.btnFinalitzar.UseVisualStyleBackColor = false;
            this.btnFinalitzar.Visible = false;
            this.btnFinalitzar.Click += new System.EventHandler(this.btnFinalitzar_Click);
            // 
            // Estats
            // 
            this.Estats.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Estats.Location = new System.Drawing.Point(202, 485);
            this.Estats.Name = "Estats";
            this.Estats.Options = CustomControl.CustomTextBox.Items.Text;
            this.Estats.Placeholder = null;
            this.Estats.ReadOnly = true;
            this.Estats.Size = new System.Drawing.Size(192, 20);
            this.Estats.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 119;
            this.label7.Text = "Estat :";
            // 
            // Estabulacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1126, 749);
            this.Controls.Add(this.Estats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinalitzar);
            this.Controls.Add(this.DiaSortida);
            this.Controls.Add(this.DiaEntrada);
            this.Controls.Add(this.Lots);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estabulacioDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usuaris);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Incidencies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumEstable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Estabulacio";
            this.Load += new System.EventHandler(this.Estabulacio_Load);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.NumEstable, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Incidencies, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.Usuaris, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.estabulacioDataGrid, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.Lots, 0);
            this.Controls.SetChildIndex(this.DiaEntrada, 0);
            this.Controls.SetChildIndex(this.DiaSortida, 0);
            this.Controls.SetChildIndex(this.btnFinalitzar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Estats, 0);
            ((System.ComponentModel.ISupportInitialize)(this.estabulacioDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView estabulacioDataGrid;
        private System.Windows.Forms.Label label3;
        private CustomControl.comboBox Usuaris;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private CustomControl.CustomTextBox Incidencies;
        private System.Windows.Forms.Label label1;
        private CustomControl.CustomTextBox NumEstable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.CustomTextBox Lots;
        private System.Windows.Forms.Label label6;
        private CustomControl.CustomTextBox DiaEntrada;
        private CustomControl.CustomTextBox DiaSortida;
        public System.Windows.Forms.Button btnFinalitzar;
        private CustomControl.CustomTextBox Estats;
        private System.Windows.Forms.Label label7;
    }
}
