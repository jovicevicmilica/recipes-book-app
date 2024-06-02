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
    public partial class FrmIngredients : Form
    {
        private int selectedIngredientID = -1;
        DataTable data;

        SqlDataAdapter sqlDataAdapter; //da bi omogućili automatsko dodavanje/ažuriranje preko grid - a
        SqlCommandBuilder sqlCommandBuilder;
        public FrmIngredients()
        {
            InitializeComponent();
            this.viewIngredientsMenuItem.Click += (sender, e) => MenuHelper.PreviewIngredients(this);
            this.viewRecipesMenuItem.Click += (sender, e) => MenuHelper.PreviewRecipes(this);
            this.exitMenuItem.Click += (sender, e) => MenuHelper.ExitApplication();
            this.addRecipeMenuItem.Click += (sender, e) => MenuHelper.AddRecipe(new FrmRecipes()); //dodavanje novog recepta preko menu helper - a, vraćemo se na glavnu formu recepata kad ga dodamo
            this.addIngredientMenuItem.Click += (sender, e) => MenuHelper.AddIngredient(this);

            //izvještaji
            allRcpReportMenuItem.Click += (sender, e) => MenuHelper.AllRcpReportMenuItem_Click();
            allIngrReportMenuItem.Click += (sender, e) => MenuHelper.AllIngrReportMenuItem_Click();

            this.btnEditIngredient.Click += BtnEditIngredient_Click; //da ga ažuriramo
            this.btnDeleteIngredient.Click += BtnDeleteIngredient_Click; //da ga obrišemo
            this.dgIngredients.CellClick += DgIngredients_CellClick; ; //da se selektuje onaj na čije polje kliknemo 

            this.dgIngredients.RowValidated += DgIngredients_RowValidated;

            InitDataSqlAdapter();
        }

        public void InitData()
        {
            this.data = IngredientRepository.GetIngredientsDataTable();
            if (this.data != null)
            {
                this.dgIngredients.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greška pri prikazivanju recepata!");
            }
        }

        private void BtnEditIngredient_Click(object sender, EventArgs e)
        {
            if (this.selectedIngredientID == -1)
            {
                MessageBox.Show("Odaberi jedan sastojak od predstavljenih.");
            }
            else
            {
                FrmIngredient ingrForm = new FrmIngredient(this, this.selectedIngredientID); //forma za edit je ista kao za add, samo sa drugačijim tekstom
                ingrForm.ShowDialog();
            }
        }

        private void BtnDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (this.selectedIngredientID == -1)
            {
                MessageBox.Show("Odaberite sastojak da biste ga obrisali!");
            }
            else
            {
                Dialog customDialog = new Dialog("Da li ste sigurni da zelite da obrisete sastojak?");
                DialogResult dialogR = customDialog.ShowDialog();
                if (dialogR == DialogResult.Yes)
                {
                    bool result = RecipeRepository.DeleteRecipe(this.selectedIngredientID);
                    if (result)
                    {
                        this.InitData();
                        MessageBox.Show("Sastojak obrisan!");
                    }
                    else
                    {
                        MessageBox.Show("Greska pri brisanju sastojka!");
                    }
                }
            }
        }

        private void DgIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex; //indeks reda
            if (rowIndex != -1 && rowIndex < this.data.Rows.Count) //ako je ispravan, postavimo ga
            {
                DataRow dataRow = this.data.Rows[rowIndex];
                this.selectedIngredientID = (int)dataRow.ItemArray[0]; //označimo selektovanog
            }
        }

        public void InitDataSqlAdapter() //pokretanje sa SQL adapterom, da bi se omogućilo pisanje u data grid 
        {
            string selectCommandText = "SELECT * FROM Sastojci";
            string connectionString = "Server=MILICA;Database=ReceptDB;Trusted_Connection=True;";
            sqlDataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            this.dgIngredients.DataSource = dataSet.Tables[0];
            this.data = dataSet.Tables[0];
        }

        private void DgIngredients_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)this.dgIngredients.DataSource).GetChanges();

            if (changes != null)
            {
                sqlDataAdapter.Update(changes);
                ((DataTable)this.dgIngredients.DataSource).AcceptChanges();
            }
        }
    }
}
