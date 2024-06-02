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
    public partial class FrmIngredient : Form
    {
        private FrmIngredients parentForm; //forma na koju se vraćemo poslije dodavanja/editovanja sastojka, glavna
        private int selectedIngredientID; //izabrani sastojak, njegov ID

        public FrmIngredient(FrmIngredients parent, int selectedIngredientID) //potreban nam je konstruktor sa dva argumenta kako bi znali koja je glavna forma, i koji je izabrani sastojak, da bi mogli da dodamo/ažuriramo
        {
            InitializeComponent();

            this.parentForm = parent;
            this.selectedIngredientID = selectedIngredientID;
            this.btnSave.Click += BtnSave_Click;

            InitData();
        }

        private void InitData()
        {
            if (this.selectedIngredientID != -1) //ako je izabran sastojak, to znači da radimo ažuriranje, a ne dodavanje
            {
                this.lblTitle.Text = "Izmijeni sastojak";
                this.btnSave.Text = "Izmijeni";

                Ingredient i = IngredientRepository.GetIngredientByID(this.selectedIngredientID);
                if (i != null)
                {
                    this.txtName.Text = i.Naziv;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: VALIDACIJA

            Ingredient ingr = new Ingredient();
            ingr.Naziv = this.txtName.Text;

            bool result = false;
            if (this.selectedIngredientID != -1)
            {
                //AŽURIRAMO, inače DODAMO
                ingr.SastojakID = this.selectedIngredientID;
                result = IngredientRepository.UpdateIngredient(ingr);
            }
            else
            {
                //DODAMO
                result = IngredientRepository.InsertIngredient(ingr);
            }

            if (result)
            {
                this.parentForm.InitData();
                MessageBox.Show("Uspjesno sacuvan sastojak!");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju sastojka!");
            }
        }
    }
}
