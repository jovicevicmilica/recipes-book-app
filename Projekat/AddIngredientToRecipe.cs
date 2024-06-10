using Projekat.Models;
using Projekat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Projekat
{
    public partial class AddIngredientToRecipe : Form
    {
        private int ingredientID;
        private DataTable recipesDataTable;
        private List<Measurement> measurements;
        public AddIngredientToRecipe(int ingredientID)
        {
            InitializeComponent();
            this.ingredientID = ingredientID;
            this.btnSave.Click += BtnSave_Click;

            InitData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int recipeID = Convert.ToInt32(this.cbRecipe.SelectedValue);
            string measurement = this.cbMeasurement.SelectedValue.ToString();
            decimal amount;

            //validacija unosa količine
            if (!decimal.TryParse(this.txtAmount.Text, out amount))
            {
                MessageBox.Show("Unesite ispravnu količinu!");
                return; //prekinemo ako unos nije validan
            }

            bool result = false;
            if (RecipeRepository.IngredientExistsInRecipe(ingredientID, recipeID))
            {
                //ako sastojak već postoji, ažuriramo njegovu količinu i mjernu jedinicu
                result = RecipeRepository.UpdateIngredientInRecipe(ingredientID, recipeID, amount, measurement);
            }
            else
            {
                //ako sastojak ne postoji, dodajemo ga
                result = RecipeRepository.AddIngredientToRecipe(ingredientID, recipeID, amount, measurement);
            }

            if (result)
            {
                MessageBox.Show("Sastojak dodat u recept!");
            }
            else
            {
                MessageBox.Show("Greška pri dodavanju sastojka u recept!");
            }
        }

        private void InitData()
        {
            Ingredient ingr = IngredientRepository.GetIngredientByID(ingredientID);
            this.lblIngredientName.Text = ingr.Naziv;

            this.recipesDataTable = RecipeRepository.GetRecipesDataTable();
            this.cbRecipe.DataSource = recipesDataTable;
            this.cbRecipe.DisplayMember = "Naziv";
            this.cbRecipe.ValueMember = "ReceptID";

            this.measurements = MeasurementRepository.GetMeasurementList();
            this.cbMeasurement.DataSource = measurements;
            this.cbMeasurement.DisplayMember = "Naziv";
            this.cbMeasurement.ValueMember = "Naziv";
        }
    }
}
