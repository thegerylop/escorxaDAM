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

    public partial class BaseModificar : Form
    {
        String query = "";
        DataRow row;
        DataSet dataSet = new DataSet();
        String table = "";
        public BaseModificar()
        {
            InitializeComponent();
        }
        public void Table(string value)
        {
            table = value;
            PortarDadesMySQL(table);
        }
        public void PortarDadesMySQL(string table)
        {
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            BindingDades(table);
        }
        public virtual void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
        }

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

        private void BindingDades(string table)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox) || txt.GetType() == typeof(CheckBox))
                {
                    if (txt.Tag.ToString() != "") {
                        txt.DataBindings.Clear();
                        if(txt.GetType() == typeof(CustomControl.CustomTextBox)) {
                            txt.DataBindings.Add("Text", dataSet.Tables[table], txt.Tag.ToString(), true);
                        }
                        else if(txt.GetType() == typeof(CheckBox))
                        {
                            txt.DataBindings.Add("Checked", dataSet.Tables[table], txt.Tag.ToString());
                        }
                        
                        txt.Validated += new System.EventHandler(this.validarText);
                    }
                }
            }
            dgvBase.AutoGenerateColumns = true;
            dgvBase.DataSource = dataSet.Tables[table]; // dataset
        }

        public void validarText(object sender, EventArgs e)
        {
            Control test = (Control)sender;
            test.DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
       
        private void dgvBase_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Entrada no vàlida");
            dgvBase.RefreshEdit();
        }
    }
}