namespace MenuPrincipal
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimentDusuarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registreProveïdorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadesEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcióBestiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestióDeProcessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitxersAuxiliarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivellsDaccésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunitatsAutònomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipusDexplotacióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situacióDexplotacióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.païsosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatDeLaInspeccióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemesDatordimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatDelProcésDeRefrigeracióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatDelProcésDenvasatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptadorsDeLotsmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referènciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem,
            this.mantenimentDusuarisToolStripMenuItem,
            this.registreProveïdorsToolStripMenuItem,
            this.dadesEmpresaToolStripMenuItem,
            this.recepcióBestiarToolStripMenuItem,
            this.gestióDeProcessosToolStripMenuItem,
            this.fitxersAuxiliarsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arxiuToolStripMenuItem
            // 
            this.arxiuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.sortirToolStripMenuItem});
            this.arxiuToolStripMenuItem.Name = "arxiuToolStripMenuItem";
            this.arxiuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arxiuToolStripMenuItem.Text = "Arxiu";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem2,
            this.sobreToolStripMenuItem1});
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem2
            // 
            this.ajudaToolStripMenuItem2.Name = "ajudaToolStripMenuItem2";
            this.ajudaToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.ajudaToolStripMenuItem2.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre...";
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            // 
            // mantenimentDusuarisToolStripMenuItem
            // 
            this.mantenimentDusuarisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.mantenimentDusuarisToolStripMenuItem.Name = "mantenimentDusuarisToolStripMenuItem";
            this.mantenimentDusuarisToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.mantenimentDusuarisToolStripMenuItem.Text = "Manteniment d\'usuaris";
            // 
            // afegirToolStripMenuItem
            // 
            this.afegirToolStripMenuItem.Name = "afegirToolStripMenuItem";
            this.afegirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afegirToolStripMenuItem.Text = "Afegir";
            this.afegirToolStripMenuItem.Click += new System.EventHandler(this.afegirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // registreProveïdorsToolStripMenuItem
            // 
            this.registreProveïdorsToolStripMenuItem.Name = "registreProveïdorsToolStripMenuItem";
            this.registreProveïdorsToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.registreProveïdorsToolStripMenuItem.Text = "Registre proveïdors";
            // 
            // dadesEmpresaToolStripMenuItem
            // 
            this.dadesEmpresaToolStripMenuItem.Name = "dadesEmpresaToolStripMenuItem";
            this.dadesEmpresaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.dadesEmpresaToolStripMenuItem.Text = "Dades empresa";
            // 
            // recepcióBestiarToolStripMenuItem
            // 
            this.recepcióBestiarToolStripMenuItem.Name = "recepcióBestiarToolStripMenuItem";
            this.recepcióBestiarToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.recepcióBestiarToolStripMenuItem.Text = "Recepció bestiar";
            // 
            // gestióDeProcessosToolStripMenuItem
            // 
            this.gestióDeProcessosToolStripMenuItem.Name = "gestióDeProcessosToolStripMenuItem";
            this.gestióDeProcessosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gestióDeProcessosToolStripMenuItem.Text = "Gestió de processos";
            // 
            // fitxersAuxiliarsToolStripMenuItem
            // 
            this.fitxersAuxiliarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivellsDaccésToolStripMenuItem,
            this.comunitatsAutònomesToolStripMenuItem,
            this.tipusDexplotacióToolStripMenuItem,
            this.situacióDexplotacióToolStripMenuItem,
            this.païsosToolStripMenuItem,
            this.estatDeLaInspeccióToolStripMenuItem,
            this.sistemesDatordimentToolStripMenuItem,
            this.estatDelProcésDeRefrigeracióToolStripMenuItem,
            this.estatDelProcésDenvasatToolStripMenuItem,
            this.comptadorsDeLotsmesToolStripMenuItem,
            this.referènciesToolStripMenuItem});
            this.fitxersAuxiliarsToolStripMenuItem.Name = "fitxersAuxiliarsToolStripMenuItem";
            this.fitxersAuxiliarsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.fitxersAuxiliarsToolStripMenuItem.Text = "Fitxers Auxiliars";
            // 
            // nivellsDaccésToolStripMenuItem
            // 
            this.nivellsDaccésToolStripMenuItem.Name = "nivellsDaccésToolStripMenuItem";
            this.nivellsDaccésToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.nivellsDaccésToolStripMenuItem.Text = "Nivells d\'accés";
            // 
            // comunitatsAutònomesToolStripMenuItem
            // 
            this.comunitatsAutònomesToolStripMenuItem.Name = "comunitatsAutònomesToolStripMenuItem";
            this.comunitatsAutònomesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.comunitatsAutònomesToolStripMenuItem.Text = "Comunitats autònomes";
            // 
            // tipusDexplotacióToolStripMenuItem
            // 
            this.tipusDexplotacióToolStripMenuItem.Name = "tipusDexplotacióToolStripMenuItem";
            this.tipusDexplotacióToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.tipusDexplotacióToolStripMenuItem.Text = "Tipus d\'explotació";
            // 
            // situacióDexplotacióToolStripMenuItem
            // 
            this.situacióDexplotacióToolStripMenuItem.Name = "situacióDexplotacióToolStripMenuItem";
            this.situacióDexplotacióToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.situacióDexplotacióToolStripMenuItem.Text = "Situació d\'explotació";
            // 
            // païsosToolStripMenuItem
            // 
            this.païsosToolStripMenuItem.Name = "païsosToolStripMenuItem";
            this.païsosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.païsosToolStripMenuItem.Text = "Països";
            // 
            // estatDeLaInspeccióToolStripMenuItem
            // 
            this.estatDeLaInspeccióToolStripMenuItem.Name = "estatDeLaInspeccióToolStripMenuItem";
            this.estatDeLaInspeccióToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.estatDeLaInspeccióToolStripMenuItem.Text = "Estat de la inspecció";
            // 
            // sistemesDatordimentToolStripMenuItem
            // 
            this.sistemesDatordimentToolStripMenuItem.Name = "sistemesDatordimentToolStripMenuItem";
            this.sistemesDatordimentToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.sistemesDatordimentToolStripMenuItem.Text = "Sistemes d\'atordiment";
            // 
            // estatDelProcésDeRefrigeracióToolStripMenuItem
            // 
            this.estatDelProcésDeRefrigeracióToolStripMenuItem.Name = "estatDelProcésDeRefrigeracióToolStripMenuItem";
            this.estatDelProcésDeRefrigeracióToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.estatDelProcésDeRefrigeracióToolStripMenuItem.Text = "Estat del procés de refrigeració";
            // 
            // estatDelProcésDenvasatToolStripMenuItem
            // 
            this.estatDelProcésDenvasatToolStripMenuItem.Name = "estatDelProcésDenvasatToolStripMenuItem";
            this.estatDelProcésDenvasatToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.estatDelProcésDenvasatToolStripMenuItem.Text = "Estat del procés d\'envasat";
            // 
            // comptadorsDeLotsmesToolStripMenuItem
            // 
            this.comptadorsDeLotsmesToolStripMenuItem.Name = "comptadorsDeLotsmesToolStripMenuItem";
            this.comptadorsDeLotsmesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.comptadorsDeLotsmesToolStripMenuItem.Text = "Comptadors de lots/mes";
            // 
            // referènciesToolStripMenuItem
            // 
            this.referènciesToolStripMenuItem.Name = "referènciesToolStripMenuItem";
            this.referènciesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.referènciesToolStripMenuItem.Text = "Referències";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 555);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimentDusuarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registreProveïdorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadesEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcióBestiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestióDeProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitxersAuxiliarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivellsDaccésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunitatsAutònomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipusDexplotacióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situacióDexplotacióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem païsosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatDeLaInspeccióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemesDatordimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatDelProcésDeRefrigeracióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatDelProcésDenvasatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptadorsDeLotsmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referènciesToolStripMenuItem;
    }
}

