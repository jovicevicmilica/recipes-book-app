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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnViewIngredients.Click += BtnViewIngredients_Click;
            btnViewRecipes.Click += BtnViewRecipes_Click;
            btnViewMenus.Click += BtnViewMenus_Click;
        }

        private void BtnViewIngredients_Click(object sender, EventArgs e)
        {
            FrmIngredients frmIngredients = new FrmIngredients();
            this.Hide(); // Hide MainForm
            frmIngredients.FormClosed += (s, args) => this.Show(); // Show MainForm again when FrmIngredients is closed
            frmIngredients.Show();
        }

        private void BtnViewRecipes_Click(object sender, EventArgs e)
        {
            FrmRecipes frmRecipes = new FrmRecipes();
            this.Hide(); // Hide MainForm
            frmRecipes.FormClosed += (s, args) => this.Show(); // Show MainForm again when FrmRecipes is closed
            frmRecipes.Show();
        }

        private void BtnViewMenus_Click(object sender, EventArgs e)
        {
            FrmMenus frmMenus = new FrmMenus();
            this.Hide(); // Hide MainForm
            frmMenus.FormClosed += (s, args) => this.Show(); // Show MainForm again when FrmMenus is closed
            frmMenus.Show();
        }
    }
}
