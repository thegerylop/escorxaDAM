//Downloaded from
//Visual C# Kicks - http://vcskicks.com/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DownloadDataFTP
{
    public partial class listDialogForm : Form
    {
        private List<string> Llista = new List<string>();
        private string arxiu;

        public listDialogForm(List<string> arxius)
        {
            InitializeComponent();

            Llista = arxius; //the list of files to display
        }

        //Accessor for the user selected file
        public string ArxiuEscollit
        {
            get { return arxiu; }
        }

        private void listDialogForm_Load(object sender, EventArgs e)
        {
            //Setup the dialog buttons
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            //Populate the list
            foreach (string arxiu in Llista)
            {
                listboxFiles.Items.Add(arxiu);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Save which file was selected
            if (listboxFiles.SelectedIndex != -1)
                arxiu = listboxFiles.SelectedItem.ToString();
        }
    }
}