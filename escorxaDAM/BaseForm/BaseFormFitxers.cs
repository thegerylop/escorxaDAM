using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexioBBDD;
namespace BaseForm
{

    public partial class BaseForm : Form
    {
        String query = "";
        DataRow row;
        DataSet dataSet = new DataSet();
        String table = "";
        public BaseForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Agafa el nom d'una taula de la BBDD, donada per paràmetre
        /// i crida a la funció PortaDadesMySql per fer el binding
        /// </summary>
        /// <param name="value">Nom de la taula que s'ha d'anar a buscar a la BBDD</param>
        public void Table(string value)
        {
            table = value;
            PortarDadesMySQL(table);
        }
        /// <summary>
        /// Donada una taula de la BBDD per paràmetre, crida a la BBDD, agafa la informació i la bindeja al datagrid
        /// </summary>
        /// <param name="table">Nom de la taula que s'ha de bindejar</param>
        public void PortarDadesMySQL(string table)
        {
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            BindingDades(table);
        }
        /// <summary>
        /// Donada una taula de la BBDD per paràmetre, compara el dataset i el datatable
        /// i actualitza la taula a la BBDD
        /// </summary>
        /// <param name="table"></param>
        public void ActualitzarMySQL(string table)
        {
            Boolean correcte = false;
            correcte = ComprovarCamps();
            if (correcte)
            {
                ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
                correcte = bd.Actualitzar(query, table, dataSet);
                if (correcte)
                {
                    MessageBox.Show("Dades actualitzades");
                }
                else
                {
                    MessageBox.Show("Error al actualitzar les dades");
                }
            }
            else
            {
                MessageBox.Show("Camps buits");
            }
            
        }
        /// <summary>
        /// Comprova que cap camp del formulari estigui buit
        /// </summary>
        /// <returns>Retorna si el formulari està tot omplert (true), o falta algun camp per omplir (false)</returns>
        private Boolean ComprovarCamps()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    if (txt.Text == "" && txt.Tag != "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Agafa les dades del dataset i les passa al datatable
        /// </summary>
        /// <param name="table">Taula a la que passem les dades del dataset</param>
        private void BindingDades(string table)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    if (txt.Tag.ToString() != "") {
                        txt.DataBindings.Clear();
                        txt.DataBindings.Add("Text", dataSet.Tables[table], txt.Tag.ToString(), true);
                        txt.Validated += new System.EventHandler(this.validarText);
                    }
                }
            }
            dgvBase.AutoGenerateColumns = true;
            dgvBase.DataSource = dataSet.Tables[table]; // dataset
        }
        /// <summary>
        /// Valida que no estiguis editant un textbox per enviar-lo al dataset
        /// </summary>
        /// <param name="sender">Texbox que estem validant</param>
        public void validarText(object sender, EventArgs e)
        {
            Control validar = (Control)sender;
            validar.DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        /// <summary>
        /// Crida la funció AfegirCamp, donant el valor de table
        /// </summary>
        /// <param name="sender">Taula que enviem</param>
        public virtual void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }
        /// <summary>
        /// Crida la funció ActualitzarMySql
        /// </summary>
        /// <param name="sender">Taula que enviem</param>
        public virtual void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
        }
        /// <summary>
        /// Neteja tots els textboxs del formulari
        /// </summary>
        public void netejarCamps()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    txt.Text = "";
                }
            }
        }
        /// <summary>
        /// Donat el datagrid per paràmetre, afegeix una fila nova al datagrid corresponent
        /// </summary>
        /// <param name="table">Nom del datagrid</param>
        public void AfegirCamp(string table)
        {
            int numIndex = 1;
            Boolean rowIndex = false;
            row = dataSet.Tables[table].NewRow();
            dataSet.Tables[table].Rows.Add(row);
            int num = Int32.Parse(dgvBase.Rows.Count.ToString());
            num -= 2;
            dgvBase.Rows[num].Selected = true;
            while(!rowIndex)
            {
                try
                {
                    dgvBase.CurrentCell = dgvBase.Rows[num].Cells[numIndex];
                    
                    rowIndex = true;
                }
                catch(System.InvalidOperationException)
                {
                    numIndex += 1;
                }

            }
            
        }
        /// <summary>
        /// Aquesta funció s'executa quan l'usuari introdueix un tipus incorrecte d'entrada en un textbox
        /// </summary>
        private void dgvBase_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Entrada no vàlida");
            dgvBase.RefreshEdit();
        }
    }
}