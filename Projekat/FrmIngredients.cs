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
    public partial class FrmIngredients : Form
    {
        DataTable data;
        public FrmIngredients()
        {
            InitializeComponent();
            InitData();
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
    }
}
