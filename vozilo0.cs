using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozilooo
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();


            comboBoxSortiranje.Items.Add("Marka");
            comboBoxSortiranje.Items.Add("Model");
            comboBoxSortiranje.Items.Add("GodinaProizvodnje");
            comboBoxSortiranje.Items.Add("Kilometraza");
            comboBoxSortiranje.SelectedIndex = 0;
        }

        private void txtDodajVozilo_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            int godinaProizvodnje;
            int kilometraza;

            if (int.TryParse(txtGodinaProizvodnje.Text, out godinaProizvodnje) && godinaProizvodnje > 0 &&
            int.TryParse(txtKilometraza.Text, out kilometraza) && kilometraza >= 0)
            {

                Vozilo novoVozilo = new Vozilo(marka, model, godinaProizvodnje, kilometraza);
                vozila.Add(novoVozilo);
                MessageBox.Show("Vozilo dodano!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke za godinu proizvodnje i kilometražu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtSortitaj_Click(object sender, EventArgs e)
        {
            var kriterij = comboBoxSortiranje.SelectedItem.ToString();
            IEnumerable<Vozilo> sortiranaLista;


            switch (kriterij)
            {
                case "Marka":
                    sortiranaLista = vozila.OrderBy(v => v.Marka);
                    break;
                case "Model":
                    sortiranaLista = vozila.OrderBy(v => v.Model);
                    break;
                case "GodinaProizvodnje":
                    sortiranaLista = vozila.OrderBy(v => v.GodinaProizvodnje);
                    break;
                case "Kilometraza":
                    sortiranaLista = vozila.OrderBy(v => v.Kilometraza);
                    break;
                default:
                    sortiranaLista = vozila;
                    break;
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (listBoxVozila.SelectedItem != null)
            {
                Vozilo voziloZaBrisanje = (Vozilo)listBoxVozila.SelectedItem;
                vozila.Remove(voziloZaBrisanje);
                
                MessageBox.Show("Vozilo je obrisano.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Odaberite vozilo koje želite obrisati.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
