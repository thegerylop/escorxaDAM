using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;
using Models;

namespace GestioProcessos
{
    public partial class Processat_Inicial : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        string lot, DIB;
        int num;

        public Processat_Inicial()
        {
            InitializeComponent();
        }

        private void omplirCampsRandom()
        {

            txtBoxCarril.Text = randomInt(1,3).ToString();
            txtBoxPesCanal.Text = randomInt(320, 400).ToString();
        }


        private void Processat_Inicial_Load(object sender, EventArgs e)
        {
            obtenirUsuaris();
            updateGridLots();
        }

        private void updateGridLots()
        {
            var dades = (from lts in _m.lots
                         join pi in _m.processats_inicials on lts.idProcessatInicial equals pi.idProcessatInicial 
                         join epi in _m.estat_processos_inicials on pi.idEstatInicial equals epi.idEstatProcesInicial
                         where (epi.Estat == "En espera" || epi.Estat == "En procés")
                         select new { lts.numLot, epi.Estat }).ToArray();

            //Fico les dades
            gridLots.DataSource = dades;
        }

        private void updateGridAnimals(string nLot)
        {
            //Agafo les dades
            //var dades = (from sacrifici in _m.sacrificis
            //             join lots in _m.lots on sacrifici.idSacrifici equals lots.idSacrifici
            //             join estats in _m.estat_sacrifici on sacrifici.idEstatSacrifici equals estats.idEstatSacrifici

            //             where (estats.nomEstatSacrifici == "En espera" || estats.nomEstatSacrifici == "En procés")
            //             select new { lots.numLot, estats.nomEstatSacrifici }).ToArray();

            var dades = (from animals in _m.animals
                         join rb in _m.recepcions_bestiar on animals.idRecepcioBestiar equals rb.idRecepcio
                         join ls in _m.lots on rb.idRecepcio equals ls.idRemo
                         where (ls.numLot == nLot)
                         select new { animals.DIB, animals.Pes, animals.numCarril }).ToArray();
                
            //Fico les dades
            gridAnimalsLot.DataSource = dades;
        }

        public void obtenirUsuaris()
        {
            var usuaris = (from a in _m.usuaris
                           select new { a.idUsuari, a.Nom }).ToArray();
            Usuaris.DataSource = usuaris;
            Usuaris.DisplayMember = "Nom";
            Usuaris.ValueMember = "idUsuari";
        }
    
        private void afegirBBDD()
        { 
            if (DIB != null || DIB != "") {
                using(escorxadam2Entities test = new escorxadam2Entities())
                {
                    string idProcessatInicial = (from a in _m.lots
                                                 where a.numLot.ToString() == lot
                                                 select a.idProcessatInicial).First().ToString();
                    var ProcessatInicial = (from a in _m.processats_inicials
                                            where a.idProcessatInicial.ToString() == idProcessatInicial
                                            select a).FirstOrDefault();
                    if (!btnFinalitzar.Visible)
                    {
                        var animal = (from a in _m.animals
                                      where a.DIB == DIB
                                      select a).First();
                        animal.Pes = Int64.Parse(txtBoxPesCanal.Text);
                        animal.numCarril = Int32.Parse(txtBoxCarril.Text);
                        _m.SaveChanges();

                        MessageBox.Show("Inserit correctament");
                    }

                    if (ProcessatInicial.idEstatInicial == 1)
                    {
                        ProcessatInicial.idUsuari = Int32.Parse(Usuaris.SelectedValue.ToString());
                        ProcessatInicial.idEstatInicial = 2;
                    }
                    else
                    {
                        if (comprovarAnimals())
                        {
                            if (btnFinalitzar.Visible)
                            {
                                ProcessatInicial.idUsuari = Int32.Parse(Usuaris.SelectedValue.ToString());
                                ProcessatInicial.idEstatInicial = 3;
                                MessageBox.Show("Finalitzat correctament");
                            }
                            else
                            {
                                btnFinalitzar.Visible = true;
                                btnInserir.Visible = false;
                            }
                        }
                    }
                    _m.SaveChanges();
                    updateGridLots();
                }
            }
        }
        public bool comprovarAnimals()
        {
            bool finalitzar = true;
            foreach (DataGridViewRow row in gridAnimalsLot.Rows)
            {
                
                if (finalitzar)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if(cell.Value == null)
                        {
                            finalitzar = false;
                            break;
                        }
                    }
                }
            }
            return finalitzar;
        }
        public int randomInt(int min, int max)
        {
            Random rnd = new Random();
            int random = rnd.Next(min, max);
            return random;
        }

        private void btnFinalitzar_Click(object sender, EventArgs e)
        {
            afegirBBDD();
            finalitzarProces();
        }
        public void finalitzarProces()
        {
            using(escorxadam2Entities enti = new escorxadam2Entities())
            {
                var proc = new emmagatzematges
                {
                    idUsuariEntrada = 1,
                    idUsuariSortida = 1,
                    idEstatRefrigeracio = 1,
                };
                _m.emmagatzematges.Add(proc);
                _m.SaveChanges();
                var lotes = _m.lots.OrderByDescending(u => u.numLot == lot).FirstOrDefault();
                long idEmm = (from a in _m.emmagatzematges
                                    select a.idEmmagatzematge).Max();

                lotes.idEmmagatzematge = idEmm;
                _m.SaveChanges();
            }
            MessageBox.Show("Finalitzat");
        
    }

        private void gridLots_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            num = e.RowIndex;
            lot = gridLots.Rows[num].Cells[0].Value.ToString();
            string estat = gridLots.Rows[num].Cells[1].Value.ToString();

            //Introdueixo les dades al grid d'animals i el textbox d'estat
            updateGridAnimals(lot);
            txtBoxEstat.Text = estat;
            if (comprovarAnimals())
            {
                btnFinalitzar.Visible = true;
                btnInserir.Visible = false;
            }
            else
            {
                btnFinalitzar.Visible = false;
                btnInserir.Visible = true;
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            omplirCampsRandom();
            afegirBBDD();
            updateGridAnimals(lot);
        }

        private void gridAnimals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            num = gridAnimalsLot.CurrentCell.RowIndex;
            DIB = gridAnimalsLot.Rows[num].Cells[0].Value.ToString();
            txtDIB.Text = DIB;
        }
    }
}
