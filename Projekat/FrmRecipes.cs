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
    public partial class FrmRecipes : Form
    {
        private int selectedRecipe = -1;
        DataTable data;

        public FrmRecipes()
        {
            InitializeComponent();
            this.dgRecipes.SelectionChanged += new EventHandler(dgRecipes_SelectionChanged);
            this.viewIngredientsMenuItem.Click += PreviewIngredients_Click;
            this.viewRecipesMenuItem.Click += PreviewRecipes_Click;
            InitData();
        }

        public void PreviewIngredients_Click(object sender, EventArgs e)
        {
            FrmIngredients ingredientsForm = new FrmIngredients();
            this.Hide(); //sakrijemo trenutnu formu umjesto da je zatvorimo
            ingredientsForm.FormClosed += (s, args) => this.Show(); //kada se zatvori, ponovo prikažemo glavnu (frmRecipes)
            ingredientsForm.Show();
        }

        public void PreviewRecipes_Click(object sender, EventArgs e)
        {
            this.Hide(); //sakrijemo trenutnu formu
            Application.OpenForms["FrmRecipes"].Show(); //prikaz glavne forme
        }

        public void InitData()
        {
            this.data = RecipeRepository.GetRecipesDataTable();
            if(this.data != null)
            {
                this.dgRecipes.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greska pri prikazivanju recepata!");
            }
        }

        private void dgRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgRecipes.CurrentRow != null)
            {
                int recipeId = Convert.ToInt32(dgRecipes.CurrentRow.Cells["ReceptID"].Value);
                DataTable ingredientsData = RecipeRepository.GetIngredientsByRecipeId(recipeId);
                dgIngredients.DataSource = ingredientsData;
            }
        }
    }
}
