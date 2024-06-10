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
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmRecipes : Form
    {
        private int selectedRecipeID = -1;
        DataTable data;

        SqlDataAdapter sqlDataAdapter; //da bi omogućili automatsko dodavanje/ažuriranje preko grid - a
        SqlCommandBuilder sqlCommandBuilder;

        public FrmRecipes()
        {
            InitializeComponent();
            this.dgRecipes.SelectionChanged += new EventHandler(dgRecipes_SelectionChanged); //kada selektujemo recept, prikazaće nam sastojke za taj recept
            this.exitMenuItem.Click += (sender, e) => MenuHelper.ExitApplication(); //da zatvorimo aplikaciju
            this.addRecipeMenuItem.Click += (sender, e) => MenuHelper.AddRecipe(this); //dodavanje novog recepta preko menu helper - a
            this.addIngredientMenuItem.Click += (sender, e) => MenuHelper.AddIngredient(new FrmIngredients());

            //izvještaji
            allRcpReportMenuItem.Click += (sender, e) => MenuHelper.AllRcpReportMenuItem_Click();
            allIngrReportMenuItem.Click += (sender, e) => MenuHelper.AllIngrReportMenuItem_Click();
            allMenusReportMenuItem.Click += (sender, e) => MenuHelper.AllMenusReportMenuItem_Click();

            this.btnEditRecipe.Click += BtnEditRecipe_Click; //da ga ažuriramo
            this.btnDeleteRecipe.Click += BtnDeleteRecipe_Click; //da ga obrišemo
            this.btnSearch.Click += BtnSearch_Click; //search funkcionalnost
            this.btnAddToMenu.Click += BtnAddToMenu_Click; //da dodamo recept u meni
            this.dgRecipes.CellClick += DgRecipes_CellClick; //da se selektuje onaj na čije polje kliknemo 

            //da bi omogućili automatsko dodavanje/ažuriranje redova preko data - grida
            this.dgRecipes.RowValidated += DgRecipes_RowValidated;

            InitDataSqlAdapter();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = this.txtNameSearch.Text;

            int timeTo;
            int.TryParse(this.txtTimeTo.Text, out timeTo);
            if (timeTo == 0) timeTo = -1;

            int timeFrom;
            int.TryParse(this.txtTimeFrom.Text, out timeFrom);
            if (timeFrom == 0) timeFrom = -1;

            int numPortions;
            int.TryParse(this.txtNumPortionSearch.Text, out numPortions);
            if (numPortions == 0) numPortions = -1;

            this.data = RecipeRepository.SearchRecipes(searchText, timeFrom, timeTo, numPortions);
            if (this.data != null)
            {
                this.dgRecipes.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju recepata!");
            }
        }

        public void InitData() //pokretanje programa, a kasnije će biti sa SQL adapterom
        {
            this.data = RecipeRepository.GetRecipesDataTable();
            if (this.data != null)
            {
                this.dgRecipes.DataSource = this.data;
                this.dgRecipes.AllowUserToAddRows = false;
                this.dgRecipes.AllowUserToDeleteRows = false;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju recepata!");
            }
        }

        private void dgRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgRecipes.CurrentRow != null)
            {
                var cellValue = dgRecipes.CurrentRow.Cells["ReceptID"].Value;

                //provjerimo da li je vrijednost NULL ili DBNull
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int recipeId = Convert.ToInt32(cellValue);
                    DataTable ingredientsData = RecipeRepository.GetIngredientsByRecipeId(recipeId);
                    dgIngredients.DataSource = ingredientsData;
                }
                else
                {
                    //ako je vrijednost DBNull ili null, očistimo dgIngredients
                    dgIngredients.DataSource = null;
                }
            }
        }

        private void BtnAddToMenu_Click(object sender, EventArgs e)
        {
            if (this.selectedRecipeID == -1)
            {
                MessageBox.Show("Odaberite recept koji biste da dodate u meni!");
            }
            else
            {
                AddRecipeToMenu frmAdd = new AddRecipeToMenu(this.selectedRecipeID);
                frmAdd.ShowDialog();
            }
        }

        private void BtnEditRecipe_Click(object sender, EventArgs e)
        {
            if (this.selectedRecipeID == -1)
            {
                MessageBox.Show("Odaberi jedan recept od predstavljenih.");
            }
            else
            {
                FrmRecipe rcpForm = new FrmRecipe(this, this.selectedRecipeID); //forma za edit je ista kao za add, samo sa drugačijim tekstom
                rcpForm.ShowDialog();
            }
        }

        private void BtnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (this.selectedRecipeID == -1)
            {
                MessageBox.Show("Odaberite recept da biste ga obrisali!");
            }
            else
            {
                Dialog customDialog = new Dialog("Da li ste sigurni da želite da obrišete recept?");
                DialogResult dialogR = customDialog.ShowDialog();
                if (dialogR == DialogResult.Yes)
                {
                    bool result = RecipeRepository.DeleteRecipe(this.selectedRecipeID);
                    if (result)
                    {
                        this.InitData();
                        MessageBox.Show("Recept obrisan!");
                    }
                    else
                    {
                        MessageBox.Show("Greška pri brisanju recepta!");
                    }
                }
            }
        }

        private void DgRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex; //indeks reda
            if (rowIndex != -1 && rowIndex < this.data.Rows.Count) //ako je ispravan, postavimo ga
            {
                DataRow dataRow = this.data.Rows[rowIndex];
                this.selectedRecipeID = (int)dataRow.ItemArray[0]; //označimo selektovanog
            }
        }

        public void InitDataSqlAdapter() //pokretanje sa SQL adapterom, da bi se omogućilo pisanje u data grid 
        {
            string selectCommandText = "SELECT * FROM Recepti";
            string connectionString = "Server=MILICA;Database=ReceptDB;Trusted_Connection=True;";
            sqlDataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            this.dgRecipes.DataSource = dataSet.Tables[0];
            this.data = dataSet.Tables[0];
        }

        private void DgRecipes_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)this.dgRecipes.DataSource).GetChanges();

            if (changes != null && changes.Rows.Count > 0)
            {
                foreach (DataRow row in changes.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        //izračunamo UkupnoVrijeme kao zbir VrijemePripreme i VrijemeKuvanja
                        int vrijemePripreme = row["VrijemePripreme"] != DBNull.Value ? Convert.ToInt32(row["VrijemePripreme"]) : 0;
                        int vrijemeKuvanja = row["VrijemeKuvanja"] != DBNull.Value ? Convert.ToInt32(row["VrijemeKuvanja"]) : 0;
                        row["UkupnoVrijeme"] = vrijemePripreme + vrijemeKuvanja;
                    }
                }

                //ažuriramo bazu podataka
                sqlDataAdapter.Update(changes);
                ((DataTable)this.dgRecipes.DataSource).AcceptChanges();
            }
        }

    }
}
