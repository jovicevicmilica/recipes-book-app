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
    public partial class FrmMenus : Form
    {
        private int selectedMenuID = -1;
        DataTable data;

        SqlDataAdapter sqlDataAdapter; //da bi omogućili automatsko dodavanje/ažuriranje preko grid - a
        SqlCommandBuilder sqlCommandBuilder;

        public FrmMenus()
        {
            InitializeComponent();
            this.dgMenus.SelectionChanged += new EventHandler(dgMenus_SelectionChanged); //kada selektujemo meni, prikazaće nam recepte za taj meni
            this.exitMenuItem.Click += (sender, e) => MenuHelper.ExitApplication(); //da zatvorimo aplikaciju
            this.addRecipeMenuItem.Click += (sender, e) => MenuHelper.AddRecipe(new FrmRecipes()); //dodavanje novog recepta preko menu helper - a
            this.addIngredientMenuItem.Click += (sender, e) => MenuHelper.AddIngredient(new FrmIngredients());
            this.addMenuMenuItem.Click += (sender, e) => MenuHelper.AddMenu(this);

            //izvještaji
            allRcpReportMenuItem.Click += (sender, e) => MenuHelper.AllRcpReportMenuItem_Click();
            allIngrReportMenuItem.Click += (sender, e) => MenuHelper.AllIngrReportMenuItem_Click();
            allMenusReportMenuItem.Click += (sender, e) => MenuHelper.AllMenusReportMenuItem_Click();

            this.btnEditMenu.Click += BtnEditMenu_Click; //da ga ažuriramo
            this.btnDeleteMenu.Click += BtnDeleteMenu_Click; //da ga obrišemo
            this.btnSearch.Click += BtnSearch_Click; //search funkcionalnost
            this.dgMenus.CellClick += DgMenus_CellClick; //da se selektuje onaj na čije polje kliknemo 

            //da bi omogućili automatsko dodavanje/ažuriranje redova preko data - grida
            this.dgMenus.RowValidated += DgMenus_RowValidated;

            InitDataSqlAdapter();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = this.txtNameSearch.Text;

            this.data = MenuRepository.SearchMenus(searchText);
            if (this.data != null)
            {
                this.dgMenus.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju menija!");
            }
        }

        public void InitData() //pokretanje programa, a kasnije će biti sa SQL adapterom
        {
            this.data = MenuRepository.GetMenusDataTable();
            if (this.data != null)
            {
                this.dgMenus.DataSource = this.data;
                this.dgMenus.AllowUserToAddRows = false;
                this.dgMenus.AllowUserToDeleteRows = false;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju menija!");
            }
        }

        private void dgMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMenus.CurrentRow != null)
            {
                var cellValue = dgMenus.CurrentRow.Cells["MeniID"].Value;

                //provjerimo da li je vrijednost NULL ili DBNull
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int menuID = Convert.ToInt32(cellValue);
                    DataTable recipesData = MenuRepository.GetRecipesByMenuID(menuID);
                    dgRecipes.DataSource = recipesData;
                }
                else
                {
                    //ako je vrijednost DBNull ili null, očistimo dgIngredients
                    dgRecipes.DataSource = null;
                }
            }
        }

        private void BtnEditMenu_Click(object sender, EventArgs e)
        {
            if (this.selectedMenuID == -1)
            {
                MessageBox.Show("Odaberi jedan meni od predstavljenih.");
            }
            else
            {
                FrmMenu menuForm = new FrmMenu(this, this.selectedMenuID); //forma za edit je ista kao za add, samo sa drugačijim tekstom
                menuForm.ShowDialog();
            }
        }

        private void BtnDeleteMenu_Click(object sender, EventArgs e)
        {
            if (this.selectedMenuID == -1)
            {
                MessageBox.Show("Odaberite meni da biste ga obrisali!");
            }
            else
            {
                Dialog customDialog = new Dialog("Da li ste sigurni da zelite da obrisete meni?");
                DialogResult dialogR = customDialog.ShowDialog();
                if (dialogR == DialogResult.Yes)
                {
                    bool result = MenuRepository.DeleteMenu(this.selectedMenuID);
                    if (result)
                    {
                        this.InitData();
                        MessageBox.Show("Meni obrisan!");
                    }
                    else
                    {
                        MessageBox.Show("Greška pri brisanju menija!");
                    }
                }
            }
        }

        private void DgMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex; //indeks reda
            if (rowIndex != -1 && rowIndex < this.data.Rows.Count) //ako je ispravan, postavimo ga
            {
                DataRow dataRow = this.data.Rows[rowIndex];
                this.selectedMenuID = (int)dataRow.ItemArray[0]; //označimo selektovanog
            }
        }

        public void InitDataSqlAdapter() //pokretanje sa SQL adapterom, da bi se omogućilo pisanje u data grid 
        {
            string selectCommandText = "SELECT * FROM Meni";
            string connectionString = "Server=MILICA;Database=ReceptDB;Trusted_Connection=True;";
            sqlDataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            this.dgMenus.DataSource = dataSet.Tables[0];
            this.data = dataSet.Tables[0];
        }

        private void DgMenus_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)this.dgMenus.DataSource).GetChanges();

            if (changes != null)
            {
                sqlDataAdapter.Update(changes);
                ((DataTable)this.dgMenus.DataSource).AcceptChanges();
            }
        }
    }
}
