using Projekat.Models;
using Projekat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmRecipe : Form
    {
        private FrmRecipes parentForm; //forma na koju se vraćemo poslije dodavanja/editovanja recepta, glavna
        private int selectedRecipeID; //izabrani recept, njegov ID

        public FrmRecipe(FrmRecipes parent, int selectedRecipeID) //potreban nam je konstruktor sa dva argumenta kako bi znali koja je glavna forma, i koji je izabrani recept, da bi mogli da dodamo/ažuriramo
        {
            InitializeComponent();

            this.parentForm = parent;
            this.selectedRecipeID = selectedRecipeID;
            this.btnSave.Click += BtnSave_Click;

            InitData();
        }

        private void InitData()
        {
            if (this.selectedRecipeID != -1) //ako je izabran recept, to znači da radimo ažuriranje, a ne dodavanje
            {
                this.lblTitle.Text = "Izmijeni recept";
                this.btnSave.Text = "Izmijeni";

                Recipe r = RecipeRepository.GetRecipeByID(this.selectedRecipeID);
                if (r != null)
                {
                    this.txtName.Text = r.Naziv;
                    this.txtDesc.Text = r.Opis;
                    this.txtTimeMaking.Text = r.VrijemePripreme.ToString();
                    this.txtTimeCooking.Text = r.VrijemeKuvanja.ToString();
                    this.txtNumPortions.Text = r.BrojPorcija.ToString();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //validacija
            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                MessageBox.Show("Naziv je obavezan.");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtDesc.Text))
            {
                MessageBox.Show("Opis je obavezan.");
                return;
            }

            if (!int.TryParse(this.txtTimeMaking.Text, out int vrijemePripreme))
            {
                MessageBox.Show("Vrijeme pripreme mora biti validan broj.");
                return;
            }

            if (!int.TryParse(this.txtTimeCooking.Text, out int vrijemeKuvanja))
            {
                MessageBox.Show("Vrijeme kuvanja mora biti validan broj.");
                return;
            }

            if (!int.TryParse(this.txtNumPortions.Text, out int brojPorcija))
            {
                MessageBox.Show("Broj porcija mora biti validan broj.");
                return;
            }

            Recipe rec = new Recipe();
            rec.Naziv = this.txtName.Text;
            rec.Opis = this.txtDesc.Text;
            rec.VrijemePripreme = vrijemePripreme;
            rec.VrijemeKuvanja = vrijemeKuvanja;
            rec.UkupnoVrijeme = vrijemePripreme + vrijemeKuvanja;
            rec.BrojPorcija = brojPorcija;

            rec.BrojPorcija = Convert.ToInt32(this.txtNumPortions.Text);

            bool result = false;
            if (this.selectedRecipeID != -1)
            {
                //ažuriranje postojećeg recepta
                rec.ReceptID = this.selectedRecipeID;
                result = RecipeRepository.UpdateRecipe(rec);
            }
            else
            {
                //dodavanje novog recepta
                result = RecipeRepository.InsertRecipe(rec);
            }

            if (result)
            {
                this.parentForm.InitData();
                MessageBox.Show("Uspješno sačuvan recept!");
            }
            else
            {
                MessageBox.Show("Greška pri čuvanju recepta!");
            }
        }
    }
}
