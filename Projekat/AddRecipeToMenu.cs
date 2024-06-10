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
    public partial class AddRecipeToMenu : Form
    {
        private int recipeID;
        private DataTable menusDataTable;
        private List<TypeMeal> typesmeal;
        public AddRecipeToMenu(int recipeID)
        {
            InitializeComponent();
            this.recipeID = recipeID;
            this.btnSave.Click += BtnSave_Click;

            InitData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int menuID = Convert.ToInt32(this.cbMenu.SelectedValue);
            string typemeal = this.cbTypeMeal.SelectedValue.ToString();

            bool result = false;
            if (MenuRepository.RecipeExistsInMenu(recipeID, menuID))
            {
                //ako je recept već u meniju, ažuriramo
                result = MenuRepository.UpdateRecipeInMenu(recipeID, menuID, typemeal);
            }
            else
            {
                //ako recept ne postoji u meniju, dodajemo ga
                result = MenuRepository.AddRecipeToMenu(recipeID, menuID, typemeal);
            }

            if (result)
            {
                MessageBox.Show("Recept dodat u meni!");
            }
            else
            {
                MessageBox.Show("Greška pri dodavanju recepta u meni!");
            }
        }

        private void InitData()
        {
            Recipe rec = RecipeRepository.GetRecipeByID(recipeID);
            this.lblRecipeName.Text = rec.Naziv;

            this.menusDataTable = MenuRepository.GetMenusDataTable();
            this.cbMenu.DataSource = menusDataTable;
            this.cbMenu.DisplayMember = "Naziv";
            this.cbMenu.ValueMember = "MeniID";

            this.typesmeal = TypeMealRepository.GetTypeMealList();
            this.cbTypeMeal.DataSource = typesmeal;
            this.cbTypeMeal.DisplayMember = "Naziv";
            this.cbTypeMeal.ValueMember = "Naziv";
        }
    }
}
